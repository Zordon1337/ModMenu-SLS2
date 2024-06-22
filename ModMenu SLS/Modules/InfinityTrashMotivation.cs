using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModMenu_SLS.Modules
{
    internal class InfinityTrashMotivation
    {
        public static void Run()
        {
            if (!SDK.InfinityTrashMotivation)
                return;

            if (SDK.trashp != null)
                SDK.trashp.trashMotivation = 100f;
        }
    }
}
