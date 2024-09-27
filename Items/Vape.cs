using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using VapingMod.Helper;
using Terraria.Audio;
using VapingMod.Buffs;

namespace VapingMod.Items
{
    /// <summary>
    /// vape base class
    /// </summary>
    public class Vape : ModItem
    {
        private int timer = 0;
        private bool running = false;
        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.width = 15;
            Item.height = 15;
            Item.useTime = Util.GetFramesFromSeconds(3);
            Item.consumable = false;
            Item.rare = ItemRarityID.Gray;
            Item.useStyle = ItemUseStyleID.DrinkLong;
        }

        // overridable for subclasses

        /// <summary>
        /// @todo make struct later on
        /// </summary>

        public int particleId = DustID.Smoke;
        public int particleVel = 5;
        public float particleScale = 1.5f;
        public SoundStyle? extraInhale = null;
        public SoundStyle? extraExhale = null;
        public int cancerChance = -1;
        public int nicChance = -1;

        public override bool? UseItem(Player player)
        {
            SoundEngine.PlaySound(new SoundStyle("VapingMod/Sounds/SFX/inhale"));
            if (extraInhale != null)
            {
                SoundEngine.PlaySound(extraInhale);
            }

            LungCancer(player);
            NicotineAddiction(player);

            RestartTimer();
            return true;
        }

        protected virtual void LungCancer(Player player)
        {
            if (Main.rand.Next(0, cancerChance + 1) == 0 && cancerChance != -1)
            {
                player.AddBuff(ModContent.BuffType<BuffLungCancer>(), Util.GetFramesFromSeconds(3600)); //@todo make it get longer the more the player smokes
                Logging.PublicLogger.Info(player.name + " diagnosed with lung cancer (too much chiefin)");
            }
            else
            {
                Logging.PublicLogger.Info(player.name + " got lucky (this time...)");
            }
        }

        protected virtual void NicotineAddiction(Player player)
        {
            if (Main.rand.Next(0, nicChance + 1) == 0 && nicChance != -1)
            {
                player.AddBuff(ModContent.BuffType<BuffNicotine>(), Util.GetFramesFromSeconds(360000)); //@todo make it get longer the more the player smokes
            }
        }

        public override void HoldItem(Player player)
        {
            timer++;

            if (timer > Item.useTime - (Item.useTime / 3))
            {
                if (timer < Item.useTime + 15)
                {
                    Dust.NewDustDirect(player.position, 16, 16, particleId, player.direction == 1 ? particleVel : -particleVel, 0, Scale: particleScale);
                }

                if(running == true)
                {
                    Exhale(player);
                }
                
            }
            base.HoldItem(player);
        }

        public void RestartTimer()
        {
            running = true;
            timer = 0;
        }

        /// <summary>
        /// exhales mmmmm
        /// evil jonkler cart
        /// </summary>
        public void Exhale(Player ply)
        {
            running = false;
            SoundEngine.PlaySound(new SoundStyle("VapingMod/Sounds/SFX/exhale"));
            if(extraExhale != null)
            {
                SoundEngine.PlaySound(extraExhale);
            }
        }

        public override void AddRecipes()
        {
            Recipe r = Recipe.Create(Type, 1);
            r.AddIngredient(ItemID.IronBar, 2);
            r.AddTile(TileID.Anvils);
            base.AddRecipes();
        }
    }
}
