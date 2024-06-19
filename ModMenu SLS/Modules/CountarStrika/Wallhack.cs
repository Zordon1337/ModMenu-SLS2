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
                whinst.ctEnemy1.OutlineWidth = 2f;
                whinst.ctEnemy2.OutlineWidth = 2f;
                whinst.ctEnemy3.OutlineWidth = 2f;
                whinst.ctEnemy4.OutlineWidth = 2f;
                whinst.ctEnemy5.OutlineWidth = 2f;
                whinst.tEnemy1.OutlineWidth = 2f;
                whinst.tEnemy2.OutlineWidth = 2f;
                whinst.tEnemy3.OutlineWidth = 2f;
                whinst.tEnemy4.OutlineWidth = 2f;
                whinst.tEnemy5.OutlineWidth = 2f;
            }
        }
    }
}
