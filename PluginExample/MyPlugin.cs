using System;
using System.Windows.Controls;
using System.Windows.Input;

using Hearthstone_Deck_Tracker.Plugins;

namespace PluginExample
{
    public class MyPlugin : IPlugin
    {
		public string Author
		{
			get { return "/u/DeLiri0us"; }
		}

		public string ButtonText
		{
			get { return "Setttings"; }
		}

		public string Description
		{
			get { return "Press F1 to open Hearthpwn and search for all the cards that your opponent has played."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "OpponentDeckToHearthPwn"; }
		}

		public void OnButtonPress()
		{
		}

		public void OnLoad()
		{
			MyCode.Load();
		}

		public void OnUnload()
		{
		}

		public void OnUpdate()
		{
            if (Keyboard.IsKeyDown(Key.F1))
            {
                System.Diagnostics.Process.Start(MyCode.URLToOpen);
            }
		}

		public Version Version
		{
			get { return new Version(0, 0, 2); }
		}
    }
}
