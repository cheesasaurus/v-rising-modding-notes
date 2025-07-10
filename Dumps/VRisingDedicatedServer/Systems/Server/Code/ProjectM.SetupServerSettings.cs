using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderFirst = true)]
[UpdateAfter(typeof(ProjectM.PrefabCollectionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetupServerSettings : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_1650170656_0;
    EntityQuery __query_1650170656_1;
    EntityQuery __query_1650170656_2;
    EntityQuery __query_1650170656_3;
    EntityQuery __query_1650170656_4;
    EntityQuery __query_1650170656_5;
    EntityQuery __query_1650170656_6;
    EntityQuery __query_1650170656_7;
    EntityQuery __query_1650170656_8;
    EntityQuery __query_1650170656_9;
    EntityQuery __query_1650170656_10;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650170656_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650170656_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650170656_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.LegendaryItemInstance>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.RecipeOutputBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadWrite<ProjectM.RecipeRequirementBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Shared.Durability>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Shared.Salvageable>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadWrite<ProjectM.TechItemRequirementBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.OutdatedPrefab>(),
            },
        });
        
        __query_1650170656_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
