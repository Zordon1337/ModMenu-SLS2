using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static DG.Tweening.DOTweenModuleUtils;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class InfinityJump
    {
        public static void Run()
        {

            var csm = GameObject.FindObjectOfType<CamperStrikeManager>();
            if (csm != null && SDK.InfinityJump)
            {
                if (csm.csPlayer == null)
                    return;

                var CPlayer = csm.csPlayer;
                CPlayer.groundDistance = 999999f;
                
            }
        }
    }
}
