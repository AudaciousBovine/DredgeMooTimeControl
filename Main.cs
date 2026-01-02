﻿using HarmonyLib;
using System.Reflection;
using Winch.Config;

// The namespace of the mod used by all the scripts to avoid naming conflicts
namespace MooTimeControl
{
    public class Main
    {
        // Creates a reference to the mod config file that can be accessed by typing "Main.Config.GetProperty<PropertyType>("MameOfProperty")"
        public static ModConfig Config => ModConfig.GetConfig();

        // This method is run by Winch to initialize your mod
        public static void Initialize()
        {
            // RUNS HARMONY PATCHES
            new Harmony("com.AudaciousBovine.MooTimeControl").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}