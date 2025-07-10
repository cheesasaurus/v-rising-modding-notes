using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup), OrderFirst = true)]
[CreateAfter(typeof(Unity.Physics.Systems.BuildStaticPhysicsWorld))]
public struct UpdateStaticPhysicsBodiesSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _InvalidBodiesDebugQuery;
    EntityQuery _ActiveStaticBodiesQuery;
    EntityQuery _SuperStaticResetBodiesQuery;
    EntityQuery _BodiesToUpdateQuery;
    EntityQuery _StaticTransformElementsQuery;
    EntityQuery __query_1353801189_0;
    EntityQuery __query_1353801189_1;
    
    // unmanaged system, skipped generating example queries

}
