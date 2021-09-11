using StardewModdingAPI;

namespace StashItems
{
    public class ModEntry : Mod
    {
        public static ModConfig Config { get; private set; }

        public override void Entry(IModHelper helper)
        {
            Config = helper.ReadConfig<ModConfig>();
        }
    }
}
