using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Items.MountSummons
{
    public class RarityMountItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Darling, this is a modded mount.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 30000;
            item.rare = 2;
            item.UseSound = SoundID.Item79;
            item.noMelee = true;
            item.mountType = mod.MountType("RarityMount");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
        }
    }
}