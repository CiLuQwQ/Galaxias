﻿using Galaxias.Core.World.Chunks;
using Galaxias.Core.World.Tiles;

namespace Galaxias.Core.World.Gen;
public class HeightGen : IChunkGenerator
{
    #region GENERATED

    private float noiseFreq = 0.04f;
    private float caveFreq = 0.05f;
    private int seed;
    private float heightMult = 10f;
    private float heightAddition = 120;
    public HeightGen(int seed) {
        this.seed = seed;
    }

    #endregion
    public void Generate(AbstractWorld world, Chunk applyChunk)
    {
        
    }
    public double GetHeight(TileLayer layer, int x)
    {
        return NoiseGen.Make2dNoise((x + seed) * noiseFreq, seed * noiseFreq) * heightMult + heightAddition;
    }
}
