using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace VapingMod.Dusts
{
    public class EvilJonklerDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.4f; // Multiply the dust's start velocity by 0.4, slowing it down
            dust.noGravity = true; // Makes the dust have no gravity.
            dust.noLight = true; // Makes the dust emit no light.
            dust.scale *= 1.5f; // Multiplies the dust's initial scale by 1.5.
            dust.frame = new Rectangle(0, 0, 32, 32);
            dust.alpha = 96;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.velocity += new Vector2(0, -0.05f);
            dust.scale *= 1.01f;
            dust.alpha += 1;

            return false; // Return false to prevent vanilla behavior.
        }
    }
}
