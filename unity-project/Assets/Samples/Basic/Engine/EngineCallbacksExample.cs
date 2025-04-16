using System.Collections;
using System.Collections.Generic;
using Noir.Attributes;
using Noir.Logging;
using UnityEngine;

public class EngineCallbacksExample
{
    [EngineCallback(EngineCallbackType.Initialize)]
    public static void InitializeCallback()
    {
        LoggerSingleton.Info<EngineCallbacksExample>($"Initialize callback invoked. time={Time.realtimeSinceStartup}");
    }

    [EngineCallback(EngineCallbackType.ConfigureServices)]
    public static void ConfigureServicesCallback()
    {
        LoggerSingleton.Info<EngineCallbacksExample>($"ConfigureServices callback invoked. time={Time.realtimeSinceStartup}");
    }

    [EngineCallback(EngineCallbackType.Start)]
    public static void StartCallback()
    {
        LoggerSingleton.Info<EngineCallbacksExample>($"Start callback invoked. time={Time.realtimeSinceStartup}");
    }
}
