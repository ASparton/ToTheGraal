using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BaseSim2021
{
    public partial class ChangePolicyView : Form
    {
        private IndexedValueView Value = null;
        private int WorldGold, WorldGlory;
        public int ChosenValue { get; private set; }

        /// <summary>
        /// Create a window that will change the value of the given policy
        /// </summary>
        /// <param name="policy">the policy</param>
        public ChangePolicyView(IndexedValueView policy, int worldGold, int worldGlory)
        {
            InitializeComponent();
            Value = policy;
            WorldGold = worldGold;
            WorldGlory = worldGlory;
            InitialiseLabels();

            // Value changer and progress bar initialisation
            ValueChanger.Maximum = ProgressBar.Maximum = Value.Value.MaxValue;
            ValueChanger.Minimum = ProgressBar.Minimum = Value.Value.MinValue;
            ValueChanger.Value = ProgressBar.Value = ChosenValue = Value.Value.Value;
        }

        /// <summary>
        /// Initialise the text of all labels
        /// </summary>
        private void InitialiseLabels()
        {
            ValueNameLabel.Text = Value.Value.Name;
            ValueDescriptionLabel.Text = Value.Value.Description;
            MinValueLabel.Text = "Minimum: " + Value.Value.MinValue;
            MaxValueLabel.Text = "Maximum: " + Value.Value.MaxValue;

            int goldCost, gloryCost;
            int previewValue = ProgressBar.Value = (int)ValueChanger.Value;
            Value.Value.PreviewPolicyChange(ref previewValue, out goldCost, out gloryCost);
            UpdateCostsLabels(Math.Abs(goldCost), Math.Abs(gloryCost));
        }

        /// <summary>
        /// Update the preview of the cost.
        /// </summary>
        /// <param name="goldCost">The cost in gold</param>
        /// <param name="gloryCost">The cost in glory</param>
        private void UpdateCostsLabels(int goldCost, int gloryCost)
        {
            GoldCostLabel.Text = "Coût en or (par tour) : " + goldCost;
            GloryCostLabel.Text = "Coût en gloire (immédiat) : " + gloryCost;
            GoldRemainderLabel.Text = "Ors par tour si achat : " + 
                ((WorldGold - goldCost >= 0) ? (WorldGold - goldCost).ToString() : "0");
            GloryRemainderLabel.Text = "Restes de gloire si achat : " +
                ((WorldGlory - gloryCost >= 0) ? (WorldGlory - gloryCost).ToString() : "0");
        }

        #region Event handling

        private void ValueChanger_ValueChanged(object sender, EventArgs e)
        {
            int goldCost, gloryCost;
            int previewValue = ProgressBar.Value = (int)ValueChanger.Value;
            Value.Value.PreviewPolicyChange(ref previewValue, out goldCost, out gloryCost);
            UpdateCostsLabels(-goldCost, -gloryCost);
        }

        private void ConfirmButton_Click(object sender, EventArgs e) => ChosenValue = (int)ValueChanger.Value;

        private void CancelButton_Click(object sender, EventArgs e) => ChosenValue = Value.Value.Value;

        /// <summary>
        /// Display the links in a message box.
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">the event arguments</param>
        private void LinksViewButton_Click(object sender, EventArgs e)
        {
            if (Value.Value.OutputWeights.Count > 0)
            {
                string links = "";
                foreach (KeyValuePair<IndexedValue, double> link in Value.Value.OutputWeights)
                    links += link.Key.Name + ((link.Value < 0) ? " <" : " >") + "\n\n";
                MessageBox.Show(links, "Liens");
            }
        }

        /// <summary>
        /// Display the history of the value in a message box.
        /// </summary>
        /// <param name="sender">the history button</param>
        /// <param name="e">the event arguments</param>
        private void HistoryViewButton_Click(object sender, EventArgs e)
        {
            string history = "";
            foreach (KeyValuePair<int, int> historyLine in Value.ValueHistory)
                history += "Tour " + historyLine.Key + " : " + historyLine.Value + ".\n\n";
            MessageBox.Show(history, "Historique");
        }

        #endregion
    }
}
