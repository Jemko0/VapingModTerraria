using Terraria.Chat;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace VapingMod
{
    public class VaperPlayer : ModPlayer
    {
        public int smokeCount = 0;
        
        public override void PostUpdate()
        {
            smokeCount++;
            base.PostUpdate();
        }

        public override void UpdateDead()
        {
            smokeCount = 0;
            base.UpdateDead();
        }
        public override void SaveData(TagCompound tag)
        {
            tag["smoker"] = smokeCount;
            Logging.PublicLogger.Debug("---------SAVED SMOKE COUNT: " + smokeCount);
            base.SaveData(tag);
        }
        public override void LoadData(TagCompound tag)
        {
            smokeCount = tag.GetInt("smoker");
            Logging.PublicLogger.Debug("---------LOADED SMOKE COUNT: " + smokeCount);
            base.LoadData(tag);
        }
    }
}
