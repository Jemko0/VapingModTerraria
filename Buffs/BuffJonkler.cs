using Terraria.ModLoader;

namespace VapingMod.Buffs
{
    public class BuffJonkler : ModBuff
    {
        public override void SetStaticDefaults()
        {
            //Main.debuff[Type] = true;
            //Main.pvpBuff[Type] = true;
            //Terraria.ID.BuffID.Sets.TimeLeftDoesNotDecrease[Type] = true;
            //Main.LocalPlayer.buffTime[Type] = Util.GetFramesFromSeconds(3600 * 24);
        }

        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = "off the evil jonkler cart";
            tip = "you´re cooked";
            rare = 5;
            base.ModifyBuffText(ref buffName, ref tip, ref rare);
        }

        public override bool RightClick(int buffIndex)
        {
            return false;
        }
    }
}
