using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace ValheimLootMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInProcess("valheim.exe")]
    public class ValheimLootMod : BaseUnityPlugin
    {
        // setting mod details
        private const string modGUID = "wheatley1239.ValheimLootMultiplier";
        private const string modName = "Valheim Loot Multiplier by wheatley1239";
        private const string modVersion = "0.0.0.1";

        // harmony
        private readonly Harmony harmony = new Harmony(modGUID);

        // unity program start
        void Awake()
        {
            harmony.PatchAll();
        }
    }
}
