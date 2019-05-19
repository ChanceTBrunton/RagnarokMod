using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using RagnarokMod.UI;

namespace RagnarokMod
{
    public class RagnarokPlayer : ModPlayer
    {
        public bool powerArmorAccessoryPrevious;
        public bool powerArmorAccessory;
        public bool powerArmorHideVanity;
        public bool powerArmorForceVanity;
        public bool powerArmorEnableBuff;
        public override void ResetEffects()
        {
            powerArmorAccessoryPrevious = powerArmorAccessory;
            powerArmorAccessory = powerArmorHideVanity = powerArmorForceVanity = powerArmorEnableBuff = false;
        }

        public override void UpdateVanityAccessories()
        {
            for (int n = 13; n < 18 + player.extraAccessorySlots; n++)
            {
                Item item = player.armor[n];
                if (item.type == mod.ItemType<Items.Armor.PowerArmorFrameItem>())
                {
                    powerArmorHideVanity = false;
                    powerArmorForceVanity = true;
                }
            }
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // Make sure this condition is the same as the condition in the Buff to remove itself.
            // We do this here instead of in ModItem.UpdateAccessory in case we want future upgraded
            // items to set powerArmorAcessory
            if (powerArmorAccessory)
            {
                player.AddBuff(mod.BuffType<Buffs.powerArmorBuff>(), 60, true);
            }
        }

        public override void FrameEffects()
        {
            if ((powerArmorEnableBuff || powerArmorForceVanity) && !powerArmorHideVanity)
            {
                player.legs = mod.GetEquipSlot("powerArmorLegs", EquipType.Legs);
                player.body = mod.GetEquipSlot("powerArmorBody", EquipType.Body);
                player.head = mod.GetEquipSlot("powerArmorHead", EquipType.Head);
            }
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            DeathPepeUI.visible = true;
            base.Kill(damage, hitDirection, pvp, damageSource);
        }

        public override void OnRespawn(Player player)
        {
            DeathPepeUI.visible = false;
            base.OnRespawn(player);
        }

    }

}
