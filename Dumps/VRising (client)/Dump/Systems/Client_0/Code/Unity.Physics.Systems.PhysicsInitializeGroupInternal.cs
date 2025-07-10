using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsInitializeGroup), OrderLast = true)]
public class PhysicsInitializeGroupInternal : ComponentSystemGroup
{

}
