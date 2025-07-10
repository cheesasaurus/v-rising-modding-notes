using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModificationCleanupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_11831353_0;
    EntityQuery __query_11831353_1;
    EntityQuery __query_11831353_2;
    EntityQuery __query_11831353_3;
    
    // unmanaged system, skipped generating example queries

}
