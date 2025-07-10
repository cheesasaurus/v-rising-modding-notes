using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.PatrolMoveSystem))]
[UpdateAfter(typeof(ProjectM.UnitCompositionSpawnerSystem))]
public struct PatrolMoveSystemEverySecond : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_92363334_0;
    EntityQuery __query_92363334_1;
    EntityQuery __query_92363334_2;
    EntityQuery __query_92363334_3;
    
    // unmanaged system, skipped generating example queries

}
