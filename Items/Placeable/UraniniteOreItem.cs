using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Items.Placeable
{
    public class UraniniteOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uraninite Ore");
            Tooltip.SetDefault("Mostly UO2 (and some U3O8 for good measure)!");
        }
        public override void SetDefaults()
        {
            item.width = 12; // hitbox width
            item.height = 12; // hitbox height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // broadsword
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("UraniniteOreTile");
            item.maxStack = 999;
        }
    }
}
