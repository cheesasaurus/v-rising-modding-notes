using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildInvalidateSourceTransformsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_954791216_0;
    EntityQuery __query_954791216_1;
    EntityQuery __query_954791216_2;
    EntityQuery __query_954791216_3;
    EntityQuery __query_954791216_4;
    EntityQuery __query_954791216_5;
    
    // unmanaged system, skipped generating example queries

}
