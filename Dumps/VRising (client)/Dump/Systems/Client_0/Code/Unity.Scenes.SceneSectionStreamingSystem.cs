using Unity.Entities;

namespace Unity.Scenes;


[UpdateInGroup(typeof(Unity.Scenes.SceneSystemGroup))]
[UpdateAfter(typeof(Unity.Scenes.ResolveSceneReferenceSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SceneSectionStreamingSystem : SystemBase
{
    EntityQuery m_PendingStreamRequests;
    EntityQuery m_UnloadStreamRequests;
    EntityQuery m_NestedScenesPending;
    EntityQuery m_PublicRefFilter;
    EntityQuery m_SectionData;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_PendingStreamRequests = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.SceneSectionData>(),
                ComponentType.ReadWrite<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadWrite<Unity.Scenes.ResolvedSectionPath>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.SceneSectionStreamingSystem.StreamingState>(),
                ComponentType.ReadOnly<Unity.Scenes.DisableSceneResolveAndLoad>(),
            },
        });
        
        m_UnloadStreamRequests = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.SceneEntityReference>(),
                ComponentType.ReadOnly<Unity.Entities.SceneSectionData>(),
                ComponentType.ReadWrite<Unity.Scenes.SceneSectionStreamingSystem.StreamingState>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadOnly<Unity.Scenes.DisableSceneResolveAndLoad>(),
            },
        });
        
        m_NestedScenesPending = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadWrite<Unity.Entities.SceneTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.SceneSectionStreamingSystem.StreamingState>(),
                ComponentType.ReadOnly<Unity.Scenes.DisableSceneResolveAndLoad>(),
            },
        });
        
        m_PublicRefFilter = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Scenes.PublicEntityRef>(),
                ComponentType.ReadWrite<Unity.Entities.SceneTag>(),
            },
        });
        
        m_SectionData = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Scenes.SceneEntityReference>(),
                ComponentType.ReadWrite<Unity.Entities.SceneSectionData>(),
            },
        });
        
    }
    

}
