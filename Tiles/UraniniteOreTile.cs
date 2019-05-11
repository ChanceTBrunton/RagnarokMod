using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RagnarokMod.Tiles
{
    class UraniniteOreTile : ModTile // Uraninite, UO2 (and trace U3O8), is the most common uranium ore mineral irl. Can also contain thorium.
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
            Main.tileValue[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
            Main.tileShine2[Type] = true; // Modifies the draw color slightly.
            Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
            Main.tileMergeDirt[Type] = true; // will the image merge with dirt (most of the time, yes)
            Main.tileLighted[Type] = true; // ???
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Uraninite Ore");
            AddMapEntry(new Color(0, 255, 0), name); // color of tile on map

            dustType = 84;
            drop = mod.ItemType("UraniniteOreItem"); // what item drops after destroying the tile
            soundType = 21;
            soundStyle = 1;
            //mineResist = 4f;
            //minPick = 200; // minimum pickaxe power needed to mine
        }

        /*
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.75f;
            g = 0.25f;
            b = 0.5f;
        }
        */
    }
}
