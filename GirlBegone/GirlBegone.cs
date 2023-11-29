using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace SpidersBegone
{
    [BepInPlugin(GUID, NAME, VERSION)]
    internal class SpidersBegone : BaseUnityPlugin
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