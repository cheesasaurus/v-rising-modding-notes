using Unity.Entities;

namespace Unity.Transforms;


[UpdateInGroup(typeof(Unity.Transforms.TransformSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ParentSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_NewParentsQuery;
    EntityQuery m_RemovedParentsQuery;
    EntityQuery m_ExistingParentsQuery;
    EntityQuery m_DeletedParentsQuery;
    
    // unmanaged system, skipped generating example queries

}
