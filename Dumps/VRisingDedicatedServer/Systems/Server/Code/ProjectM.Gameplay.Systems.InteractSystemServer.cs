using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InteractSystemServer : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_195795127_0;
    EntityQuery __query_195795127_1;
    EntityQuery __query_195795127_2;
    EntityQuery __query_195795127_3;
    EntityQuery __query_195795127_4;
    
    // unmanaged system, skipped generating example queries

}
