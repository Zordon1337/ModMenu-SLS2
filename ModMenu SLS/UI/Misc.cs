using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Misc
    {
        public static void Render()
        {
            SDK.posname = GUILayout.TextField(SDK.posname, SDK.TextBoxStyle);
            if (GUILayout.Button("Dump your current location", SDK.ButtonStyle))
            {
                if (!System.IO.Directory.Exists("D:\\ModMenu_SLS"))
                {
                    System.IO.Directory.CreateDirectory("D:\\ModMenu_SLS");
                }
                System.IO.File.AppendAllText("D:\\ModMenu_SLS\\dump.txt", $"\n{SDK.posname} = {SDK.PlayerController.playerRay.transform.position.ToString()}");
            }
            GUILayout.Label("NoClip Speed");
            SDK.speed = GUILayout.HorizontalSlider(SDK.speed, 1f, 25f);
            if (GUILayout.Button($"NoClip: {SDK.bNoClip}"))
            {
                SDK.bNoClip = !SDK.bNoClip;
            }
        }
    }
}
