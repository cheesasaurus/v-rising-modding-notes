using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.PhysicsSimulationGroup))]
public class PhysicsInitializeGroup : ComponentSystemGroup
{

}
