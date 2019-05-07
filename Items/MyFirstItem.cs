using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Items
{
	public class MyFirstItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poweful Test Sword.");
			Tooltip.SetDefault("Extremely OP sword for testing purposes.");
		}
		public override void SetDefaults()
		{
			item.damage = 69;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
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
