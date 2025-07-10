using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DashSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_691853063_0;
    
    // unmanaged system, skipped generating example queries

}
