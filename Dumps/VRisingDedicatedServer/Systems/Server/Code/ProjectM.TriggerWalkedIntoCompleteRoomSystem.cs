using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TriggerWalkedIntoCompleteRoomSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1908719234_0;
    
    // unmanaged system, skipped generating example queries

}
