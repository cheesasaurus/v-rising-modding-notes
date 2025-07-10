using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class GameDataSubSceneSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery _SceneTagQuery;
    EntityQuery _SceneSectionQuery;
    EntityQuery _SceneTagWithSectionQuery;
    EntityQuery __query_1952729176_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.ResolvedSectionEntity>(),
                ComponentType.ReadOnly<ProjectM.GameDataSubSceneTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataSubSceneSystem.HasRemovedSceneTags>(),
                ComponentType.ReadOnly<ProjectM.WaitingForSceneLoad>(),
            },
        });
        
        _SceneTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.SceneTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _SceneSectionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.SceneSection>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _SceneTagWithSectionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.SceneTag>(),
                ComponentType.ReadWrite<Unity.Entities.SceneSection>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1952729176_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.ResolvedSectionEntity>(),
                ComponentType.ReadOnly<ProjectM.GameDataSubSceneTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataSubSceneSystem.HasRemovedSceneTags>(),
                ComponentType.ReadOnly<ProjectM.WaitingForSceneLoad>(),
            },
        });
        
    }
    

}
