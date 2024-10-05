using Terraria;
using Terraria.ID;

namespace VapingMod.Items
{
    public class DevVape100cancer : Vape
    {
        public DevVape100cancer()
        {
            particleId = DustID.YellowStarDust;
            extraExhale = SoundID.Item4;
            cancerChance = 0;
            nicChance = -1;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Quest;
        }
    }
}
