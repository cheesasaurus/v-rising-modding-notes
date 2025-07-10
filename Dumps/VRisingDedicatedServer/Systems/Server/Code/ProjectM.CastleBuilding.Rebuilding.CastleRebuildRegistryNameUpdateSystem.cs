using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildRegistryNameUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ChangeNameQuery;
    EntityQuery __query_1821521228_0;
    EntityQuery __query_1821521228_1;
    EntityQuery __query_1821521228_2;
    
    // unmanaged system, skipped generating example queries

}
