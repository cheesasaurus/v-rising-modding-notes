using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MinionUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventsToRemove;
    EntityQuery __query_166460153_0;
    EntityQuery __query_166460153_1;
    EntityQuery __query_166460153_2;
    
    // unmanaged system, skipped generating example queries

}
