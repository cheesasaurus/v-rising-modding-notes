using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ScheduleParentGroup))]
public struct ActuallyDisableByChunkSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EnabledEntitiesQuery;
    EntityQuery _DisabledEntitiesQuery;
    EntityQuery __query_1408750320_0;
    EntityQuery __query_1408750320_1;
    EntityQuery __query_1408750320_2;
    
    // unmanaged system, skipped generating example queries

}
