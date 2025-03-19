using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class InfDamage
    {
        public static void Run()
        {

            if (SDK.csm != null && SDK.InfDamage)
            {
                if (SDK.csm.csPlayer == null)
                    return;

                var CPlayer = SDK.csm.csPlayer;
                if (CPlayer.kalash == null)
                    return;
                var weapons = SDK.weapons;
                foreach (var wp in weapons)
                {
                    wp.damage = int.MaxValue;

                }
            }
        }
    }
}
