using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Window
    {
        public static void Render(int wid)
        {

            
            Color navbarBackgroundColor = new Color(0.7f, 0.7f, 0.7f, 0.5f); // Light gray with 50% opacity
            Color contentBackgroundColor = new Color(0.9f, 0.9f, 0.9f); // Light gray
            GUILayout.BeginArea(new Rect(0, 0, 175, 600));
            GUI.DrawTexture(new Rect(0, 0, 175, 600), SDK.MakeTexture(2, 2, navbarBackgroundColor), ScaleMode.StretchToFill);
            GUILayout.Label("MODMENU SLS - zrd.ovh", SDK.TextStyle);
            if (GUILayout.Button("Teleporter", SDK.ButtonStyleNavBar, GUILayout.ExpandWidth(true)))
            {
                SDK.page = 0;
            }
            if (GUILayout.Button("Player Stats", SDK.ButtonStyleNavBar, GUILayout.ExpandWidth(true)))
            {
                SDK.page = 1;
            }
            if (GUILayout.Button("Misc", SDK.ButtonStyleNavBar, GUILayout.ExpandWidth(true)))
            {
                SDK.page = 2;
            }
            GUILayout.EndArea();
            GUILayout.BeginArea(new Rect(175, 0, 525 - 175, 600));
            GUI.DrawTexture(new Rect(0, 0, 525 - 175, 600), SDK.MakeTexture(2, 2, contentBackgroundColor), ScaleMode.StretchToFill);

            GUILayout.Space(20f);

            if (SDK.page == 0)
            {
                UI.Teleporter.Render();
            }
            else if (SDK.page == 1)
            {
                UI.PlayerStats.Render();
            }
            else if (SDK.page == 2)
            {
                UI.Misc.Render();
            }

            GUILayout.EndArea();
        }
    }
}
