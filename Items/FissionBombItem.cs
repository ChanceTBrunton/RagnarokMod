using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod.Items
{
    public class FissionBombItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fission Bomb");
            Tooltip.SetDefault("When grenades just aren't enough...");
        }
        public override void SetDefaults()
        {
            item.damage = 0;     //The damage stat for the Weapon.                   
            item.width = 10;    //sprite width
            item.height = 32;   //sprite height
            item.maxStack = 999;   //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once fired
            item.useStyle = 1;   //The way your item will be used, 1 is the regular sword swing for example
            item.rare = 2;     //The color the title of your item when hovering over it ingame
            item.useAnimation = 20;  //How long the item is used for.
            item.useTime = 20;     //How fast the item is used.
            item.value = Item.buyPrice(0, 0, 3, 0);   //How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 3 silver)
            item.noUseGraphic = true; // not seen in hand (because it is thrown)
            item.noMelee = true;      //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.shoot = mod.ProjectileType("FissionBombProjectile"); //This defines what type of projectile this item will shoot	
            item.shootSpeed = 20f; //This defines the projectile speed when shot
            item.value = 10000; // in copper coins
            item.autoReuse = true;

            item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Item/NuclearLaunchSound");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
