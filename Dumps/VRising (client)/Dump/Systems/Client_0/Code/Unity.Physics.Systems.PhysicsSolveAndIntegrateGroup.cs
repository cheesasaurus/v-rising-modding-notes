using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSimulationGroup))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsCreateJacobiansGroup))]
public class PhysicsSolveAndIntegrateGroup : ComponentSystemGroup
{

}
