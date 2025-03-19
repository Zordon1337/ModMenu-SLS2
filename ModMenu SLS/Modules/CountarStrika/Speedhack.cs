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
                if (SDK.csm.csPlayer == null)
                    return;

                var CPlayer = SDK.csm.csPlayer;

                CPlayer.speed = 30;
            }
        }
    }
} 