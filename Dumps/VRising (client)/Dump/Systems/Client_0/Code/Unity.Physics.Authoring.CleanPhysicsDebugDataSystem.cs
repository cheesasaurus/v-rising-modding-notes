using Unity.Entities;

namespace Unity.Physics.Authoring;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsDebugDisplayGroup), OrderFirst = true)]
public struct CleanPhysicsDebugDataSystem : ISystem
{

}
