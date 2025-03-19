using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ModMenu_SLS.UI
{
    internal class Watermark
    {

        public static void Render()
        {

            GUILayout.Window(420, new Rect(15, 15, 260, 25), Window, "",SDK.WindowStyle);
        }
        public static void Window(int wid)
        {


            
            GUILayout.Label($"ModMenu SLS2 - {Properties.Resources.BuildDate}",SDK.TextStyle);
        }
    }
}
