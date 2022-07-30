using StardewModdingAPI;

namespace Panstorm
{
    internal class ModConfig
    {
        public DisplayMode DisplayMode { get; set; } = DisplayMode.EnabledWhenHoldingPan;

        public int DisplayXOffset { get; set; } = 0;
        
        public int DisplayYOffset { get; set; } = 0;

        public bool PlayAudio { get; set; } = true;
        
        public float Volume { get; set; } = 2;
        
        public SButton StopPlayingButton { get; set; } = SButton.P;
    }
}
