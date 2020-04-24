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
    }
}
