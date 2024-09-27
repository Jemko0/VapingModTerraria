using Terraria;
using Terraria.ModLoader;

namespace VapingMod.Buffs
{
    public class BuffLungCancer : ModBuff
    {
        private int timer = 0;
        public override void SetStaticDefaults()
        {
            //Main.debuff[Type] = true;
            //Main.pvpBuff[Type] = true;
            //Terraria.ID.BuffID.Sets.TimeLeftDoesNotDecrease[Type] = true;
            //Main.LocalPlayer.buffTime[Type] = Util.GetFramesFromSeconds(3600 * 24);
        }

        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = "Lung Cancer";
            tip = "you chiefed too much... or you´re walter white!";
            rare = 3;
            base.ModifyBuffText(ref buffName, ref tip, ref rare);
        }

        public override void Update(Player player, ref int buffIndex)
        {
            timer++;
            if(timer % 15  == 0)
            {
                player.Hurt(Terraria.DataStructures.PlayerDeathReason.ByCustomReason("Lung Cancer"), 1, 0, cooldownCounter: 5, dodgeable: false);
            }
            base.Update(player, ref buffIndex);
        }
    }
}
