using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BaseSim2021
{
    public partial class GameView : Form
    {
        private readonly WorldState theWorld;

        // Value views
        private readonly List<IndexedValueView> ValueViews;
        private readonly List<IndexedValueView> ConsulteValueViews;  // All values except policies
        private readonly List<IndexedValueView> Policies;
        private IndexedValueView HoveredValue;  // Represents the current selected value to view its links

        // Value containers
        private ValueContainer PerksAndCrisesBox;
        private ValueContainer IndicatorsBox1;
        private ValueContainer GroupsBox;
        private ValueContainer IndicatorsBox2;
        private ValueContainer PoliciesBox;

        /// <summary>
        /// The constructor for the main window. Initialise the value views.
        /// </summary>
        public GameView(WorldState world)
        {
            InitializeComponent();
            theWorld = world;

            InitialiseContainers();

            // Initialisation of the values
            ValueViews = new List<IndexedValueView>();
            BuildAllIndexedValues();
            ConsulteValueViews = ValueViews.FindAll(valueView => valueView.Container != PoliciesBox);
            Policies = ValueViews.FindAll(valueView => valueView.Container == PoliciesBox);
            HoveredValue = null;
        }

        /// <summary>
        /// Method called by the controler whenever a confirmation should be asked
        /// </summary>
        /// <returns>Yes iff confirmed</returns>
        public bool ConfirmDialog()
        {
            string message = "Confirmer ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, "", buttons) == DialogResult.Yes;
        }

        #region Value containers building

        /// <summary>
        /// Initialise the value containers with specific positions and colors.
        /// </summary>
        private void InitialiseContainers()
        {
            PerksAndCrisesBox = new ValueContainer(new Point(10, 50), new Size(1565, 290), Color.MintCream, "Crises et bénéfices");
            IndicatorsBox1 = new ValueContainer(new Point(10, 347), new Size(515, 200), Color.Azure, "Indicateurs");
            GroupsBox = new ValueContainer(new Point(535, 347), new Size(515, 200), Color.Gainsboro, "Groupes");
            IndicatorsBox2 = new ValueContainer(new Point(1060, 347), new Size(515, 200), Color.Azure, "Indicateurs");
            PoliciesBox = new ValueContainer(new Point(10, 557), new Size(1565, 290), Color.Thistle, "Politiques");
        }

        #endregion

        #region IndexedValueView building
        /// <summary>
        /// Display all the indexed values on their respective part of the screen.
        /// </summary>
        private void BuildAllIndexedValues()
        {
            BuildValueView(new List<IndexedValue>(theWorld.Crises.Concat(theWorld.Perks)), PerksAndCrisesBox);

            // Indicators building
            List<IndexedValue> firstIndicators = new List<IndexedValue>();
            List<IndexedValue> secondIndicators = new List<IndexedValue>();
            for (int i = 0; i < theWorld.Indicators.Count; i++)
            {
                if (i < theWorld.Indicators.Count / 2)
                    firstIndicators.Add(theWorld.Indicators[i]);
                else
                    secondIndicators.Add(theWorld.Indicators[i]);
            }
            BuildValueView(firstIndicators, IndicatorsBox1);
            BuildValueView(secondIndicators, IndicatorsBox2);

            BuildValueView(theWorld.Groups, GroupsBox);
            BuildValueView(theWorld.Policies, PoliciesBox);

        }

        /// <summary>
        /// Set the position of the given indexed values in the given container in their assigned box.
        /// <param name="ValuesToDisplay">The indexed values</param>
        /// <param name="container">The containers of the values</param>
        /// </summary>
        private void BuildValueView(List<IndexedValue> ValuesToDisplay, ValueContainer container)
        {
            List<List<IndexedValueView>> valueViewsColumns = GetValueViewsByLine(container, ValuesToDisplay);

            // Position intialisation for each column of value views
            const int marginY = 20;
            int y = container.Location.Y + marginY;

            foreach (List<IndexedValueView> column in valueViewsColumns)
            {
                int marginX = (container.Size.Width - (IndexedValueView.BoxSize.Width * column.Count)) / column.Count;
                marginX -= marginX / (column.Count + 1);

                int x = container.Location.X;
                if (column.Count == 2 || column.Count > 3)
                    x += marginX + marginX / 3;
                else
                    x += marginX;

                foreach (IndexedValueView valueView in column)
                {
                    valueView.Position = new Point(x, y);
                    // Add all values in the valueViews list
                    ValueViews.Add(valueView);

                    x += IndexedValueView.BoxSize.Width + marginX;
                }

                y += IndexedValueView.BoxSize.Height + marginY;
            }
        }

        /// <summary>
        /// Get the indexed value view per row.
        /// </summary>
        /// <param name="container">The container of the value</param>
        /// <param name="values">The values to create their view</param>
        /// <returns>An List<List<IndexValueView>> containing the values view for each row"</returns>
        private List<List<IndexedValueView>> GetValueViewsByLine(ValueContainer container, List<IndexedValue> values)
        {
            const int baseMarginX = 30;
            int maxNumberOfBox = container.Size.Width / (IndexedValueView.BoxSize.Width + baseMarginX);
            List<List<IndexedValueView>> valuesByColumn = new List<List<IndexedValueView>>
            {
                new List<IndexedValueView>()
            };

            int boxCounter = 0, listCounter = 0, valueCounter = 0;
            while (valueCounter < values.Count)
            {
                IndexedValue value = values[valueCounter];
                if (boxCounter < maxNumberOfBox)
                {
                    valuesByColumn[listCounter].Add(new IndexedValueView(value, container, new Point(), 
                        GetValueBoxColor(value), container.BackColor));
                    valueCounter++;
                    boxCounter++;
                }
                else
                {
                    valuesByColumn.Add(new List<IndexedValueView>());
                    boxCounter = 0;
                    listCounter++;
                }
            }

            return valuesByColumn;
        }

        /// <summary>
        /// Determine the box's borders color of a given value depending on its type.
        /// </summary>
        /// <param name="value">the value to evaluate the color</param>
        /// <returns>the box's borders color</returns>
        private Color GetValueBoxColor(IndexedValue value)
        {
            switch (value.Type)
            {
                case IndexedValue.ValueType.Crisis:
                    return Color.Red;
                case IndexedValue.ValueType.Perk:
                    return Color.Green;
                case IndexedValue.ValueType.Policy:
                    return Color.DarkMagenta;
                case IndexedValue.ValueType.Indicator:
                    return Color.Blue;
                default:
                    return Color.Black;
            }
        }

        #endregion

        #region Display handling

        private void ContainersDisplay(Graphics window)
        {
            PoliciesBox.Display(window);
            PerksAndCrisesBox.Display(window);
            GroupsBox.Display(window);
            IndicatorsBox1.Display(window);
            IndicatorsBox2.Display(window);
        }

        private void UpdateGlobalInfos()
        {
            diffLabel.Text = "Difficulté : " + theWorld.TheDifficulty;
            int currentTurn = theWorld.Turns + 1;
            turnLabel.Text = "Tour " + currentTurn;
            moneyLabel.Text = "Trésor : " + theWorld.Money + " pièces d'or";
            gloryLabel.Text = "Gloire : " + theWorld.Glory;
            NextTurnButton.Visible = true;
        }

        private void ConsulteValuesDisplay(Graphics window)
        {
            ConsulteValueViews.ForEach(valueView => valueView.Active = IsValueActive(valueView.Value));
            ConsulteValueViews.ForEach(valueView => valueView.Display(window));
        }

        private void PoliciesDisplay(Graphics window)
        {
            Policies.ForEach(v => v.Opacity = GetOpacity(v.Value));
            Policies.ForEach(v => v.Active = IsValueActive(v.Value));
            Policies.ForEach(v => v.Display(window));
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            ContainersDisplay(e.Graphics);

            // Link lines display
            if (HoveredValue != null)
                GetLinkLines(HoveredValue).ForEach(line => line.Display(e.Graphics));

            // Values display
            UpdateGlobalInfos();
            ConsulteValuesDisplay(e.Graphics);
            PoliciesDisplay(e.Graphics);
            ValueViews.FindAll(value => value.Opacity != 255).ForEach(value => value.Opacity = 255);
        }

        #endregion

        #region Click interactions managment
        private void NextTurnButton_Click(object sender, EventArgs e)
        {
            GameController.Interpret("suivant");
            UpdateValuesHistory();
        }

        /// <summary>
        /// Display the change policy view or a dialog box saying when the policy will be available.
        /// </summary>
        /// <param name="valueView">The policy</param>
        private void DisplayPoliciesInfos(IndexedValueView valueView)
        {
            if (IsPolicyAvailable(valueView.Value))
            {
                ChangePolicyView changePolicyView = new ChangePolicyView(valueView, theWorld.Money, theWorld.Glory);
                changePolicyView.ShowDialog();
                if (valueView.Value.Value != changePolicyView.ChosenValue)
                {
                    GameController.ApplyPolicyChanges(valueView.Value.Name + " " + changePolicyView.ChosenValue);
                    valueView.ValueHistory.Add(new KeyValuePair<int, int>(theWorld.Turns + 1, changePolicyView.ChosenValue));
                }
            }
            else
                MessageBox.Show("Cette politique sera disponible au tour "
                    + (valueView.Value.AvailableAt + 1).ToString()
                    + ".", "Politique non disponible");
        }

        /// <summary>
        /// Display the indexed value infos view of the given value.
        /// </summary>
        /// <param name="valueView">The value to display its informations</param>
        private void DisplayValueInfos(IndexedValueView valueView) => new IndexedValueInfosView(valueView).ShowDialog();

        private void GameView_MouseDown(object sender, MouseEventArgs e)
        {
            IndexedValueView valueClicked =
                ValueViews.FirstOrDefault(value => value.Contains(e.Location));

            if (valueClicked != null)
            {
                if (valueClicked.Container == PoliciesBox)
                    DisplayPoliciesInfos(valueClicked);
                else
                    DisplayValueInfos(valueClicked);
            }
        }

        #endregion

        #region Values linking managment

        /// <summary>
        /// Select or unselect the hovered value and its link depending on the mouse position
        /// </summary>
        private void GameView_MouseMove(object sender, MouseEventArgs e)
        {
            if (ValueViews.FirstOrDefault(value => value.Contains(e.Location)) != null)
            {
                HoveredValue = ValueViews.FirstOrDefault(value => value.Contains(e.Location));
                foreach (IndexedValueView value in ValueViews)
                {
                    if (!HoveredValue.Value.OutputWeights.ContainsKey(value.Value) 
                        && value != HoveredValue)
                    {
                        value.Opacity = 25;
                        value.BackColor = Color.FromArgb(0, value.BackColor);
                    }
                    else
                    {
                        value.Opacity = 255;
                        value.BackColor = Color.FromArgb(255, value.BackColor);
                    }
                }
                Refresh();
            }

            // If no value is selected, then stop the link display
            else if (HoveredValue != null)
            {
                HoveredValue = null;
                foreach (IndexedValueView value in ValueViews)
                {
                    if (value.Opacity != 255)
                    {
                        value.Opacity = 255;
                        value.BackColor = Color.FromArgb(255, value.BackColor);
                    }
                }
                Refresh();
            }
        }

        /// <summary>
        /// Determine the color of a line depending on the given value.
        /// </summary>
        /// <param name="valueWeight">the value to evaluate</param>
        /// <returns>Black if it's equal to 0, Red if negative and Green if positive</returns>
        private Color GetLineColor(double valueWeight)
        {
            if (valueWeight == 0.0)
                return Color.Black;
            else if (valueWeight < 0.0)
                return Color.Red;
            else
                return Color.Green;
        }

        /// <summary>
        /// Determine the thickness of a line depending on the given value.
        /// </summary>
        /// <param name="valueWeight">the value to evaluate</param>
        /// <returns>A higher thickness if the valueWeight is high</returns>
        private int GetLineThickness(double valueWeight)
        {
            if (Math.Abs(valueWeight) < 10)
                return 2;
            if (Math.Abs(valueWeight) < 20)
                return 3;
            else
                return 4;
        }

        /// <summary>
        /// Create the link lines corresponding to the link values from the given value.
        /// </summary>
        /// <param name="value">the value to create the link lines from</param>
        /// <returns>A list containing all the link lines ready to be displayed</returns>
        private List<LinkLine> GetLinkLines(IndexedValueView value)
        {
            List<LinkLine> linkedLines = new List<LinkLine>();

            foreach (KeyValuePair<IndexedValue, double> link in value.Value.OutputWeights)
            {
                IndexedValueView linkedValueView = ValueViews.Find(v => v.Value == link.Key);
                linkedLines.Add(new LinkLine(value.GetCenter(), linkedValueView.GetCenter(),
                    GetLineColor(link.Value),
                    GetLineThickness(link.Value)));
            }

            return linkedLines;
        }

        #endregion

        #region Game end handling

        public void DisplayLoseDialog(IndexedValue indexedValue)
        {
            if (indexedValue == null)
                MessageBox.Show("Partie perdue : dette insurmontable.", "Partie perdue");
            else
                MessageBox.Show("Partie perdue :" + indexedValue.CompletePresentation());
            NextTurnButton.Enabled = false;
        }

        public void DisplayWinDialog()
        {
            MessageBox.Show("Victoire : Vous avez activé le Graal, bravo !", "Partie terminée");
            NextTurnButton.Enabled = false;
        }


        #endregion

        #region utils
        /// <summary>
        /// Get the opacity of the value depending on if it is available or not
        /// </summary>
        /// <param name="value">the value to evaluate</param>
        /// <returns>full opacity if it is available and a reduce opacity otherwise</returns>
        private int GetOpacity(IndexedValue value)
        {
            if (HoveredValue != null && HoveredValue.Value == value)
                return 255;

            if ((IsPolicyAvailable(value) || IsValueActive(value)) && HoveredValue == null)
                return 255;

            return 50;
        }

        /// <summary>
        /// Determine wether a given value is active or not
        /// </summary>
        /// <param name="value">the value to evaluate</param>
        /// <returns>true if it is active, false otherwise</returns>
        private bool IsValueActive(IndexedValue value)
        {
            return value.Active != false;
        }

        /// <summary>
        /// Determine wether a given policy is available or not
        /// </summary>
        /// <param name="policy">the policy to evaluate</param>
        /// <returns>true if its is available, false otherwise</returns>
        private bool IsPolicyAvailable(IndexedValue policy)
        {
            return policy.AvailableAt <= theWorld.Turns || IsValueActive(policy);
        }

        /// <summary>
        /// Add the current value of all indexed value views in their history
        /// </summary>
        private void UpdateValuesHistory() => ValueViews.ForEach(value => value.ValueHistory.Add(
            new KeyValuePair<int, int>(theWorld.Turns + 1, value.Value.Value)));

        #endregion
    }
}
