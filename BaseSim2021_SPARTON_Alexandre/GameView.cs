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
        private List<IndexedValueView> valueViews;
        /// <summary>
        /// The constructor for the main window
        /// </summary>
        public GameView(WorldState world)
        {
            InitializeComponent();
            theWorld = world;

            valueViews = new List<IndexedValueView>();
            BuildAllIndexedValues();
        }
        /// <summary>
        /// Method called by the controler whenever some text should be displayed
        /// </summary>
        /// <param name="s"></param>
        public void WriteLine(string s)
        {
            List<string> strs = s.Split('\n').ToList();
            strs.ForEach(str=>outputListBox.Items.Add(str));
            if (outputListBox.Items.Count > 0)
            {
                outputListBox.SelectedIndex = outputListBox.Items.Count - 1;
            }
            outputListBox.Refresh();
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
            BuildValueView(firstIndicators, IndicatorBox1);
            BuildValueView(secondIndicators, IndicatorBox2);

            BuildValueView(theWorld.Groups, GroupsBox);
            BuildValueView(theWorld.Policies, PoliciesBox);

        }

        /// <summary>
        /// Set the position of the given indexed values in the given container in their assigned box.
        /// <param name="ValuesToDisplay">The indexed values</param>
        /// <param name="container">The containers of the values</param>
        /// </summary>
        private void BuildValueView(List<IndexedValue> ValuesToDisplay, GroupBox container)
        {
            List<List<IndexedValueView>> valueViewsColumns = GetValueViewsByColumn(container, ValuesToDisplay);

            // Position intialisation for each column of value views
            const int marginY = 15;
            int y = 25;

            foreach (List<IndexedValueView> column in valueViewsColumns)
            {
                int marginX = (container.Size.Width - (IndexedValueView.BoxSize.Width * column.Count)) / column.Count;
                marginX -= marginX / (column.Count + 1);

                int x;
                if (column.Count == 2 || column.Count > 3)
                    x = marginX + marginX/3;
                else
                    x = marginX;

                foreach (IndexedValueView valueView in column)
                {
                    valueView.Position = new Point(x, y);
                    // Add all values in the valueViews list
                    valueViews.Add(valueView);

                    x += IndexedValueView.BoxSize.Width + marginX;
                }

                y += IndexedValueView.BoxSize.Height + marginY;
            }
        }

        /// <summary>
        /// Get the indexed value view per column.
        /// </summary>
        /// <param name="container">The container of the value</param>
        /// <param name="values">The values to create their view</param>
        /// <returns>An List<List<IndexValueView>> containing the values view for each column"</returns>
        private List<List<IndexedValueView>> GetValueViewsByColumn(GroupBox container, List<IndexedValue> values)
        {
            const int baseMarginX = 30;
            int numberOfBoxMax = container.Size.Width / (IndexedValueView.BoxSize.Width + baseMarginX);
            List<List<IndexedValueView>> valuesByColumn = new List<List<IndexedValueView>>();
            valuesByColumn.Add(new List<IndexedValueView>());

            int boxCounter = 0, listCounter = 0;
            while (values.Count > 0)
            {
                IndexedValue value = values[0];
                if (boxCounter < numberOfBoxMax)
                {
                    valuesByColumn[listCounter].Add(new IndexedValueView(value, container, new Point(), getValueBoxColor(value)));
                    values.Remove(value);
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
        private Color getValueBoxColor(IndexedValue value)
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

        #region Event handling
        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            diffLabel.Text = "Difficulté : " + theWorld.TheDifficulty;
            int currentTurn = theWorld.Turns + 1;
            turnLabel.Text = "Tour " + currentTurn;
            moneyLabel.Text = "Trésor : " + theWorld.Money + " pièces d'or";
            gloryLabel.Text = "Gloire : " + theWorld.Glory;
            NextTurnButton.Visible = true;
        }

        private void PerksAndCrisesBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (IndexedValueView valueView in valueViews)
            {
                if (valueView.Container == PerksAndCrisesBox)
                    valueView.Display(e.Graphics);
            }
        }

        private void IndicatorBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (IndexedValueView valueView in valueViews)
            {
                if (valueView.Container == IndicatorBox1)
                    valueView.Display(e.Graphics);
            }
        }

        private void GroupsBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (IndexedValueView valueView in valueViews)
            {
                if (valueView.Container == GroupsBox)
                    valueView.Display(e.Graphics);
            }
        }

        private void IndicatorBox2_Paint(object sender, PaintEventArgs e)
        {
            foreach (IndexedValueView valueView in valueViews)
            {
                if (valueView.Container == IndicatorBox2)
                    valueView.Display(e.Graphics);
            }
        }

        private void PoliciesBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (IndexedValueView valueView in valueViews)
            {
                if (valueView.Container == PoliciesBox)
                    valueView.Display(e.Graphics);
            }
        }

        private void NextTurnButton_Click(object sender, EventArgs e) => GameController.Interpret("suivant");

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                e.SuppressKeyPress = true; // Or beep.
                GameController.Interpret(inputTextBox.Text);
            }
        }
        #endregion

        #region Game end handling

        public void DisplayLoseDialog(IndexedValue indexedValue)
        {
            if (indexedValue == null)
            {
                MessageBox.Show("Partie perdue : dette insurmontable.");
            }
            else
            {
                MessageBox.Show("Partie perdue :" + indexedValue.CompletePresentation());
            }
            NextTurnButton.Enabled = false;
        }

        public void DisplayWinDialog()
        {
            MessageBox.Show("Partie gagnée : Vous avez activé le Graal, bravo !");
            NextTurnButton.Enabled = false;
        }


        #endregion
    }
}
