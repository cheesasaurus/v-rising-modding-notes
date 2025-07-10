using Unity.Entities;

namespace Unity.Transforms;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateAfter(typeof(Unity.Transforms.ParentSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct LocalToWorldSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _rootsQuery;
    EntityQuery _parentsQuery;
    
    // unmanaged system, skipped generating example queries

}
