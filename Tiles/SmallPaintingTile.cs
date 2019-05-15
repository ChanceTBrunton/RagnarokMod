using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace RagnarokMod.Tiles
{
    public class SmallPaintingTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true; // ???
            Main.tileSolid[Type] = false;
            Main.tileLighted[Type] = true; // allows block to emit light, see ModifyLight() method
  
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 3; 
            //TileObjectData.newTile.CoordinateHeights = new int[] { 360 };//, 16, 16 };
            //TileObjectData.newTile.CoordinateWidth = 252;
            //TileObjectData.newTile.DrawYOffset = -344;
            //TileObjectData.newTile.Origin = new Point16(0,0);
            TileObjectData.addTile(Type);

            drop = mod.ItemType("SmallPaintingItem"); // what item drops after destroying the tile
            soundType = 21;
            soundStyle = 1;
            //mineResist = 4f;
            //minPick = 200; // minimum pickaxe power needed to mine

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("A Small Painting");
            AddMapEntry(new Color(175, 13, 166), name);
        }

        // set the color of light emitted
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 1;
            g = 1;
            b = 1;
        }
    }
}
