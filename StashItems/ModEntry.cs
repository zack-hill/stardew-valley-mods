using StardewModdingAPI;
using StardewModdingAPI.Events;
using System.Linq;

namespace StashItems
{
    public class ModEntry : Mod
    {
        internal static ModConfig Config { get; private set; }

        public override void Entry(IModHelper helper)
        {
            Config = helper.ReadConfig<ModConfig>();

            helper.Events.Input.ButtonsChanged += OnButtonsChanged;
		}

        private static void OnButtonsChanged(object sender, ButtonsChangedEventArgs e)
        {
            if (Context.IsWorldReady)
            {
                if (e.Pressed.Contains(Config.StashHotKey))
                {
                    ItemStashing.StashItemsInNearbyChests(Config.Radius);
                }
            }
        }
	}
}
