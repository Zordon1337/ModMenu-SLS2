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
            GUILayout.Space(10f);
            SDK.moneytoadd = float.Parse(GUILayout.TextField(SDK.moneytoadd.ToString(), SDK.TextBoxStyle));
            if (GUILayout.Button("Add Money", SDK.ButtonStyle))
            {
                GameManager.Instance.AddMoney(SDK.moneytoadd);
            }
            GUILayout.Space(10f);
            
            if (GUILayout.Button("Set Night", SDK.ButtonStyle))
            {
                GameManager.Instance.hour = 4f;
            }
            if (GUILayout.Button("Set Day", SDK.ButtonStyle))
            {
                GameManager.Instance.hour = 12f;
            }

            SDK.bNoNeeds = GUILayout.Toggle(SDK.bNoNeeds, $"Infinite Energy: {SDK.bNoNeeds}", SDK.CheckboxStyle);
        }
    }
}
