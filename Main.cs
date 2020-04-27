using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace Mount_and_harvest
{
    public class Main : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("test123", new TextObject("Click here", null), 9990, () => 
            {
                InformationManager.DisplayMessage(new InformationMessage("aaaaaaaaaa"));
            }, false));
        }

        // ----- 27/04/2020 -----

        // Been reading the docs, the source code, as well as finding limitations to what's possible.
        // Tomorrow I will continue from where I left, including trying out my own theories of how I can modify the things I want and add new content to the game
        // else, if things are taking too long, I'll work on something else, and have this going as a side-project.

    }
}
