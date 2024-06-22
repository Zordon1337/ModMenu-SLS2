using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMenu_SLS.Modules.CountarStrika
{
    internal class InstantMatchmaking
    {
        public static void Run()
        {
            if (!SDK.bInstantMatchmaking)
                return;
            SDK.CountarStrika.matchmakingTarget = 0;
        }
    }
}
