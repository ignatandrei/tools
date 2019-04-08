using System;
using System.Collections.Generic;

namespace VS2019Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var shortcuts = new List<string>();
            //most important features
            shortcuts.Add("https://docs.microsoft.com/en-us/visualstudio/ide/whats-new-visual-studio-2019?view=vs-2019");
            //release notes for VS2019
            shortcuts.Add("https://docs.microsoft.com/en-us/visualstudio/releases/2019/release-notes");
            //live share for VS2017, VSCode, VS2019
            shortcuts.Add("https://docs.microsoft.com/en-us/visualstudio/liveshare/");
            //list of editor config files
            shortcuts.Add("https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-code-style-settings-reference?view=vs-2019");
            //TODO: run code cleanup, profile 2,that have added implicit/explicit type preferences
            //TODO: compile to see warning
            //see also editor.config
            foreach (string item in shortcuts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
