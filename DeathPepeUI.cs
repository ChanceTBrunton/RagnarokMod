using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.GameContent.UI.Elements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace RagnarokMod
{
    public class DeathPepeUI : UIState
    {
        public UIImage image;
        public static bool Visible;
        public override void OnInitialize()
        {
            image = new UIImage(ModLoader.GetTexture("pepe"));
            image.SetPadding(0);
            image.Left.Set(400f, 0f);
            image.Top.Set(100f, 0f);
            image.Width.Set(170f, 0f);
            image.Height.Set(70f, 0f);

            Append(image);
        }

    }
}
