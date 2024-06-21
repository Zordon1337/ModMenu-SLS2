using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.Modules
{
    internal class BetterDonations
    {
        public static void Run()
        {
            if (!SDK.BetterDonations)
                return;
            PlayerPrefs.SetInt("donateskill", PlayerPrefs.GetInt("donateskill") * 25);
        }
    }
}
