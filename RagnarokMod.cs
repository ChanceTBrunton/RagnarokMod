using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Microsoft.Xna.Framework;
using RagnarokMod.UI;

namespace RagnarokMod
{
    class RagnarokMod : Mod
	{
        internal DeathPepeUI deathPepeUI;
        public UserInterface pepeInterface;

        public override void Load()
        {
            if (!Main.dedServ) // server (which is just a cmd prompt) shouldn't have a UI
            {
                // Load the UI elements for the pepe that shows on death
                deathPepeUI = new DeathPepeUI();
                deathPepeUI.Initialize();
                pepeInterface = new UserInterface();
                pepeInterface.SetState(deathPepeUI);
            }
        }

        public override void UpdateUI(GameTime gameTime)
        {
            // it will only draw if the player is not on the main menu
            if (!Main.gameMenu && DeathPepeUI.visible)
            {
                // I commented out this line because for some reason ?. is causing a compilation error.
                //pepeInterface?.Update(gameTime); // ?. checks pepeInterface for null before calling Update()
                pepeInterface.Update(gameTime); // this should (probably) be checked for null
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            layers.Add(new LegacyGameInterfaceLayer("Ragnarok Mod: Death Pepe UI", DrawDeathPepeUI, InterfaceScaleType.UI));

            /*
            new GameInterfaceLayer()
            layers.Insert(0, new GameInterfaceLayer("layer", 1));
            layers.Insert(layers.Count, new MethodSequenceListItem(
            //layers.Insert(layers.Count, new GameInterfaceLayer(
                "Pepe Sign",
                delegate
                {
                    // update ui here
                },
                null));*/
        }

        private bool DrawDeathPepeUI()
        {
            // it will only draw if the player is not on the main menu
            if (!Main.gameMenu
                && DeathPepeUI.visible)
            {
                pepeInterface.Draw(Main.spriteBatch, new GameTime());
            }
            return true;
        }
    }
}
