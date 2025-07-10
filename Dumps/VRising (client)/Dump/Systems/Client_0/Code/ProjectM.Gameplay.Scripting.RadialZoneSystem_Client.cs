using Unity.Entities;

namespace ProjectM.Gameplay.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ScheduleParentGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RadialZoneSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RadialZoneEntitiesQuery;
    EntityQuery __query_10325388_0;
    
    // unmanaged system, skipped generating example queries

}
