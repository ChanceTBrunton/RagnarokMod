using Terraria.UI;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria;

namespace RagnarokMod.UI
{
    internal class DeathPepeUI : UIState
    {
        // public UIImage image;
        public static bool visible;
        public UIImage pepeImage;
        public override void OnInitialize()
        {
            visible = false; // dynamically enabled as needed in RangarokMod.cs

            pepeImage = new UIImage(ModLoader.GetTexture("RagnarokMod/UI/pepe"));
            int pepePNGHeight = 543;
            int pepePNGWidth = 514;
            pepeImage.Left.Set(Main.screenWidth/4 - pepePNGHeight/2, 0);
            pepeImage.Top.Set(Main.screenHeight/2 - pepePNGWidth/2, 0);
            Append(pepeImage);
        }

    }
}
