using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VapingMod.Dusts;
using VapingMod.Items.Carts;

namespace VapingMod.Items
{
    public class EvilJonklerVape : Vape
    {
        public EvilJonklerVape()
        {
            particleId = ModContent.DustType<EvilJonklerDust>();
            extraExhale = new Terraria.Audio.SoundStyle("VapingMod/Sounds/Music/jiggler");
            cancerChance = 80;
            nicChance = 1;
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Master;
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.IronBar, 2);
            r.AddIngredient(ModContent.ItemType<EvilJonklerCart>(), 1);
            r.AddTile(TileID.Anvils);
            r.Register();
        }
    }
}
