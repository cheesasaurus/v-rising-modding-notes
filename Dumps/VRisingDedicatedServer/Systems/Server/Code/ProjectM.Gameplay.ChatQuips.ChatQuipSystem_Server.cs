using Unity.Entities;

namespace ProjectM.Gameplay.ChatQuips;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ChatQuipSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery _ConnectedUsersQuery;
    EntityQuery __query_898644492_0;
    
    // unmanaged system, skipped generating example queries

}
