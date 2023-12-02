using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace GirlBeGone
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class GirlBeGoneBase: BaseUnityPlugin
    {
        public const string GUID = "com.github.stoops417.GirlBegone";
        public const string NAME = "GirlBegone";
        public const string VERSION = "1.0";

        internal static ManualLogSource Log;

        private void Awake()
        {
            Log = Logger;
            Harmony harmony = new Harmony(GUID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
