using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class PlayerStats
    {
        public static void Render()
        {
            //cardtoadd = PlayerPrefs.GetFloat("cardmoney");
            //wallettoadd = PlayerPrefs.GetFloat("money");
            //banktoadd = PlayerPrefs.GetFloat("bankmoney");
            if (GUILayout.Button("Disable Needs:" + SDK.bNoNeeds, SDK.ButtonStyle))
            {
                SDK.bNoNeeds = !SDK.bNoNeeds;
            }
            GUILayout.Space(10f);
            SDK.cardtoadd = float.Parse(GUILayout.TextField(SDK.cardtoadd.ToString(), SDK.TextBoxStyle));
            if (GUILayout.Button("Add Money to Card", SDK.ButtonStyle))
            {
                PlayerPrefs.SetFloat("cardmoney", PlayerPrefs.GetFloat("cardmoney") + SDK.cardtoadd);
            }
            GUILayout.Space(10f);
            SDK.wallettoadd = float.Parse(GUILayout.TextField(SDK.wallettoadd.ToString(), SDK.TextBoxStyle));
            if (GUILayout.Button("Add Money to wallet", SDK.ButtonStyle))
            {
                PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") + SDK.wallettoadd);
            }
            GUILayout.Space(10f);
            SDK.banktoadd = float.Parse(GUILayout.TextField(SDK.banktoadd.ToString(), SDK.TextBoxStyle));
            if (GUILayout.Button("Add Money to bank", SDK.ButtonStyle))
            {
                PlayerPrefs.SetFloat("bankmoney", PlayerPrefs.GetFloat("bankmoney") + SDK.banktoadd);
            }
            if (GUILayout.Button("Set Night", SDK.ButtonStyle))
            {
                SDK.Time.time = 4f;
            }
            if (GUILayout.Button("Set Day", SDK.ButtonStyle))
            {
                SDK.Time.time = 12f;
            }
        }
    }
}
