using Terraria.ModLoader;

namespace VapingMod.Buffs
{
    public class BuffNicotine : ModBuff
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
            buffName = "Nicotine Addiction";
            tip = "I can quit anytime!";
            rare = 4;
            base.ModifyBuffText(ref buffName, ref tip, ref rare);
        }
    }
}
