using Unity.Entities;

namespace Unity.Physics.Authoring;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsDebugDisplayGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class PhysicsDebugDisplaySystem : Unity.Physics.Authoring.BasePhysicsDebugDisplaySystem
{

}
