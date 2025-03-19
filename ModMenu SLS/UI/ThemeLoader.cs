﻿using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class ThemeLoader
    {
        public static void Load()
        {
            

            if (!ModMenu_SLS.Entry.isMenuOpen || !SDK.IsInGame)
                return;

            Color textboxColor = new Color(0.98f, 0.94f, 0.90f);
            Color buttonBackgroundColor = new Color(0.75f, 0.75f, 0.75f);
            Color buttonTextColor = Color.black;
            Color hoverButtonBackgroundColor = new Color(0.85f, 0.85f, 0.85f);
            Color windowBackgroundColor = new Color(0.9f, 0.9f, 0.9f);

            SDK.ButtonStyle.normal.background = SDK.MakeTexture(2, 2, buttonBackgroundColor);
            SDK.ButtonStyle.normal.textColor = buttonTextColor;
            SDK.ButtonStyle.active.background = SDK.MakeTexture(2, 2, buttonBackgroundColor);
            SDK.ButtonStyle.active.textColor = buttonTextColor;
            SDK.ButtonStyle.hover.background = SDK.MakeTexture(2, 2, hoverButtonBackgroundColor);
            SDK.ButtonStyle.hover.textColor = buttonTextColor;
            SDK.ButtonStyle.alignment = TextAnchor.MiddleCenter;
            SDK.ButtonStyle.border = new RectOffset(10, 10, 10, 10);
            SDK.WindowStyle.normal.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
            SDK.WindowStyle.normal.textColor = Color.black;
            SDK.WindowStyle.active.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
            SDK.WindowStyle.active.textColor = Color.black;
            SDK.WindowStyle.hover.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
            SDK.WindowStyle.hover.textColor = Color.black;
            SDK.WindowStyle.alignment = TextAnchor.UpperCenter;
            SDK.TextBoxStyle.normal.textColor = Color.black;
            SDK.TextBoxStyle.active.textColor = Color.black;
            SDK.TextBoxStyle.hover.textColor = Color.black;

            SDK.CheckboxStyle = new GUIStyle(SDK.ButtonStyle);
            SDK.CheckboxStyle.alignment = TextAnchor.MiddleLeft;
            SDK.ButtonStyleNavBar = new GUIStyle(SDK.ButtonStyle);
            SDK.ButtonStyleNavBar.fixedHeight = 35;
            SDK.TextStyle.normal.textColor = Color.black;
            SDK.TextStyle.alignment = TextAnchor.MiddleCenter;
            GUI.Window(0, new Rect(Screen.width / 2 - 262, Screen.height / 2 - 300, 525, 600), Window.Render, "SLS2 mod menu", SDK.WindowStyle);
        }
    }
}
