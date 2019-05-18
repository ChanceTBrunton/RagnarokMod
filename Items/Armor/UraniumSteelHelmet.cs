using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RagnarokMod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class UraniumSteelHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uranium Steel Helmet");
            Tooltip.SetDefault("A uranium helmet, what could go wrong?");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 10;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("UraniumSteelBreastplate") && legs.type == mod.ItemType("UraniumSteelLeggings");
        }
        
        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("UraniumBarItem"), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
