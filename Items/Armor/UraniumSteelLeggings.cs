using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace RagnarokMod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class UraniumSteelLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Uranium Steel Leggings");
            Tooltip.SetDefault("A pair of uranium leggings, what could go wrong?");
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
            return head.type == mod.ItemType("UraniumSteelHelmet") && body.type == mod.ItemType("UraniumSteelBreastplate");
        }

        // UpdateArmorSet() gives buffs only when the whole set is worn.
        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
        }

        // UpdateEquip() gives buffs when this specific item is equipped.
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 40;
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
