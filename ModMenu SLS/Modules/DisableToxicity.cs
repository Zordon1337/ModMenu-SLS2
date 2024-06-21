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
        public static void Run()
        {
            if (!SDK.DisableToxicity)
                return;

            PlayerPrefs.SetFloat("streamtoxiccount", 0f);
        }
    }
}
