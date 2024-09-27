using Terraria;
using Terraria.ID;

namespace VapingMod.Items
{
    public class StardustVape : Vape
    {
        public StardustVape()
        {
            particleId = DustID.YellowStarDust;
            extraExhale = SoundID.Item4;
            cancerChance = 650;
            nicChance = 17;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Purple;
        }
    }
}
