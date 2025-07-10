using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TravelBuffSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_615927151_0;
    EntityQuery __query_615927151_1;
    
    // unmanaged system, skipped generating example queries

}
