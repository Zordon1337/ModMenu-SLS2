using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class Wallhack
    {
        public static void Run()
        {

            if(SDK.Wallhack)
            {
                var test = GameObject.FindObjectsOfType<CamperAI_DeathMatch>();
                foreach(var c in test)
                {
                    if(c.csPlayer != null && c.health > 0)
                    {
                        var w2s = Camera.main.WorldToScreenPoint(c.csPlayer.transform.position);

                        if (w2s != null)
                        {
                            GUI.Label(new Rect(w2s.x, Screen.height - w2s.y, 300, 300),"Player");
                        }
                    }
                }
                
            }
        }
    }
}
 