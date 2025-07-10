using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateAfter(typeof(ProjectM.DestroyInFixed))]
public struct DestroySystem_Client : ISystem
{

}
