using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.InteractSystemClient_Sequences))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InteractSystemClient : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_195794868_0;
    EntityQuery __query_195794868_1;
    EntityQuery __query_195794868_2;
    EntityQuery __query_195794868_3;
    
    // unmanaged system, skipped generating example queries

}
