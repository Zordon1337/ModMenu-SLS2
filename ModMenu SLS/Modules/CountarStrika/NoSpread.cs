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

            if (SDK.csm != null && SDK.NoSpread)
            {
                if (SDK.csm.csPlayer == null)
                    return;

                var CPlayer = SDK.csm.csPlayer;
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
