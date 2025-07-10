using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.ExportPhysicsWorld))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public class PhysicsSimulationGroup : ComponentSystemGroup
{

}
