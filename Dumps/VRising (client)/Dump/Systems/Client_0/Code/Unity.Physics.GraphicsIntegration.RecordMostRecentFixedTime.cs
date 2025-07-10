using Unity.Entities;

namespace Unity.Physics.GraphicsIntegration;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.ExportPhysicsWorld))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct RecordMostRecentFixedTime : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1921435724_0;
    EntityQuery __query_1921435724_1;
    
    // unmanaged system, skipped generating example queries

}
