using Unity.Entities;

namespace Unity.Physics.GraphicsIntegration;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateBefore(typeof(Unity.Transforms.LocalToWorldSystem))]
public struct SmoothRigidBodiesGraphicalMotion : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SmoothedDynamicBodiesQuery_k__BackingField;
    EntityQuery SmoothedDynamicBodiesQuery;
    
    // unmanaged system, skipped generating example queries

}
