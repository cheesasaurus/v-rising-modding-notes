using Unity.Entities;

namespace ProjectM.Gameplay.ChatQuips;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ChatQuipSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_898644444_0;
    EntityQuery __query_898644444_1;
    EntityQuery __query_898644444_2;
    EntityQuery __query_898644444_3;
    
    // unmanaged system, skipped generating example queries

}
