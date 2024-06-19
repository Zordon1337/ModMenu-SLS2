using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Window
    {
        public static void Render(int wid)
        {
            // render navbar
            if (GUI.Button(new Rect(0, 15, 175, 50), "Teleporter", SDK.ButtonStyle))
            {
                SDK.page = 0;
            }
            if (GUI.Button(new Rect(175, 15, 175, 50), "Player Stats", SDK.ButtonStyle))
            {
                SDK.page = 1;
            }
            if (GUI.Button(new Rect(350, 15, 175, 50), "Misc", SDK.ButtonStyle))
            {
                SDK.page = 2;
            }
            GUI.BeginGroup(new Rect(0, 65, 525, 600 - 65)); // yes i can't do math
            GUILayout.Space(10f);
            if (SDK.page == 0)
            {
                UI.Teleporter.Render();


            }
            if (SDK.page == 1)
            {
                UI.PlayerStats.Render();
            }
            if (SDK.page == 2)
            {

                UI.Misc.Render();
            }
            GUI.EndGroup();
        }
    }
}
