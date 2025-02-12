using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace VapingMod.Items.Carts
{
    public class Cart : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 3;
            Item.value = 500;
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, Item.maxStack);
            r.AddIngredient(ItemID.IronBar, 1);
            r.Register();
        }
    }
}
