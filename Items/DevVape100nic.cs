using Terraria;
using Terraria.ID;

namespace VapingMod.Items
{
    public class DevVape100nic : Vape
    {
        public DevVape100nic()
        {
            particleId = DustID.YellowStarDust;
            extraExhale = SoundID.Item4;
            cancerChance = -1;
            nicChance = 0;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Quest;
        }
    }
}
