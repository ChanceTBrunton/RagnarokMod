using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.DataStructures;

namespace RagnarokMod
{
	class RagnarokMod : Mod
	{
        public UserInterface customResources;

        public RagnarokMod()
        {
            
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                customResources = new UserInterface();
            }
        }

        /*
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            new GameInterfaceLayer()
            layers.Insert(0, new GameInterfaceLayer("layer", 1));
            layers.Insert(layers.Count, new MethodSequenceListItem(
            //layers.Insert(layers.Count, new GameInterfaceLayer(
                "Pepe Sign",
                delegate
                {
                    // update ui here
                },
                null));
        }*/
    }
}
