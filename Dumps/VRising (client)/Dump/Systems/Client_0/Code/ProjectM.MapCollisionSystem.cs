using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MoveGroup))]
public struct MapCollisionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MapCollisionQuery;
    EntityQuery __query_44068652_0;
    EntityQuery __query_44068652_1;
    
    // unmanaged system, skipped generating example queries

}
