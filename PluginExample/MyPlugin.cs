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
			get { return "Name"; }
		}

		public string ButtonText
		{
			get { return "Setttings"; }
		}

		public string Description
		{
			get { return "Description"; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "PluginExample"; }
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
