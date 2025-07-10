using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LowHealthSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1310448649_0;
    EntityQuery __query_1310448649_1;
    
    // unmanaged system, skipped generating example queries

}
