﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VapingMod.Items.Carts;

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

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.IronBar, 2);
            r.AddIngredient(ModContent.ItemType<Cart>(), 1);
            r.AddIngredient(ItemID.FallenStar, 3);
            r.AddTile(TileID.Anvils);
            r.Register();
        }
    }
}
