using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Items
{
    public class UraniumSteelPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uranium Steel Pickaxe");
            Tooltip.SetDefault("This is very OP for testing purposes!");
        }
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 5; // visual speed
            item.useTime = 1; // pickaxe speed in 1/60ths of a second
            item.autoReuse = true;
            item.width = 24;
            item.height = 28;
            item.damage = 5;
            item.pick = 400;
            item.UseSound = SoundID.Item1;
            item.knockBack = 2f;
            item.value = 2000;
            item.melee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}