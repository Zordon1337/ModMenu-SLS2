using UnityEngine;
using System.Collections;
using MelonLoader;
using System.Reflection.Emit;

namespace ModMenu_SLS
{
    class Shit:MelonMod
    {
        bool bNoNeeds = false;
        TimeManager Time;
        private GUISkin windowstyle;
        float wallettoadd = 0;
        float banktoadd = 0;
        float cardtoadd = 0;
        static int page = 0;
        public IEnumerator Optimization()
        {
            for (; ; )
            {
               
                yield return new WaitForSeconds(1f);
            }
        }
        void RenderUI(int id)
        {

            GUI.backgroundColor = Color.red;
            GUI.color = Color.green;
            
            // render navbar
            if (GUI.Button(new Rect(0, 15, 175, 50), "Teleporter"))
            {
                page = 0;
            }
            if (GUI.Button(new Rect(175, 15, 175, 50), "Player Stats"))
            {
                page = 1;
            }
            GUI.BeginGroup(new Rect(0, 50, 350, 400));
            if(page == 0)
            {
                GUILayout.Label("Not implemented yet");
            } else
            {
                if (GUILayout.Button("Disable Needs:" + bNoNeeds))
                {
                    bNoNeeds = !bNoNeeds;
                }

                GUILayout.Space(10f);

                GUILayout.Label("Money Amount to add to card");
                cardtoadd = float.Parse(GUILayout.TextField(cardtoadd.ToString()));
                if (GUILayout.Button("Add Money to Card"))
                {
                    PlayerPrefs.SetFloat("cardmoney", PlayerPrefs.GetFloat("cardmoney") + cardtoadd);
                }

                GUILayout.Space(10f);

                GUILayout.Label("Money Amount to add to wallet");
                wallettoadd = float.Parse(GUILayout.TextField(wallettoadd.ToString()));
                if (GUILayout.Button("Add Money to wallet"))
                {
                    PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + wallettoadd);
                }

                GUILayout.Space(10f);

                GUILayout.Label("Money Amount to add to bank");
                banktoadd = float.Parse(GUILayout.TextField(banktoadd.ToString()));
                if (GUILayout.Button("Add Money to bank"))
                {
                    PlayerPrefs.SetFloat("bankmoney", PlayerPrefs.GetFloat("bankmoney") + banktoadd);
                }
                if(GUILayout.Button("Set Night"))
                {
                    Time.time = 4f;
                }
                if (GUILayout.Button("Set Day"))
                {
                    Time.time = 12f;
                }
            }
            GUI.EndGroup();
        }
        public override void OnGUI()
        {
            
            
            var window = GUI.Window(0, new Rect(Screen.width / 2 - 175, Screen.height / 2 - 250, 350, 500),RenderUI,"SLS mod menu");
            
            /*GUI.backgroundColor = Color.white;
            GUI.contentColor = Color.red;
            if (GUILayout.Button("Disable Needs:" + bNoNeeds))
            {
                bNoNeeds = !bNoNeeds;
            }

            GUILayout.Space(10f);

            GUILayout.Label("Money Amount to add to card");
            cardtoadd = float.Parse(GUILayout.TextField(cardtoadd.ToString()));
            if (GUILayout.Button("Add Money to Card"))
            {
                PlayerPrefs.SetFloat("cardmoney", PlayerPrefs.GetFloat("cardmoney") + cardtoadd);
            }

            GUILayout.Space(10f);

            GUILayout.Label("Money Amount to add to wallet");
            wallettoadd = float.Parse(GUILayout.TextField(wallettoadd.ToString()));
            if (GUILayout.Button("Add Money to wallet"))
            {
                PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + wallettoadd);
            }

            GUILayout.Space(10f);

            GUILayout.Label("Money Amount to add to bank");
            banktoadd = float.Parse(GUILayout.TextField(banktoadd.ToString()));
            if (GUILayout.Button("Add Money to bank"))
            {
                PlayerPrefs.SetFloat("bankmoney", PlayerPrefs.GetFloat("bankmoney") + banktoadd);
            }
            /*if(GUILayout.Button("Set Night"))
            {
                Time.time = 4f;
            }
            if (GUILayout.Button("Set Day"))
            {
                Time.time = 12f;
            }*/

        }

        public override void OnApplicationStart()
        {
            //TipManager.Instance.ShowTip3("ModMenu SLS", "Mod Menu Injected succesfully\n Made by Zordon1337\nClick END to unhook");
            
        }
        int calls = 0;
        public override void OnUpdate()
        {
            
            calls++;
            if(calls > 125)
            {
                calls = 0;
                //AI = Object.FindObjectsOfType<AIContoller>();
                Time = Object.FindObjectOfType<TimeManager>();
                if (bNoNeeds)
                {
                    var stats = PlayerStats.Instance;
                    stats.health = 100;
                    stats.energy = 100;
                    stats.hunger = 100;
                    stats.hygiene = 100;
                    stats.toilet = 0;
                }
                /*if ((Time.time >= 16f && Time.time <= 0f) || (Time.time >= 0f && Time.time <= 6f))
                {
                    //it changes skybox to dark because its night
                    RenderSettings.skybox = null;
                    RenderSettings.skybox.color = Color.black;
                }
                else
                {
                    // it should be day
                    RenderSettings.skybox = null;
                    RenderSettings.skybox.color = Color.white;
                }*/

            }
            
        }
    }
}
