using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class Speedhack
    {
        public static void Run()
        {

            if (SDK.CountarStrika != null && SDK.Speedhack)
            {
                if (SDK.CountarStrika.csPlayer == null)
                    return;

                var CPlayer = SDK.CountarStrika.csPlayer;

                CPlayer.speed = 30;
            }
        }
    }
}
