﻿using System.Diagnostics;
using GitVersion;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        Logger.SetLoggers(s => Trace.WriteLine(s), s => Trace.WriteLine(s), s => Trace.WriteLine(s));
    }
}
