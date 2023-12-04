using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Michsky.UI.ModernUIPack.UIManagerButton;

namespace ModMenu_SLS
{
    public static class SDK
    {
        public static Texture2D MakeTexture(int width, int height, Color col)
        {
            Color[] pix = new Color[width * height];
            for (int i = 0; i < pix.Length; ++i)
            {
                pix[i] = col;
            }

            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }
        public static void TeleportPlayer(PlayerController pc, Vector3 pos)
        {
            /*creating dummy transform because we can't directly provide Vector3 in the teleport function
            Transform dummy;
            dummy = new GameObject().transform;
            dummy.position = pos;
            nvrmind we can provide vector3*/
            pc.SetNewPositionAndRotation(pos);
        }
        public static void TeleportItem(Transform TP, Vector3 Where)
        {
            TP.position = Where;
        }
        public static bool IsInGame => CarManager.Instance != null;
        
    }
}
