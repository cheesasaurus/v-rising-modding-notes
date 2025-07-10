using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ScheduleParentGroup))]
[UpdateAfter(typeof(ProjectM.UnitCompositionSpawnerSystem))]
public struct PatrolMoveSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateLocalPatrolQuery;
    EntityQuery _UpdateLocalPatrolDisabledQuery;
    EntityQuery _MovePatrolQuery;
    EntityQuery _MovePatrolDisabledQuery;
    EntityQuery __query_92362346_0;
    EntityQuery __query_92362346_1;
    EntityQuery __query_92362346_2;
    EntityQuery __query_92362346_3;
    EntityQuery __query_92362346_4;
    EntityQuery __query_92362346_5;
    EntityQuery __query_92362346_6;
    
    // unmanaged system, skipped generating example queries

}
