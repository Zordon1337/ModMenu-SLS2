using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class InfHealth
    {
        public static void Run()
        {

            if (SDK.csm != null && SDK.InfHealth)
            {
                if (SDK.csm.csPlayer == null)
                    return;

                var CPlayer = SDK.csm.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                
                CPlayer.health = 420;
                /*foreach(var bot in GameObject.FindObjectsOfType<CounterAi>())
                {
                    if(bot.health == 420)
                    {
                        bot.health = 0;
                    }
                }*/
            }
        }
    }
}
