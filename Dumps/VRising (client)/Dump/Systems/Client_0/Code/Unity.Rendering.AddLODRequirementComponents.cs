using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
public class AddLODRequirementComponents : SystemBase
{
    EntityQuery m_MissingRootLODRange;
    EntityQuery m_MissingRootLODWorldReferencePoint;
    EntityQuery m_MissingLODRange;
    EntityQuery m_MissingLODWorldReferencePoint;
    EntityQuery m_MissingLODGroupWorldReferencePoint;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_MissingRootLODRange = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RootLODRange>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_MissingRootLODWorldReferencePoint = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RootLODWorldReferencePoint>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_MissingLODRange = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.LODRange>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_MissingLODWorldReferencePoint = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.LODWorldReferencePoint>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_MissingLODGroupWorldReferencePoint = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODGroupComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.LODGroupWorldReferencePoint>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
