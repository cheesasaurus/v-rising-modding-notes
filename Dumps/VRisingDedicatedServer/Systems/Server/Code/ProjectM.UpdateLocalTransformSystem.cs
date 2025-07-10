using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateBefore(typeof(Unity.Transforms.ParentSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateLocalTransformSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    
    // unmanaged system, skipped generating example queries

}
