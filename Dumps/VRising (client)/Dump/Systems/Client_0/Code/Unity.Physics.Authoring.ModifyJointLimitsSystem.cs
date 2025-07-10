using Unity.Entities;

namespace Unity.Physics.Authoring;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyJointLimitsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2023911761_0;
    
    // unmanaged system, skipped generating example queries

}
