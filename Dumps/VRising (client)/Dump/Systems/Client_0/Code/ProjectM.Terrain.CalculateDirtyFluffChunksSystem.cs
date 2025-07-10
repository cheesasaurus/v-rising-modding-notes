using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
public struct CalculateDirtyFluffChunksSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1887783028_0;
    EntityQuery __query_1887783028_1;
    
    // unmanaged system, skipped generating example queries

}
