using Unity.Entities;

namespace Conversion;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[UpdateBefore(typeof(ProjectM.Terrain.TerrainManager))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StaticTerrainChunkTransformationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UntransformedQuery;
    EntityQuery __query_662091986_0;
    EntityQuery __query_662091986_1;
    
    // unmanaged system, skipped generating example queries

}
