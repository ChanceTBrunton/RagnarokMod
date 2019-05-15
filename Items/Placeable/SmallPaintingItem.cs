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
    public class SmallPaintingItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A smaller test painting.");
            Tooltip.SetDefault("Insert placeholder text here.");
        }
        public override void SetDefaults()
        {
            item.width = 48; // hitbox width
            item.height = 32; // hitbox height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // broadsword
            item.noUseGraphic = true;
            
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("SmallPaintingTile");
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("UraniumBarItem"), 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
