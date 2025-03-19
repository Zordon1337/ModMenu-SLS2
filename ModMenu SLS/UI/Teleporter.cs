using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Teleporter
    {
        public static void Render()
        {
            /*Dictionary<string, Vector3> PlayerToteleportDestinations = new Dictionary<string, Vector3>
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
                        {"Dady Car(this is how dev called it)(starter car)", SDK.CM.dadyCar.transform.position },
                        {"Japanese Car", SDK.CM.japaneseCar.transform.position },
                        { "Van", SDK.CM.vanCar.transform.position},
                        { "Suv", SDK.CM.suvCar.transform.position},
                        {" Porsche", SDK.CM.porscheCar.transform.position },
                        { "Gas Station 1", new Vector3(722.7f, 22.2f, 522.7f) },
                        { "Gas Station 2", new Vector3(434.8f, 19.0f, 1158.9f)},
                        {"Zamazor1", new Vector3(1288.0f, 28.6f, 1891.8f) }
                };

            foreach (var Plrdestination in PlayerToteleportDestinations)
            {
                if (GUILayout.Button($"Teleport to {Plrdestination.Key}", SDK.ButtonStyle))
                {
                    SDK.TeleportPlayer(SDK.PlayerController, Plrdestination.Value);
                }
            }
            Dictionary<string, Transform> ItemToteleportDestinations = new Dictionary<string, Transform>
                {
                        {"Dady Car", SDK.CM.dadyCar.transform},
                        {"Japanese Car", SDK.CM.japaneseCar.transform },
                        { "Van", SDK.CM.vanCar.transform},
                        { "Suv", SDK.CM.suvCar.transform},
                        {" Porsche", SDK.CM.porscheCar.transform }
                };

            foreach (var Plrdestination in ItemToteleportDestinations)
            {
                if (GUILayout.Button($"Teleport {Plrdestination.Key} to player", SDK.ButtonStyle))
                {
                    SDK.TeleportItem(Plrdestination.Value, SDK.PlayerController.playerRay.transform.position);
                }
            }*/
        }
    }
}
