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
            Dictionary<string, Vector3> PlayerToteleportDestinations = new Dictionary<string, Vector3>
            {
                { "House 1", new Vector3(175.74f, 1.16f, 170.36f) },
                { "Crypto Miner", new Vector3(327.66f, 10.10f, -122.20f) },
                { "Villa House", new Vector3(37.73f, -0.21f, -227.76f) },
                { "Pawn Shop", new Vector3(33.14f, 1.16f, 95.63f) },
                { "Cozy House", new Vector3(63.82f, 1.37f, 220.92f) },
                { "Barber", new Vector3(109.47f, 1.25f, 232.60f) },
                { "Auto Gallery", new Vector3(316.98f, 5.50f, 173.64f) },
                { "Farm House", new Vector3(474.96f, 2.87f, -80.47f) },
                { "Club", new Vector3(387.73f, 2.18f, -228.22f) },
                { "Clinic", new Vector3(74.85f, 1.32f, 151.47f) },
                { "Clothes Shop", new Vector3(43.73f, 1.21f, 167.15f) }
            };


            foreach (var Plrdestination in PlayerToteleportDestinations)
            {
                if (GUILayout.Button($"Teleport to {Plrdestination.Key}", SDK.ButtonStyle))
                {
                    SDK.TeleportPlayer(GameManager.Instance.playerMotor, Plrdestination.Value);
                }
            }
            /*Dictionary<string, Transform> ItemToteleportDestinations = new Dictionary<string, Transform>
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
