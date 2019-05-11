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
    public class UraniumBarItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uranium Bar");
            Tooltip.SetDefault("WARNING: This product contains chemicals" +
                                " known to the State of California to cause cancer" +
                                " and birth defects or other reproductive harm.");
        }
        public override void SetDefaults()
        {
            item.width = 24; // hitbox width
            item.height = 24; // hitbox height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // broadsword
            item.value = 50;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("UraniumBarTile");
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("UraniumOreItem"), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
