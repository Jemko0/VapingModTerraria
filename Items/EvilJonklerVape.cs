using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VapingMod.Buffs;
using VapingMod.Dusts;
using VapingMod.Helper;
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

        protected override void LungCancer(Player player)
        {
            if (Main.rand.Next(0, 2) == 0)
            {
                player.AddBuff(ModContent.BuffType<BuffJonkler>(), Util.GetFramesFromSeconds(180)); //@todo make it get longer the more the player smokes
            }
            base.LungCancer(player);
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
