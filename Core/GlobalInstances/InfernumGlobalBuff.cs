using CalamityMod;
using CalamityMod.Buffs.Alcohol;
using CalamityMod.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace InfernumMode.Core.GlobalInstances
{
    public class InfernumGlobalBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (!InfernumMode.CanUseCustomAIs)
                return;
            // Kill stupid crash
            if (type == ModContent.BuffType<Trippy>() && CalamityGlobalNPC.voidBoss != -1)
                player.Calamity().trippy = false;
        }
    }
}
