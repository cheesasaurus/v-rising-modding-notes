using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class SetupServerSettings_InstancesLoaded : SystemBase
{
    EntityQuery _InstancesQuery;
    EntityQuery __query_1650171275_0;
    EntityQuery __query_1650171275_1;
    EntityQuery __query_1650171275_2;
    EntityQuery __query_1650171275_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InstancesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryItem>(),
                ComponentType.ReadOnly<ProjectM.ItemData>(),
                ComponentType.ReadOnly<ProjectM.Shared.Relic>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650171275_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650171275_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryItem>(),
                ComponentType.ReadOnly<ProjectM.ItemData>(),
                ComponentType.ReadOnly<ProjectM.Shared.Relic>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1650171275_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RemappedPrefabDataLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1650171275_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
