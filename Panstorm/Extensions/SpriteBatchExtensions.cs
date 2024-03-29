﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;

namespace Panstorm.Extensions
{
    public static class SpriteBatchExtensions
    {
        public static void DrawStringWithShadow(
            this SpriteBatch batch,
            SpriteFont font,
            string text,
            Vector2 position,
            Color color,
            float depth = 0F,
            float shadowDepth = 0.005F)
        {
            batch.DrawStringWithShadow(font, text, position, color, Color.Black, Vector2.One, depth, shadowDepth);
        }

        public static void DrawStringWithShadow(
            this SpriteBatch batch,
            SpriteFont font,
            string text,
            Vector2 position,
            Color color,
            Color shadowColor,
            Vector2 scale,
            float depth,
            float shadowDepth)
        {
            batch.DrawString(
                font,
                text,
                position + Vector2.One * Game1.pixelZoom * scale / 2f,
                shadowColor,
                0F,
                Vector2.Zero,
                scale,
                SpriteEffects.None,
                shadowDepth);
            batch.DrawString(font, text, position, color, 0F, Vector2.Zero, scale, SpriteEffects.None, depth);
        }
    }
}
