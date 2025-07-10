using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSimulationGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.PhysicsCreateJacobiansGroup))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsCreateBodyPairsGroup))]
public class PhysicsCreateContactsGroup : ComponentSystemGroup
{

}
