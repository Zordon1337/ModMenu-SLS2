using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class Speedhack
    {
        public static void Run()
        {

            if (SDK.Speedhack)
            {
                var csm = GameObject.FindObjectOfType<CamperStrikeManager>();
                if (csm.csPlayer == null)
                    return;

                var CPlayer = csm.csPlayer;

                CPlayer.speed = 30;
            }
        }
    }
} 