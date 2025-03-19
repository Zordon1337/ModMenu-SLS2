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
                    System.IO.File.AppendAllText("C:\\ModMenu_SLS\\dump.txt", $"\n{SDK.posname} = {GameManager.Instance.playerMotor.transform.position.ToString()}");
                }
                GUILayout.Label("NoClip Speed",SDK.TextStyle);
                SDK.speed = GUILayout.HorizontalSlider(SDK.speed, 1f, 25f);
                SDK.bNoClip = GUILayout.Toggle(SDK.bNoClip, $"NoClip: {SDK.bNoClip}", SDK.CheckboxStyle);
                GUILayout.Label("CamperStrike Cheat", SDK.TextStyle);
                SDK.InfAmmo = GUILayout.Toggle(SDK.InfAmmo, $"Infinity Ammo: {SDK.InfAmmo}", SDK.CheckboxStyle);
                SDK.InfDamage = GUILayout.Toggle(SDK.InfDamage, $"Infinity Damage: {SDK.InfDamage}", SDK.CheckboxStyle);
                SDK.InfHealth = GUILayout.Toggle(SDK.InfHealth, $"Infinity Health: {SDK.InfHealth}", SDK.CheckboxStyle);
                SDK.NoSpread = GUILayout.Toggle(SDK.NoSpread, $"NoSpread: {SDK.NoSpread}", SDK.CheckboxStyle);
                SDK.RapidFire = GUILayout.Toggle(SDK.RapidFire, $"RapidFire: {SDK.RapidFire}", SDK.CheckboxStyle);
                SDK.Speedhack = GUILayout.Toggle(SDK.Speedhack, $"Speedhack: {SDK.Speedhack}", SDK.CheckboxStyle);
                SDK.Wallhack = GUILayout.Toggle(SDK.Wallhack, $"Wallhack: {SDK.Wallhack}", SDK.CheckboxStyle);
                SDK.InfinityJump = GUILayout.Toggle(SDK.InfinityJump, $"Infinity Jump: {SDK.InfinityJump}", SDK.CheckboxStyle);
                SDK.CounterHouse = GUILayout.Toggle(SDK.CounterHouse, $"Spawn on normal map: {SDK.CounterHouse}",SDK.CheckboxStyle);

            }
        }
    }
