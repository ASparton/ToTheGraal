using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseSim2021
{
    public partial class IndexedValueInfosView : Form
    {
        private IndexedValueView Value { get; set; } = null;
        public IndexedValueInfosView(IndexedValueView value)
        {
            InitializeComponent();
            Value = value;

            // Labels initialisation
            ValueNameLabel.Text = value.Value.Name;
            ValueDescriptionLabel.Text = value.Value.Description;
            ActualValueLabel.Text = "Valeur actuelle : " + value.Value.Value;
            MinValueLabel.Text = "Valeur minimale : " + value.Value.MinValue;
            MaxValueLabel.Text = "Valeur maximale : " + value.Value.MaxValue;

            if (value.Value.MoneyAmount.HasValue && value.Value.MoneyAmount.GetValueOrDefault(0) < 0)
                MoneyImpactLabel.Text = "Coûte " + value.Value.MoneyImpacted + " pièces d'or par tour.";
            else if (value.Value.MoneyAmount.HasValue && value.Value.MoneyAmount.GetValueOrDefault(0) > 0)
                MoneyImpactLabel.Text = "Rapporte " + value.Value.MoneyImpacted + " pièces d'or par tour.";

            if (value.Value.GloryAmount.HasValue && value.Value.GloryAmount.GetValueOrDefault(0) < 0)
                GloryImpactedLabel.Text = "Coûte " + Math.Abs(value.Value.GloryAmount.Value) + " gloire.";
            else if (value.Value.GloryAmount.HasValue && value.Value.GloryAmount.GetValueOrDefault(0) > 0)
                GloryImpactedLabel.Text = "Rapporte " + value.Value.GloryImpacted + " gloire par tour.";

            ValueActiveLabel.Text = "Actuellement " + ((value.Value.Active == true) ? "en action." : "hors action.");
        }

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
    }
}
