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
            if (PlayerPrefs.GetInt("donateskill") == 0)
                PlayerPrefs.SetInt("donateskill", 1);
            if (PlayerPrefs.GetInt("streamsuprisedonateskill") == 0)
                PlayerPrefs.SetInt("streamsuprisedonateskill", 1);

            PlayerPrefs.SetInt("donateskill", PlayerPrefs.GetInt("donateskill") * 25);
            PlayerPrefs.SetInt("streamsuprisedonateskill", PlayerPrefs.GetInt("streamsuprisedonateskill") * 25);
        }
    }
}
