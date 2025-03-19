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
            if (GameManager.Instance != null)
            {
                if (SDK.bNoClip)
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        SDK.TeleportPlayer(GameManager.Instance.playerMotor, new Vector3(GameManager.Instance.playerMotor.transform.position.x, GameManager.Instance.playerMotor.transform.position.y + SDK.speed, GameManager.Instance.playerMotor.transform.position.z));
                    }

                    Vector3 playerTransformPosVec = GameManager.Instance.playerMotor.transform.position;
                    if (Input.GetKey(KeyCode.W))
                    {
                        SDK.TeleportPlayer(GameManager.Instance.playerMotor, new Vector3(playerTransformPosVec.x + GameManager.Instance.playerMotor.transform.forward.x * GameManager.Instance.playerMotor.transform.transform.up.y * SDK.speed, playerTransformPosVec.y + GameManager.Instance.playerMotor.transform.transform.forward.y * SDK.speed, playerTransformPosVec.z + GameManager.Instance.playerMotor.transform.transform.forward.z * GameManager.Instance.playerMotor.transform.transform.up.y * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.S))
                    {
                        SDK.TeleportPlayer(GameManager.Instance.playerMotor, new Vector3(playerTransformPosVec.x - GameManager.Instance.playerMotor.transform.forward.x * GameManager.Instance.playerMotor.transform.up.y * SDK.speed, playerTransformPosVec.y - GameManager.Instance.playerMotor.transform.transform.forward.y * SDK.speed, playerTransformPosVec.z - GameManager.Instance.playerMotor.transform.transform.forward.z * GameManager.Instance.playerMotor.transform.transform.up.y * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        SDK.TeleportPlayer(GameManager.Instance.playerMotor, new Vector3(playerTransformPosVec.x + GameManager.Instance.playerMotor.transform.transform.right.x * SDK.speed, playerTransformPosVec.y, playerTransformPosVec.z + GameManager.Instance.playerMotor.transform.transform.right.z * SDK.speed));
                    }

                    if (Input.GetKey(KeyCode.A))
                    {
                        SDK.TeleportPlayer(GameManager.Instance.playerMotor, new Vector3(playerTransformPosVec.x - GameManager.Instance.playerMotor.transform.transform.right.x * SDK.speed, playerTransformPosVec.y, playerTransformPosVec.z - GameManager.Instance.playerMotor.transform.transform.right.z * SDK.speed));
                    }
                }
            }
        }
    }
}
