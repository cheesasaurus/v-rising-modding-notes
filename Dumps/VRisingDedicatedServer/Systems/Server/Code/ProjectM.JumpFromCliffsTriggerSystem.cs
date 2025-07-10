using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct JumpFromCliffsTriggerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1619853995_0;
    EntityQuery __query_1619853995_1;
    EntityQuery __query_1619853995_2;
    EntityQuery __query_1619853995_3;
    EntityQuery __query_1619853995_4;
    
    // unmanaged system, skipped generating example queries

}
