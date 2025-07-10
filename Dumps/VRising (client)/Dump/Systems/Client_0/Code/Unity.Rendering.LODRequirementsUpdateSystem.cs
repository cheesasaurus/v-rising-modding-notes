using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.UpdatePresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class LODRequirementsUpdateSystem : SystemBase
{
    EntityQuery m_UpdatedLODRanges;
    EntityQuery m_LODReferencePoints;
    EntityQuery m_LODGroupReferencePoints;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_UpdatedLODRanges = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.MeshLODComponent>(),
                ComponentType.ReadWrite<Unity.Rendering.RootLODRange>(),
                ComponentType.ReadWrite<Unity.Rendering.LODRange>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SkipLODRangeUpdate>(),
            },
        });
        
        m_LODReferencePoints = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODComponent>(),
                ComponentType.ReadWrite<Unity.Rendering.RootLODWorldReferencePoint>(),
                ComponentType.ReadWrite<Unity.Rendering.LODWorldReferencePoint>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SkipLODWorldReferencePointUpdate>(),
            },
        });
        
        m_LODGroupReferencePoints = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.MeshLODGroupComponent>(),
                ComponentType.ReadWrite<Unity.Rendering.LODGroupWorldReferencePoint>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SkipLODGroupWorldReferencePointUpdate>(),
            },
        });
        
    }
    

}
