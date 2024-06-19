using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules
{
    internal class RapidFire
    {
        public static void Run()
        {
            
            if(SDK.CountarStrika != null)
            {
                if (SDK.CountarStrika.csPlayer == null)
                    return;

                var CPlayer = SDK.CountarStrika.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                foreach (var wp in weapons)
                {
                    wp.fireRate = 0;
                }
            }
        }
    }
}
