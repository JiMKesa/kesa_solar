using BepInEx;
using SpaceWarp;
using SpaceWarp.API.Mods;
using System.Runtime.InteropServices;

namespace kesa_solar;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(SpaceWarpPlugin.ModGuid, SpaceWarpPlugin.ModVer)]
public class Kesa_solarPlugin : BaseSpaceWarpPlugin
{
    public const string ModGuid = MyPluginInfo.PLUGIN_GUID;
    public const string ModName = MyPluginInfo.PLUGIN_NAME;
    public const string ModVer = MyPluginInfo.PLUGIN_VERSION;
    public static Kesa_solarPlugin Instance { get; set; }
    public static string Path { get; private set; }
    private void Awake()
    {
        //Logger.LogInfo("Kesa Solar Awake");
    }

    public override void OnPreInitialized()
    {
        //Logger.LogInfo("Kesa Solar OnPreInitialized");
        Kesa_solarPlugin.Path = base.PluginFolderPath;
    }

    public override void OnInitialized()
    {
        //Logger.LogInfo("Kesa Solar OnInitialized");
        base.OnInitialized();
        Instance = this;
        Logger.LogInfo("Kesa Solar Mod Initialized");
        //Logger.LogInfo("Kesa Solar sound bank");
        //byte[] bytes = File.ReadAllBytes(PluginFolderPath + @"/assets/soundbank/kesa_solar.bnk");
        //Logger.LogInfo("Kesa Solar sound bank:" + AkSoundEngine.LoadBankMemoryView(GCHandle.Alloc(bytes, GCHandleType.Pinned).AddrOfPinnedObject(), (uint)bytes.Length, out uint bankId));
    }
}