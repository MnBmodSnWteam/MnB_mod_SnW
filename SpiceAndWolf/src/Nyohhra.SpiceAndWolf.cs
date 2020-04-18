using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace Nyohhra.SpiceAndWolf
{
    public class SpiceAndWolf : MBSubModuleBase // 本 mod 本体类
    {
        protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Gallery", new TextObject("Gallery", null), 9990, () =>
            {
                InformationManager.DisplayMessage(new InformationMessage("No CG yet"));
            }, false));
        }
    }
}