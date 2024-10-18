using Terraria;
using Terraria.ID;

namespace VapingMod.Items
{
    public class AdamantiteVape : Vape
    {
        public AdamantiteVape()
        {
            particleId = DustID.Adamantite;
            extraExhale = SoundID.Item4;
            cancerChance = 500;
            nicChance = 57;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.AdamantiteBar, 2);
            r.AddTile(TileID.MythrilAnvil);
            r.Register();
        }
    }
}
