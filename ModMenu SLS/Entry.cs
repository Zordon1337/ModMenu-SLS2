using UnityEngine;
using System.Collections;
using MelonLoader;
using System.Reflection.Emit;
using System.Collections.Generic;
using ModMenu_SLS;
using ModMenu_SLS.UI;

using System;
using HarmonyLib;
namespace ModMenu_SLS
{
    class Entry:MelonMod
    {
        
        public static bool isMenuOpen = false;



        public override void OnGUI()
        {
            ThemeLoader.Load();
            Watermark.Render();
            GUI.DragWindow();
            Modules.CountarStrika.Wallhack.Run();
        }
        int calls = 0;
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                isMenuOpen = !isMenuOpen;
                if (isMenuOpen)
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                }
            }
            
            Modules.Noclip.Run();
            calls++;
            if(calls > 150)
            {
                calls = 0;
                if (SDK.bNoNeeds)
                {
                    GameManager.Instance.playerMotor.energy = 100;
                    GameManager.Instance.hungerTime = 0;
                    GameManager.Instance.notShowerTime = 0;
                    GameManager.Instance.toiletTime = 0;
                }

                SDK.ai = GameObject.FindObjectsOfType<CamperAI>();
                SDK.ai_dm = GameObject.FindObjectsOfType<CamperAI_DeathMatch>();
                SDK.csm = GameObject.FindObjectOfType<CamperStrikeManager>();

                if (SDK.csm != null)
                {
                    if (SDK.csm.csPlayer != null && SDK.csm.csPlayer.kalash != null)
                    {
                        SDK.weapons[0] = SDK.csm.csPlayer.kalash;
                        SDK.weapons[1] = SDK.csm.csPlayer.shotgun;
                        SDK.weapons[2] = SDK.csm.csPlayer.smg;
                        SDK.weapons[3] = SDK.csm.csPlayer.m16;
                        SDK.weapons[4] = SDK.csm.csPlayer.pistol;
                        SDK.weapons[5] = SDK.csm.csPlayer.deagle;
                    }

                }
            }
            Modules.RapidFire.Run();
            Modules.CountarStrika.InfAmmo.Run();
            Modules.CountarStrika.InfDamage.Run();
            Modules.CountarStrika.NoSpread.Run();
            Modules.CountarStrika.InfHealth.Run();
            Modules.CountarStrika.Speedhack.Run();
            Modules.CountarStrika.InfinityJump.Run();
            Modules.CountarStrika.InstantMatchmaking.Run();

        }
    }
}
