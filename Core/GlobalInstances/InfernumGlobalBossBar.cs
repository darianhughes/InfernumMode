using CalamityMod.NPCs.CeaselessVoid;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumMode.Core.GlobalInstances
{
    public class InfernumGlobalBossBar : GlobalBossBar
    {
        public override bool PreDraw(SpriteBatch spriteBatch, NPC npc, ref BossBarDrawParams drawParams)
        {
            if (!InfernumMode.CanUseCustomAIs)
                return base.PreDraw(spriteBatch, npc, ref drawParams);
            if (npc.type == NPCID.BrainofCthulhu)
            {
                drawParams.Shield = 0;
                drawParams.ShieldMax = 0;
            }
            if (npc.type == NPCID.GolemHead || npc.type == NPCID.Golem)
            {
                drawParams.LifeMax = npc.lifeMax;
                drawParams.Life = npc.life;
            }
            if (npc.type == ModContent.NPCType<CeaselessVoid>())
            {
                drawParams.ShieldMax = npc.Infernum().ExtraAI[7];
                drawParams.Shield = npc.Infernum().ExtraAI[8];
            }
            return base.PreDraw(spriteBatch, npc, ref drawParams);
        }
    }
}
