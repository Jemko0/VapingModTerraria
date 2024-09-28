using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using VapingMod.Items.Carts;

namespace VapingMod.Systems
{
    public class VapingModGlobalNPC : GlobalNPC
    {
        
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType == NPCID.Dryad)
            {
                shop.Add(new NPCShop.Entry(ModContent.ItemType<EvilJonklerCart>()));
            }
        }

        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            shop[nextSlot] = ModContent.ItemType<EvilJonklerCart>();
            nextSlot++;
        }
    }
}
