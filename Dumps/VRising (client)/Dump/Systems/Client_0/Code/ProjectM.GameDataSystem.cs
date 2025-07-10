using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.SetupServerSettings))]
[RequireMatchingQueriesForUpdateAttribute]
public class GameDataSystem : SystemBase
{
    EntityQuery __query_1748745749_0;
    EntityQuery __query_1748745749_1;
    EntityQuery __query_1748745749_2;
    EntityQuery __query_1748745749_3;
    EntityQuery __query_1748745749_4;
    EntityQuery __query_1748745749_5;
    EntityQuery __query_1748745749_6;
    EntityQuery __query_1748745749_7;
    EntityQuery __query_1748745749_8;
    EntityQuery __query_1748745749_9;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1748745749_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ItemData>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemDataDropGroup>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DropTableData>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RecipeData>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_1748745749_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorkstationRecipesBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_1748745749_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.BlueprintData>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StationBonusData>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1748745749_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
