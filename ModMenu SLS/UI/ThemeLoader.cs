using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class ThemeLoader
    {
        public static void Load()
        {
            

            if (!ModMenu_SLS.Shit.isMenuOpen || !SDK.IsInGame)
                return;

            // Color Palette for Light Theme
            Color textboxColor = new Color(0.98f, 0.94f, 0.90f);    // Light beige
            Color buttonBackgroundColor = new Color(0.75f, 0.75f, 0.75f);     // Light gray for button background
            Color buttonTextColor = Color.black;     // Black text for button
            Color hoverButtonBackgroundColor = new Color(0.85f, 0.85f, 0.85f); // Lighter gray for hovered button background
            Color windowBackgroundColor = new Color(0.9f, 0.9f, 0.9f); // Light gray for window background

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
            SDK.TextBoxStyle.normal.background = SDK.MakeTexture(2, 2, textboxColor);
            SDK.TextBoxStyle.active.background = SDK.MakeTexture(2, 2, textboxColor);
            SDK.TextBoxStyle.hover.background = SDK.MakeTexture(2, 2, textboxColor);
            SDK.TextBoxStyle.normal.textColor = Color.black;
            SDK.TextBoxStyle.active.textColor = Color.black;
            SDK.TextBoxStyle.hover.textColor = Color.black;
            SDK.CheckboxStyle = new GUIStyle(SDK.ButtonStyle);
            SDK.CheckboxStyle.alignment = TextAnchor.MiddleLeft;
            SDK.ButtonStyleNavBar = new GUIStyle(SDK.ButtonStyle);
            SDK.ButtonStyleNavBar.fixedHeight = 35;
            SDK.TextStyle.normal.textColor = Color.black;
            SDK.TextStyle.alignment = TextAnchor.MiddleCenter;
            GUI.Window(0, new Rect(Screen.width / 2 - 262, Screen.height / 2 - 300, 525, 600), Window.Render, "SLS mod menu", SDK.WindowStyle);
        }
    }
}
