using BepInEx;
using SpaceWarp;
using SpaceWarp.API.Mods;
using System.Runtime.InteropServices;

namespace kesa_solar;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(SpaceWarpPlugin.ModGuid, SpaceWarpPlugin.ModVer)]
public class kesa_solarPlugin : BaseSpaceWarpPlugin
{
    // These are useful in case some other mod wants to add a dependency to this one
    // ReSharper disable UnusedMember.Global
    public const string ModGuid = MyPluginInfo.PLUGIN_GUID;
    public const string ModName = MyPluginInfo.PLUGIN_NAME;
    public const string ModVer = MyPluginInfo.PLUGIN_VERSION;
    // ReSharper restore UnusedMember.Global

    // Singleton instance of the plugin class
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public static kesa_solarPlugin Instance { get; set; }
    public static string Path { get; private set; }
    private void Awake()
    {
        //Logger.LogInfo("Kesa Awake");
    }

    public override void OnPreInitialized()
    {
        //Logger.LogInfo("Kesa OnPreInitialized");
        kesa_solarPlugin.Path = base.PluginFolderPath;
    }


    /// <summary>
    /// Runs when the mod is first initialized.
    /// </summary>
    public override void OnInitialized()
    {
        base.OnInitialized();

        Instance = this;

        byte[] bytes = File.ReadAllBytes(PluginFolderPath + @"/assets/soundbank/kesa_solar.bnk");
    }
}
