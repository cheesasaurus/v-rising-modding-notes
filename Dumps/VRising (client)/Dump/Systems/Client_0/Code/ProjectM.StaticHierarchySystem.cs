using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateAfter(typeof(Unity.Transforms.LocalToWorldSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StaticHierarchySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    
    // unmanaged system, skipped generating example queries

}
