using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class ThemeLoader
    {
        public static void Load()
        {
            // it won't crash lol
            if (SDK.PlayerController != null)
            {
                /*GUILayout.Label(SDK.PlayerController.playerRay.transform.position.ToString());
                GUILayout.Label(CM.dadyCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.japaneseCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.porscheCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.suvCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.vanCar.transform.name + "carfuel");*/
            }
            if (ModMenu_SLS.Shit.isMenuOpen && SDK.IsInGame)
            {
                // Color Palette
                Color textboxColor = new Color(System.Convert.ToInt32("FA", 16) / 255f, System.Convert.ToInt32("F0", 16) / 255f, System.Convert.ToInt32("E6", 16) / 255f); // #FAF0E6
                Color ButtonColor = new Color(System.Convert.ToInt32("5C", 16) / 255f, System.Convert.ToInt32("54", 16) / 255f, System.Convert.ToInt32("70", 16) / 255f); //  #5C5470
                Color HoverButtonColor = new Color(System.Convert.ToInt32("B9", 16) / 255f, System.Convert.ToInt32("B4", 16) / 255f, System.Convert.ToInt32("C7", 16) / 255f); //  #B9B4C7
                Color windowBackgroundColor = new Color(System.Convert.ToInt32("35", 16) / 255f, System.Convert.ToInt32("2F", 16) / 255f, System.Convert.ToInt32("44", 16) / 255f); // #352F44

                // Button Style
                SDK.ButtonStyle.normal.background = SDK.MakeTexture(2, 2, ButtonColor);
                SDK.ButtonStyle.normal.textColor = Color.white;
                SDK.ButtonStyle.active.background = SDK.MakeTexture(2, 2, ButtonColor);
                SDK.ButtonStyle.active.textColor = Color.white;
                SDK.ButtonStyle.hover.background = SDK.MakeTexture(2, 2, HoverButtonColor);
                SDK.ButtonStyle.hover.textColor = Color.black;
                SDK.ButtonStyle.alignment = TextAnchor.MiddleCenter;
                SDK.ButtonStyle.border = new RectOffset(10, 10, 10, 10); // Adjust the values to control corner rounding

                // Button Style for Navbar
                SDK.ButtonStyleNavBar = new GUIStyle(SDK.ButtonStyle); // Create a new GUIStyle and copy properties
                SDK.ButtonStyleNavBar.fixedHeight = 35;

                // Window Style
                SDK.WindowStyle.normal.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
                SDK.WindowStyle.normal.textColor = Color.white;
                SDK.WindowStyle.active.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
                SDK.WindowStyle.active.textColor = Color.white;
                SDK.WindowStyle.hover.background = SDK.MakeTexture(2, 2, windowBackgroundColor); // Using the same color as normal for hover
                SDK.WindowStyle.hover.textColor = Color.white;
                SDK.WindowStyle.alignment = TextAnchor.UpperCenter;

                // TextBox Style
                SDK.TextBoxStyle.border = new RectOffset(10, 10, 10, 10);
                SDK.TextBoxStyle.normal.background = SDK.MakeTexture(2, 2, textboxColor);
                SDK.TextBoxStyle.active.background = SDK.MakeTexture(2, 2, textboxColor);
                SDK.TextBoxStyle.hover.background = SDK.MakeTexture(2, 2, textboxColor);
                SDK.TextBoxStyle.active.textColor = Color.black;
                SDK.TextBoxStyle.normal.textColor = Color.black;
                SDK.TextBoxStyle.hover.textColor = Color.black;

                // Draw the window if the menu is open
                var window = GUI.Window(0, new Rect(Screen.width / 2 - 262, Screen.height / 2 - 250, 525, 500), Window.Render, "SLS mod menu", SDK.WindowStyle);
            }
        }
    }
}
