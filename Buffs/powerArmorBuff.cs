using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace RagnarokMod.Buffs
{
    public class powerArmorBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Power Armor");
            Description.SetDefault("It's like Fallout!");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            RagnarokPlayer p = player.GetModPlayer<RagnarokPlayer>();

            // Use powerArmorAcessoryPrevious instead of powerArmorAcessory because
            // UpdateBuffs happens before UpdateEquips but after ResetEffects
            if (p.powerArmorAccessoryPrevious) // condition for buff to be applied
            {
                p.powerArmorEnableBuff = true;
                player.lifeRegen++;
                player.statDefense += 3;
                player.extraFall += 45;
                player.jumpSpeedBoost += 10f;
                player.moveSpeed += 0.2f;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
