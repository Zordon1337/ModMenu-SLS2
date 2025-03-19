using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    class Fakegram
    {
        public static void Render()
        {
            SDK.sSetFollowers = GUILayout.TextField(SDK.sSetFollowers, SDK.WindowStyle);
            if (GUILayout.Button("Set Followers"))
            {
                if (GameManager.Instance != null)
                {
                    GameManager.Instance.fakegram.totalFakegramFollower = int.Parse(SDK.sSetFollowers);
                }
            }
        }
    }
}
