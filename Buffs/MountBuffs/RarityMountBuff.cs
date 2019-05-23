using Terraria;
using Terraria.ModLoader;

namespace RagnarokMod.Buffs.MountBuffs
{
    public class RarityMountBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Rarity");
            Description.SetDefault("Best pony.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType<Mounts.RarityMount>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}
