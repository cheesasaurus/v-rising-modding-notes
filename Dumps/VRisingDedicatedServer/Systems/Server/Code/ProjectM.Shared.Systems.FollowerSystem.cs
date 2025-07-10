using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct FollowerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_652683813_0;
    EntityQuery __query_652683813_1;
    EntityQuery __query_652683813_2;
    
    // unmanaged system, skipped generating example queries

}
