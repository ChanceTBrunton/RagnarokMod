using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;

namespace RagnarokMod
{
    public class RagnarokWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Tutorial Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Generating Ragnarok Uranium Ore";
                    for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX), // X coordinate of tile
                            WorldGen.genRand.Next(0, Main.maxTilesY), // y coordinate of tile
                            (double)WorldGen.genRand.Next(3, 6), // Strength (High = more)
                            WorldGen.genRand.Next(2, 6), // Steps
                            mod.TileType("UraniniteOreTile"), // Tile type spawned
                            false, // Add Tile ???
                            0f, // Speed X ???
                            0f, // Speed Y ???
                            false, // noYChange ???
                            true); // Overrides existing tiles
                    }
                }));
            }
        }
    }
}
