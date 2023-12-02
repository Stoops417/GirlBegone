using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirlBeGone.Patches
{
    [HarmonyPatch]    
    internal class RoundManagerPatcher
    {
        /// <summary>
        /// Prevent any girls from spawning by pretending that they're too powerful for the current conditions.
        /// This happens during a server-only planning stage so this works even if clients do not have the mod.
        /// </summary>
        [HarmonyPostfix]
        [HarmonyPatch(typeof(RoundManager), nameof(RoundManager.EnemyCannotBeSpawned))]
        private static void PreventGirlSpawns(RoundManager __instance, ref bool __result, int enemyIndex)
        {
            var enemy = __instance.currentLevel.Enemies[enemyIndex];
            if (enemy.enemyType.enemyName.ToLower().Contains("girl"))
            {                
                GirlBeGoneBase.Log.LogDebug("Prevented girl spawn.");
                __result = true;
            }
        }
    }
}