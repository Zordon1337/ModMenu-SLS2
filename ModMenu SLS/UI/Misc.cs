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
                if (!System.IO.Directory.Exists("C:\\ModMenu_SLS"))
                {
                    System.IO.Directory.CreateDirectory("C:\\ModMenu_SLS");
                }
                System.IO.File.AppendAllText("C:\\ModMenu_SLS\\dump.txt", $"\n{SDK.posname} = {SDK.PlayerController.playerRay.transform.position.ToString()}");
            }
            GUILayout.Label("NoClip Speed");
            SDK.speed = GUILayout.HorizontalSlider(SDK.speed, 1f, 25f);
            if (GUILayout.Button($"NoClip: {SDK.bNoClip}"))
            {
                SDK.bNoClip = !SDK.bNoClip;
            }
            GUILayout.Label("CountarStrika Cheat");
            if (GUILayout.Button("Infinity Ammo", SDK.ButtonStyle))
            {
                SDK.InfAmmo = !SDK.InfAmmo;
            }
            if (GUILayout.Button("Infinity Damage", SDK.ButtonStyle))
            {
                SDK.InfDamage = !SDK.InfDamage;
            }
            if (GUILayout.Button("Infinity Health", SDK.ButtonStyle))
            {
                SDK.InfHealth = !SDK.InfHealth;
            }
            if (GUILayout.Button("NoSpread", SDK.ButtonStyle))
            {
                SDK.NoSpread = !SDK.NoSpread;
            }
            if (GUILayout.Button("RapidFire", SDK.ButtonStyle))
            {
                SDK.RapidFire = !SDK.RapidFire;
            }
            if (GUILayout.Button("Speedhack", SDK.ButtonStyle))
            {
                SDK.Speedhack = !SDK.Speedhack;
            }
        }
    }
}
