using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateAfter(typeof(Unity.Physics.Systems.ExportPhysicsWorld))]
public class AfterPhysicsSystemGroup : ComponentSystemGroup
{

}
