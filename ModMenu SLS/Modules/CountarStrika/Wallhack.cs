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
                var whinst = GameObject.FindObjectOfType<WallHack>();
                whinst.ctEnemy1.enabled = true;
                whinst.ctEnemy2.enabled = true;
                whinst.ctEnemy3.enabled = true;
                whinst.ctEnemy4.enabled = true;
                whinst.ctEnemy5.enabled = true;
                whinst.tEnemy1.enabled = true;
                whinst.tEnemy2.enabled = true;
                whinst.tEnemy3.enabled = true;
                whinst.tEnemy4.enabled = true;
                whinst.tEnemy5.enabled = true;
            }
        }
    }
}
 