using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InitializeYieldResourcesSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1400280591_0;
    EntityQuery __query_1400280591_1;
    EntityQuery __query_1400280591_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.YieldResourcesOnDamageTaken>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1400280591_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.YieldResourcesOnDamageTaken>(),
                ComponentType.ReadOnly<ProjectM.Shared.DropTableBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1400280591_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1400280591_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
