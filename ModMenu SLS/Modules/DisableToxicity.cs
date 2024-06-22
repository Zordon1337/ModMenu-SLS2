using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules
{
    internal class DisableToxicity
    {
        [HarmonyPatch(typeof(StreamManager))]
        [HarmonyPatch("LoadToxicCount")]
        public static class LoadToxicCount
        {
            [HarmonyPrefix]
            public static void Prefix()
            {
                if (!SDK.DisableToxicity)
                    return;

                PlayerPrefs.SetFloat("streamtoxiccount", 0f);
            }
        }
        [HarmonyPatch(typeof(StreamManager))]
        [HarmonyPatch("SaveToxicCount")]
        public static class SaveToxicCount
        {
            [HarmonyPrefix]
            public static void Prefix()
            {
                if (!SDK.DisableToxicity)
                    return;

                PlayerPrefs.SetFloat("streamtoxiccount", 0f);
            }
        }
    }
}
