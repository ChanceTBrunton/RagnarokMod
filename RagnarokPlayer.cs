using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using RagnarokMod.UI;

namespace RagnarokMod
{
    public class RagnarokPlayer : ModPlayer
    {
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
