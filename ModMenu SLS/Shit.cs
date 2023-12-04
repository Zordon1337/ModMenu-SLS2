using UnityEngine;
using System.Collections;
using MelonLoader;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace ModMenu_SLS
{
    class Shit:MelonMod
    {
        bool bNoNeeds = false;
        bool bNoClip = false;
        
        float wallettoadd = 0;
        float banktoadd = 0;
        float cardtoadd = 0;
        static int page = 0;
        private bool isMenuOpen = false;
        public GUIStyle ButtonStyle = new GUIStyle();
        public GUIStyle ButtonStyleNavBar = new GUIStyle();
        public GUIStyle WindowStyle = new GUIStyle();
        public GUIStyle TextBoxStyle = new GUIStyle();
        string posname = "";
        public TimeManager Time;
        public PlayerController PlayerController;
        public CarManager CM;

        float PorscheFuel = 0;
        float dadyfuel = 0;
        float VanFuel = 0;
        float SuvFuel = 0;
        float JapaneseCarFuel = 0;
        float speed = 25f;

        void RenderUI(int id)
        {
            // render navbar
            if (GUI.Button(new Rect(0, 15, 175, 50), "Teleporter", ButtonStyle))
            {
                page = 0;
            }
            if (GUI.Button(new Rect(175, 15, 175, 50), "Player Stats", ButtonStyle))
            {
                page = 1;
            }
            if (GUI.Button(new Rect(350, 15, 175, 50), "Misc", ButtonStyle))
            {
                page = 2;
            }
            GUI.BeginGroup(new Rect(0, 65, 525, 500 - 65)); // yes i can't do math
            GUILayout.Space(10f);
            if (page == 0)
            {
                Dictionary<string, Vector3> PlayerToteleportDestinations = new Dictionary<string, Vector3>
                {
                        {"House 1", new Vector3(1304.0f, 29.4f, 1851.1f)},
                        {"House 2", new Vector3(961.4f, 20.9f, 955.2f)},
                        {"House 3", new Vector3(330.1f, 19.2f, 1270.8f)},
                        {"House 4", new Vector3(298.1f, 18.2f, 318.9f)},
                        {"House 5", new Vector3(305.7f, 20.8f, 262.6f)},
                        {"Car Dealership", new Vector3(330.4f, 19.7f, 1506.0f)},
                        {"ZUber Job", new Vector3(436.7f, 19.2f, 1218.1f)},
                        {"Delivery Job", new Vector3(323.5f, 19.2f, 1233.6f)},
                        {"Pet Shop(Dogs)", new Vector3(415.2f, 19.2f, 1198.1f)},
                        {"BTC Miner Shop", new Vector3(315.5f, 19.2f, 1347.6f)},
                        {"Pizza Job", new Vector3(322.5f, 19.2f, 1430.6f)},
                        {"Taxi Job", new Vector3(364.3f, 18.9f, 1469.4f)},
                        {"ATM1", new Vector3(375.0f, 19.2f, 1323.2f)},
                        {"Cashier Job", new Vector3(370.9f, 19.2f, 1319.1f)},
                        {"Ice Cream Guy", new Vector3(1311.9f, 28.3f, 1851.9f)},
                        {"Pet Shop (Cats)", new Vector3(1310.3f, 28.3f, 1811.9f)},
                        {"Dealer Guy", new Vector3(1346.5f, 28.5f, 1803.4f)},
                        {"Mosi House", new Vector3(1328.7f, 22.8f, 849.0f)},
                        {"Dady Car(this is how dev called it)(starter car)", CM.dadyCar.transform.position },
                        {"Japanese Car", CM.japaneseCar.transform.position },
                        { "Van", CM.vanCar.transform.position},
                        { "Suv", CM.suvCar.transform.position},
                        {" Porsche", CM.porscheCar.transform.position },
                        { "Gas Station 1", new Vector3(722.7f, 22.2f, 522.7f) },
                        { "Gas Station 2", new Vector3(434.8f, 19.0f, 1158.9f)}
                };

                foreach (var Plrdestination in PlayerToteleportDestinations)
                {
                    if (GUILayout.Button($"Teleport to {Plrdestination.Key}",ButtonStyle))
                    {
                        SDK.TeleportPlayer(PlayerController, Plrdestination.Value);
                    }
                }
                Dictionary<string, Transform> ItemToteleportDestinations = new Dictionary<string, Transform>
                {
                        {"Dady Car", CM.dadyCar.transform},
                        {"Japanese Car", CM.japaneseCar.transform },
                        { "Van", CM.vanCar.transform},
                        { "Suv", CM.suvCar.transform},
                        {" Porsche", CM.porscheCar.transform }
                };

                foreach (var Plrdestination in ItemToteleportDestinations)
                {
                    if (GUILayout.Button($"Teleport {Plrdestination.Key} to player", ButtonStyle))
                    {
                        SDK.TeleportItem(Plrdestination.Value, PlayerController.playerRay.transform.position);
                    }
                }


            } if(page == 1)
            {
                //cardtoadd = PlayerPrefs.GetFloat("cardmoney");
                //wallettoadd = PlayerPrefs.GetFloat("money");
                //banktoadd = PlayerPrefs.GetFloat("bankmoney");
                if (GUILayout.Button("Disable Needs:" + bNoNeeds, ButtonStyle))
                {
                    bNoNeeds = !bNoNeeds;
                }
                GUILayout.Space(10f);
                cardtoadd = float.Parse(GUILayout.TextField(cardtoadd.ToString(), TextBoxStyle));
                if (GUILayout.Button("Add Money to Card", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("cardmoney", PlayerPrefs.GetFloat("cardmoney") + cardtoadd);
                }
                GUILayout.Space(10f);
                wallettoadd = float.Parse(GUILayout.TextField(wallettoadd.ToString(), TextBoxStyle));
                if (GUILayout.Button("Add Money to wallet", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + wallettoadd);
                }
                GUILayout.Space(10f);
                banktoadd = float.Parse(GUILayout.TextField(banktoadd.ToString(), TextBoxStyle));
                if (GUILayout.Button("Add Money to bank", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("bankmoney", PlayerPrefs.GetFloat("bankmoney") + banktoadd);
                }
                /* todo
                dadyfuel = float.Parse(GUILayout.TextField(dadyfuel.ToString(), TextBoxStyle));
                if (GUILayout.Button("Change dadycar fuel", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("DadyCarcarfuel", dadyfuel);
                }
                JapaneseCarFuel = float.Parse(GUILayout.TextField(JapaneseCarFuel.ToString(), TextBoxStyle));
                if (GUILayout.Button("Change JapaneseCar fuel (might not work)", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("RMCarcarfuel", JapaneseCarFuel);
                }
                PorscheFuel = float.Parse(GUILayout.TextField(PorscheFuel.ToString(), TextBoxStyle));
                if (GUILayout.Button("Change Porsche fuel", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("PorscheTurbocarfuel", PorscheFuel);
                }
                SuvFuel = float.Parse(GUILayout.TextField(SuvFuel.ToString(), TextBoxStyle));
                if (GUILayout.Button("Change Suv fuel", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("Suvcarfuel", SuvFuel);
                }
                VanFuel = float.Parse(GUILayout.TextField(VanFuel.ToString(), TextBoxStyle));
                if (GUILayout.Button("Change Van fuel", ButtonStyle))
                {
                    PlayerPrefs.SetFloat("Vancarfuel", VanFuel);
                }*/
                if (GUILayout.Button("Set Night", ButtonStyle))
                {
                    Time.time = 4f;
                }
                if (GUILayout.Button("Set Day", ButtonStyle))
                {
                    Time.time = 12f;
                }
            }
            if (page == 2)
            {
                
                posname = GUILayout.TextField(posname, TextBoxStyle);
                if (GUILayout.Button("Dump your current location",ButtonStyle))
                {
                    if(!System.IO.Directory.Exists("D:\\ModMenu_SLS"))
                    {
                        System.IO.Directory.CreateDirectory("D:\\ModMenu_SLS");
                    }
                    System.IO.File.AppendAllText("D:\\ModMenu_SLS\\dump.txt", $"\n{posname} = {PlayerController.playerRay.transform.position.ToString()}");
                }
                GUILayout.Label("NoClip Speed");
                speed = GUILayout.HorizontalSlider(speed, 1f, 25f);
                if(GUILayout.Button($"NoClip: {bNoClip}"))
                {
                    bNoClip = !bNoClip;
                }
            }
            GUI.EndGroup();
        }
        public override void OnGUI()
        {
            // it won't crash lol
            if(PlayerController != null)
            {
                /*GUILayout.Label(PlayerController.playerRay.transform.position.ToString());
                GUILayout.Label(CM.dadyCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.japaneseCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.porscheCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.suvCarRear.transform.name + "carfuel");
                GUILayout.Label(CM.vanCar.transform.name + "carfuel");*/
            }
            if (isMenuOpen && SDK.IsInGame)
            {
                // Color Palette
                Color textboxColor = new Color(System.Convert.ToInt32("FA", 16) / 255f, System.Convert.ToInt32("F0", 16) / 255f, System.Convert.ToInt32("E6", 16) / 255f); // #FAF0E6
                Color ButtonColor = new Color(System.Convert.ToInt32("5C", 16) / 255f, System.Convert.ToInt32("54", 16) / 255f, System.Convert.ToInt32("70", 16) / 255f); //  #5C5470
                Color HoverButtonColor = new Color(System.Convert.ToInt32("B9", 16) / 255f, System.Convert.ToInt32("B4", 16) / 255f, System.Convert.ToInt32("C7", 16) / 255f); //  #B9B4C7
                Color windowBackgroundColor = new Color(System.Convert.ToInt32("35", 16) / 255f, System.Convert.ToInt32("2F", 16) / 255f, System.Convert.ToInt32("44", 16) / 255f); // #352F44

                // Button Style
                ButtonStyle.normal.background = SDK.MakeTexture(2, 2, ButtonColor);
                ButtonStyle.normal.textColor = Color.white;
                ButtonStyle.active.background = SDK.MakeTexture(2, 2, ButtonColor);
                ButtonStyle.active.textColor = Color.white;
                ButtonStyle.hover.background = SDK.MakeTexture(2, 2, HoverButtonColor); 
                ButtonStyle.hover.textColor = Color.black;
                ButtonStyle.alignment = TextAnchor.MiddleCenter;
                ButtonStyle.border = new RectOffset(10, 10, 10, 10); // Adjust the values to control corner rounding

                // Button Style for Navbar
                ButtonStyleNavBar = new GUIStyle(ButtonStyle); // Create a new GUIStyle and copy properties
                ButtonStyleNavBar.fixedHeight = 35;

                // Window Style
                WindowStyle.normal.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
                WindowStyle.normal.textColor = Color.white;
                WindowStyle.active.background = SDK.MakeTexture(2, 2, windowBackgroundColor);
                WindowStyle.active.textColor = Color.white;
                WindowStyle.hover.background = SDK.MakeTexture(2, 2, windowBackgroundColor); // Using the same color as normal for hover
                WindowStyle.hover.textColor = Color.white;
                WindowStyle.alignment = TextAnchor.UpperCenter;

                // TextBox Style
                TextBoxStyle.border = new RectOffset(10, 10, 10, 10);
                TextBoxStyle.normal.background = SDK.MakeTexture(2, 2, textboxColor);
                TextBoxStyle.active.background = SDK.MakeTexture(2, 2, textboxColor);
                TextBoxStyle.hover.background = SDK.MakeTexture(2, 2, textboxColor);
                TextBoxStyle.active.textColor = Color.black;
                TextBoxStyle.normal.textColor = Color.black;
                TextBoxStyle.hover.textColor = Color.black;
                
                // Draw the window if the menu is open
                var window = GUI.Window(0, new Rect(Screen.width / 2 - 262, Screen.height / 2 - 250, 525, 500), RenderUI, "SLS mod menu", WindowStyle);
            }
            

        }

        public override void OnApplicationStart()
        {

            
        }
        int calls = 0;
        public override void OnUpdate()
        {
            // Check if the Insert key is pressed
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                isMenuOpen = !isMenuOpen;
                if(isMenuOpen)
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                } else
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    
                }
            }
            
            if (PlayerController != null)
            {
                if(bNoClip)
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        SDK.TeleportPlayer(PlayerController, new Vector3(PlayerController.playerRay.transform.position.x, PlayerController.playerRay.transform.position.y + speed, PlayerController.playerRay.transform.position.z));
                    }

                    Vector3 playerTransformPosVec = PlayerController.playerRay.transform.position;
                    if (Input.GetKey(KeyCode.W))
                    {
                        SDK.TeleportPlayer(PlayerController, new Vector3(playerTransformPosVec.x + PlayerController.playerRay.playerMainCamera.transform.forward.x * PlayerController.playerRay.playerMainCamera.transform.up.y * speed, playerTransformPosVec.y + PlayerController.playerRay.playerMainCamera.transform.forward.y * speed, playerTransformPosVec.z + PlayerController.playerRay.playerMainCamera.transform.forward.z * PlayerController.playerRay.playerMainCamera.transform.up.y * speed));
                    }

                    if (Input.GetKey(KeyCode.S))
                    {
                        SDK.TeleportPlayer(PlayerController, new Vector3(playerTransformPosVec.x - PlayerController.playerRay.playerMainCamera.transform.forward.x * PlayerController.playerRay.playerMainCamera.transform.up.y * speed, playerTransformPosVec.y - PlayerController.playerRay.playerMainCamera.transform.forward.y * speed, playerTransformPosVec.z - PlayerController.playerRay.playerMainCamera.transform.forward.z * PlayerController.playerRay.playerMainCamera.transform.up.y * speed));
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        SDK.TeleportPlayer(PlayerController, new Vector3(playerTransformPosVec.x + PlayerController.playerRay.playerMainCamera.transform.right.x * speed, playerTransformPosVec.y, playerTransformPosVec.z + PlayerController.playerRay.playerMainCamera.transform.right.z * speed));
                    }

                    if (Input.GetKey(KeyCode.A))
                    {
                        SDK.TeleportPlayer(PlayerController, new Vector3(playerTransformPosVec.x - PlayerController.playerRay.playerMainCamera.transform.right.x * speed, playerTransformPosVec.y, playerTransformPosVec.z - PlayerController.playerRay.playerMainCamera.transform.right.z * speed));
                    }
                }
            }
            calls++;
            if(calls > 150)
            {
                calls = 0;
                //AI = Object.FindObjectsOfType<AIContoller>();
                Time = Object.FindObjectOfType<TimeManager>();
                PlayerController = Object.FindObjectOfType<PlayerController>();
                CM = Object.FindObjectOfType<CarManager>();
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
