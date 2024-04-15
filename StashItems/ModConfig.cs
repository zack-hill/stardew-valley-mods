using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace StashItems
{
    internal class ModConfig
    {
        public int Radius { get; set; } = 5;
        public KeybindList StashHotKey { get; set; } = new(SButton.R);
    }
}
