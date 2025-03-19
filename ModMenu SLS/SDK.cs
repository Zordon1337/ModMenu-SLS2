using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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
        public static void TeleportPlayer(PlayerMotor pc, Vector3 pos)

        {
            /*creating dummy transform because we can't directly provide Vector3 in the teleport function
            Transform dummy;
            dummy = new GameObject().transform;
            dummy.position = pos;
            nvrmind we can provide vector3*/
            pc.player.Teleport(pos);
        }
        public static void TeleportItem(Transform TP, Vector3 Where)
        {
            TP.position = Where;
        }
        public static bool IsInGame => GameManager.Instance != null;
        public static bool bInstantMatchmaking = false;
        public static bool bNoNeeds = false;
        public static bool bNoClip = false;
        public static GUIStyle ButtonStyle = new GUIStyle();
        public static GUIStyle ButtonStyleNavBar = new GUIStyle();
        public static GUIStyle WindowStyle = new GUIStyle();
        public static GUIStyle TextBoxStyle = new GUIStyle();
        public static GUIStyle CheckboxStyle = new GUIStyle();
        public static GUIStyle TextStyle = new GUIStyle();
        public static string posname = "here goes position name ps. locations will be stored in C:/MODMENU_SLS";
        //public static TimeManager Time;
        //public static PlayerController PlayerController;
        public static CamperStrikeManager csm;
        public static Weapon[] weapons = new Weapon[] { new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon(), new Weapon()};
        public static CarManager CM;
        public static CamperAI_DeathMatch[] ai_dm;
        public static CamperAI[] ai;
        public static float moneytoadd = 0;
        public static float speed = 25f;
        public static int page = 0;
        public static bool InfAmmo = false;
        public static bool InfDamage = false;
        public static bool InfHealth = false;
        public static bool NoSpread = false;
        public static bool RapidFire = false;
        public static bool Speedhack = false;
        public static bool InfinityJump = false;
        public static bool Wallhack = false;
        public static bool CounterHouse = false;

        public static string sSetFollowers = "Followers amount";
    }
}
