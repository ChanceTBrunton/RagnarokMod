using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace RagnarokMod
{
    public class RagnarokPlayer : ModPlayer
    {
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            Main.NewText("Player has died! (Ragnarok Mod)");
            base.Kill(damage, hitDirection, pvp, damageSource);
        }

        public override void OnRespawn(Player player)
        {
            Main.NewText("Player has respawned! (Ragnarok Mod)");
            base.OnRespawn(player);
        }

    }

}
