using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RemovePvPSafeBuffOnCastleEntrySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_435788506_0;
    
    // unmanaged system, skipped generating example queries

}
