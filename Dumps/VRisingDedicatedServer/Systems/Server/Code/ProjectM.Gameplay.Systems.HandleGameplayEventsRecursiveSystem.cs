using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateBefore(typeof(ProjectM.StatChangeGroup))]
[UpdateAfter(typeof(ProjectM.SpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleGameplayEventsRecursiveSystem : SystemBase
{
    EntityQuery __query_615536537_0;
    EntityQuery __query_615536537_1;
    EntityQuery __query_615536537_2;
    EntityQuery __query_615536537_3;
    EntityQuery __query_615536537_4;
    EntityQuery __query_615536537_5;
    EntityQuery __query_615536537_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_615536537_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_Brute_HealthRegenBonus>(),
            },
        });
        
        __query_615536537_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615536537_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.KnockbackAssetsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615536537_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BlinkSystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615536537_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615536537_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615536537_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
