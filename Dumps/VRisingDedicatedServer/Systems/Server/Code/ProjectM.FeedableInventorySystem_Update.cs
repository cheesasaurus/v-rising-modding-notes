using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct FeedableInventorySystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _FeedableInventoryQuery;
    EntityQuery __query_1433501695_0;
    EntityQuery __query_1433501695_1;
    EntityQuery __query_1433501695_2;
    
    // unmanaged system, skipped generating example queries

}
