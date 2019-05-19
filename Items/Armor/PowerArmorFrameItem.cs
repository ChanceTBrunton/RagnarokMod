using Terraria;
using Terraria.ModLoader;

namespace RagnarokMod.Items.Armor
{
    /*
     * Custom textures are defined in RagnarokMod.Load()
     */
    public class PowerArmorFrameItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Power Armor Frame");
            Tooltip.SetDefault("Accessories sold separately.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.accessory = true;
            item.value = 150000;
            item.rare = 5;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            RagnarokPlayer p = player.GetModPlayer<RagnarokPlayer>();
            p.powerArmorAccessory = true;
            if (hideVisual)
            {
                p.powerArmorHideVanity = true;
            }
        }
    }

    /*
     * The below classes represent the textures we will use when wearing the power armor frame.
     */

    public class powerArmorHead : EquipTexture
    {
        public override bool DrawHead()
        {
            return false; // disable drawing of head
        }
    }

    public class powerArmorBody : EquipTexture
    {
        public override bool DrawBody()
        {
            return false;
        }
    }

    public class powerArmorLegs : EquipTexture
    {
        public override bool DrawLegs()
        {
            return false;
        }
    }
}
