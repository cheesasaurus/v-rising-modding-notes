using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProxyPrefabSystem : SystemBase
{
    EntityQuery _SpawnQuery;
    EntityQuery _RemoveModelQuery;
    EntityQuery _RemoveDisabledModelQuery;
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SpawnQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.ProxyPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InstantiatedProxyPrefab>(),
            },
        });
        
        _RemoveModelQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InstantiatedProxyPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProxyPrefab>(),
            },
        });
        
        _RemoveDisabledModelQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProxyPrefab>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InstantiatedProxyPrefab>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.ProxyPrefabIndex>(),
            },
        });
        
    }
    

}
