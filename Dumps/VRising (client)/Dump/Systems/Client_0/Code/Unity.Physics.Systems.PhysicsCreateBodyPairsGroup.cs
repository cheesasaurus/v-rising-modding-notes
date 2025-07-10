using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSimulationGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.PhysicsCreateContactsGroup))]
public class PhysicsCreateBodyPairsGroup : ComponentSystemGroup
{

}
