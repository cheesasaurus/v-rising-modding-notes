using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSimulationGroup), OrderFirst = true)]
[CreateBefore(typeof(Unity.Physics.Systems.BroadphaseSystem))]
[CreateBefore(typeof(Unity.Physics.Systems.PhysicsSolveAndIntegrateGroup))]
[CreateBefore(typeof(Unity.Physics.Systems.PhysicsCreateContactsGroup))]
[CreateBefore(typeof(Unity.Physics.Systems.PhysicsCreateBodyPairsGroup))]
[CreateBefore(typeof(Unity.Physics.Systems.PhysicsCreateJacobiansGroup))]
[CreateBefore(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct PhysicsSimulationPickerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1568664099_0;
    EntityQuery __query_1568664099_1;
    
    // unmanaged system, skipped generating example queries

}
