using System;
using System.Collections.Generic;

namespace BaseSim2021
{
    /// <summary>
    /// Controler constructed for routing player interaction to the view.
    /// The current view used here is the Console.
    /// </summary>
    public static class GameController
    {
        #region attributes and methods for text interaction

        private static GameView theView;
        private static WorldState theWorld;
        private static readonly Dictionary<string, Action<string>> commands = new Dictionary<string, Action<string>>();

        /// <summary>
        /// Sets the global view
        /// </summary>
        /// <param name="view">The main window</param>
        public static void SetView(GameView view) => theView = view;

        private static string DefaultCommand { get; set; } = "aide";
        private static void MakeCommands()
        {
            commands.Add("politique", ApplyPolicyChanges);
            commands.Add("suivant", s => theWorld.NextTurn());
            commands.Add("quitter", s => Environment.Exit(0));
        }

        /// <summary>
        /// Interprets a string command and performs the required actions
        /// </summary>
        /// <param name="input">The string to interpret</param>
        public static void Interpret(string input)
        {
            if (theWorld.Finished())
            {
                theView.Refresh();
                return;
            }
            string command = input.Split(' ')[0];
            string arguments = input.Contains(" ") ? input.Substring(input.IndexOf(' ') + 1) : "";
            if (input == "")
            {
                commands[DefaultCommand]("");
                switch (DefaultCommand)
                {
                    case "aide": DefaultCommand = "etat"; break;
                    case "etat": DefaultCommand = "liste"; break;
                    case "suivant": DefaultCommand = "etat"; break;
                    default: DefaultCommand = "suivant"; break;
                }
            }
            else if (commands.ContainsKey(command))
            {
                commands[command](arguments);
            }
            theView.Refresh();
        }
        
        /// <summary>
        /// Sets the global state of the simulation
        /// </summary>
        /// <param name="world">The main world-state object</param>
        public static void SetWorld(WorldState world)
        {
            theWorld = world;
            MakeCommands();
            theView.Refresh();
        }

        #endregion

        #region public anchor methods

        /// <summary>
        /// Method called when a value is activated
        /// </summary>
        /// <param name="indexedValue">The newly active value</param>
        public static void Activate(IndexedValue indexedValue)
        {
            theView.Refresh();
        }

        /// <summary>
        /// Method called when a value is deactivated
        /// </summary>
        /// <param name="indexedValue">The newly inactive value</param>
        public static void Deactivate(IndexedValue indexedValue)
        {
            theView.Refresh();
        }

        /// <summary>
        /// Method called when a yes/no dialog should be displayed
        /// </summary>
        /// <returns>Yes iff confirmation is made</returns>
        public static bool ConfirmDialog()
        {
            return theView.ConfirmDialog();
        }

        /// <summary>
        /// Method called whenever the game is lost
        /// </summary>
        /// <param name="indexedValue">The value responsible or null for debt</param>
        public static void LoseDialog(IndexedValue indexedValue)
        {
            theView.DisplayLoseDialog(indexedValue);
            theView.Refresh();
        }
        /// <summary>
        /// Method called whenever the game is won
        /// </summary>
        public static void WinDialog()
        {
            theView.DisplayWinDialog();
            theView.Refresh();
        }

        /// <summary>
        /// Method called to change a policy
        /// </summary>
        /// <param name="arg">The arguments to the "policy" command</param>
        public static void ApplyPolicyChanges(string arg)
        {
            if (!arg.Contains(" "))
            {
                return;
            }
            string pol = arg.Split(' ')[0];
            int.TryParse(arg.Split(' ')[1], out int amount);
            if (amount < 0)
            {
                return;
            }
            IndexedValue val = theWorld.FindPolicyOrDefault(pol);
            if (val==null)
            {
                return;
            }

            int mCost;

            int gCost;
            if (amount == 0)
            {
                theWorld.DeactivatePolicy(val, out mCost, out gCost);
                theView.Refresh();
                return;
            }
            val.PreviewPolicyChange(ref amount, out mCost, out gCost);
            if (!ConfirmDialog())
            {
                return;
            }
            if (gCost < 0)
            {
                if (theWorld.CostGlory(gCost))
                {
                    val.ChangeTo(amount, out _, out _);
                    theView.Refresh();
                    return;
                }
                else
                {
                    return;
                }
            }
            val.ChangeTo(amount, out _, out _);
            theView.Refresh();
        }

        /// <summary>
        /// Method called when a policy is deactivated by the player
        /// </summary>
        /// <param name="gCost">The cost (glory)</param>
        public static void DeactivatePolicyDialog(int gCost) => theView.Refresh();

        #endregion
    }
}