using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules
{
    internal class Noclip
    {
        public static void Run()
        {
            if (SDK.PlayerController != null)
            {
                if (SDK.bNoClip)
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        SDK.TeleportPlayer(SDK.PlayerController, new Vector3(SDK.PlayerController.playerRay.transform.position.x, SDK.PlayerController.playerRay.transform.position.y + SDK.speed, SDK.PlayerController.playerRay.transform.position.z));
                    }

                    Vector3 playerTransformPosVec = SDK.PlayerController.playerRay.transform.position;
                    if (Input.GetKey(KeyCode.W))
                    {
                        SDK.TeleportPlayer(SDK.PlayerController, new Vector3(playerTransformPosVec.x + SDK.PlayerController.playerRay.playerMainCamera.transform.forward.x * SDK.PlayerController.playerRay.playerMainCamera.transform.up.y * SDK.speed, playerTransformPosVec.y + SDK.PlayerController.playerRay.playerMainCamera.transform.forward.y * SDK.speed, playerTransformPosVec.z + SDK.PlayerController.playerRay.playerMainCamera.transform.forward.z * SDK.PlayerController.playerRay.playerMainCamera.transform.up.y * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.S))
                    {
                        SDK.TeleportPlayer(SDK.PlayerController, new Vector3(playerTransformPosVec.x - SDK.PlayerController.playerRay.playerMainCamera.transform.forward.x * SDK.PlayerController.playerRay.playerMainCamera.transform.up.y * SDK.speed, playerTransformPosVec.y - SDK.PlayerController.playerRay.playerMainCamera.transform.forward.y * SDK.speed, playerTransformPosVec.z - SDK.PlayerController.playerRay.playerMainCamera.transform.forward.z * SDK.PlayerController.playerRay.playerMainCamera.transform.up.y * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        SDK.TeleportPlayer(SDK.PlayerController, new Vector3(playerTransformPosVec.x + SDK.PlayerController.playerRay.playerMainCamera.transform.right.x * SDK.speed, playerTransformPosVec.y, playerTransformPosVec.z + SDK.PlayerController.playerRay.playerMainCamera.transform.right.z * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.A))
                    {
                        SDK.TeleportPlayer(SDK.PlayerController, new Vector3(playerTransformPosVec.x - SDK.PlayerController.playerRay.playerMainCamera.transform.right.x * SDK.speed, playerTransformPosVec.y, playerTransformPosVec.z - SDK.PlayerController.playerRay.playerMainCamera.transform.right.z * SDK.speed));
                    }
                }
            }
        }
    }
}
