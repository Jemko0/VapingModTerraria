using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VapingMod.Items.Carts
{
    public class EvilJonklerCart : Cart
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Item.value = 15000;
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.BatBanner, 1);
            r.Register();
        }
    }
}
