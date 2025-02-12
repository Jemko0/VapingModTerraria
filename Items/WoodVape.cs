using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VapingMod.Items.Carts;

namespace VapingMod.Items
{
    public class WoodVape : Vape
    {
        public WoodVape()
        {
            particleId = DustID.WoodFurniture;
            extraExhale = SoundID.Item4;
            cancerChance = 211;
            nicChance = 29;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.Wood, 8);
            r.AddIngredient(ModContent.ItemType<Cart>(), 1);
            r.Register();
        }
    }
}
