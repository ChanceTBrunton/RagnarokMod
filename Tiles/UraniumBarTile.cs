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

namespace RagnarokMod.Tiles
{
    class UraniumBarTile : ModTile 
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true; // ???
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            //TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1); // this tile will copy a 1x1 tile such as bars
            TileObjectData.addTile(Type);

            drop = mod.ItemType("UraniumBarItem"); // what item drops after destroying the tile
            soundType = 21;
            soundStyle = 1;
            //mineResist = 4f;
            //minPick = 200; // minimum pickaxe power needed to mine

        }
    }
}
