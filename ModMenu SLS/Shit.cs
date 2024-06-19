using UnityEngine;
using System.Collections;
using MelonLoader;
using System.Reflection.Emit;
using System.Collections.Generic;
using ModMenu_SLS;
using ModMenu_SLS.UI;
namespace ModMenu_SLS
{
    class Shit:MelonMod
    {
        
        public static bool isMenuOpen = false;
        

        
        public override void OnGUI()
        {
            ThemeLoader.Load();
            Watermark.Render();
        }
        int calls = 0;
        public override void OnUpdate()
        {
            // Check if the Insert key is pressed
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

            SDK.CountarStrika = GameObject.FindObjectOfType<CountarStrika>();
            if (SDK.CountarStrika != null)
            {
                if(SDK.CountarStrika.csPlayer != null && SDK.CountarStrika.csPlayer.kalash != null)
                {
                    SDK.weapons[0] = SDK.CountarStrika.csPlayer.kalash;
                    SDK.weapons[1] = SDK.CountarStrika.csPlayer.shotgun;
                    SDK.weapons[2] = SDK.CountarStrika.csPlayer.smg;
                    SDK.weapons[3] = SDK.CountarStrika.csPlayer.m16;
                    SDK.weapons[4] = SDK.CountarStrika.csPlayer.pistol;
                    SDK.weapons[5] = SDK.CountarStrika.csPlayer.deagle;
                    Modules.RapidFire.Run();
                    Modules.CountarStrika.InfAmmo.Run();
                    Modules.CountarStrika.InfDamage.Run();
                    Modules.CountarStrika.NoSpread.Run();
                    Modules.CountarStrika.InfHealth.Run(); 
                }
                
            }
            Modules.Noclip.Run();
            
            calls++;
            if(calls > 150)
            {
                calls = 0;
                SDK.Time = Object.FindObjectOfType<TimeManager>();
                SDK.PlayerController = Object.FindObjectOfType<PlayerController>();
                SDK.CM = Object.FindObjectOfType<CarManager>();
                if (SDK.bNoNeeds)
                {
                    var stats = PlayerStats.Instance;
                    stats.health = 100;
                    stats.energy = 100;
                    stats.hunger = 100;
                    stats.hygiene = 100;
                    stats.toilet = 0;
                }


            }
            
        }
    }
}
