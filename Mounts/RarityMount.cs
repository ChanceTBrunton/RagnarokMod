using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Mounts
{
    public class RarityMount : ModMountData
    {
        public override void SetDefaults()
        {
            mountData.spawnDust = 15;
            mountData.buff = mod.BuffType("RarityMountBuff");
            mountData.heightBoost = 34;
            mountData.flightTimeMax = 0;
            mountData.fallDamage = 0.2f;
            mountData.runSpeed = 4f;
            mountData.dashSpeed = 12f;
            mountData.acceleration = 0.3f;
            mountData.jumpHeight = 10;
            mountData.jumpSpeed = 8.01f;
            mountData.totalFrames = 16;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 28;
            }
            array[3] += 2;
            array[4] += 2;
            array[7] += 2;
            array[8] += 2;
            array[12] += 2;
            array[13] += 2;
            array[15] += 4;
            mountData.playerYOffsets = array;
            mountData.xOffset = 5;
            mountData.bodyFrame = 3;
            mountData.yOffset = 1;
            mountData.playerHeadOffset = 31;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 12;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 7;
            mountData.runningFrameDelay = 15;
            mountData.runningFrameStart = 1;
            mountData.dashingFrameCount = 6;
            mountData.dashingFrameDelay = 40;
            mountData.dashingFrameStart = 9;
            mountData.flyingFrameCount = 6;
            mountData.flyingFrameDelay = 6;
            mountData.flyingFrameStart = 1;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 12;
            mountData.inAirFrameStart = 15;
            mountData.idleFrameCount = 0;
            mountData.idleFrameDelay = 0;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = false;
            mountData.swimFrameCount = mountData.inAirFrameCount;
            mountData.swimFrameDelay = mountData.inAirFrameDelay;
            mountData.swimFrameStart = mountData.inAirFrameStart;
            if (Main.netMode == NetmodeID.Server)
            {
                return;
            }
            mountData.backTexture = ModLoader.GetTexture("RagnarokMod/Mounts/RarityMount");
            mountData.backTextureExtra = null;
            mountData.frontTexture = null;
            mountData.frontTextureExtra = null;
            mountData.textureWidth = mountData.backTexture.Width + 20;
            mountData.textureHeight = mountData.backTexture.Height;
        }

        public override void UpdateEffects(Player player)
        {
            if (!(Math.Abs(player.velocity.X) > 4f))
            {
                return;
            }

            Rectangle rect = player.getRect();
            Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, mod.DustType("Smoke"));
        }
    }
}