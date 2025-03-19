using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class NoSpread
    {
        public static void Run()
        {

            var csm = GameObject.FindObjectOfType<CamperStrikeManager>();
            if (csm != null && SDK.NoSpread)
            {
                if (csm.csPlayer == null)
                    return;

                var CPlayer = csm.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                foreach (var wp in weapons)
                {
                    wp.recoilForge = 0;

                }
            }
        }
    }
}
