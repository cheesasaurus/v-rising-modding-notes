using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class RandomizedSpawnChainSpawnSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery _MainQuery2;
    EntityQuery __query_192736786_0;
    EntityQuery __query_192736786_1;
    EntityQuery __query_192736786_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RandomizedSpawnChain>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        _MainQuery2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RandomizedSpawnChainChild>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_192736786_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RandomizedSpawnChain>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_192736786_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RandomizedSpawnChainChild>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_192736786_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChunkDataRemappings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
