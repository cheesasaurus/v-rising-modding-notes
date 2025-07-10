using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.CastleHeartEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHeartStateUpdateSystem : SystemBase
{
    EntityQuery _StateUpdateQuery;
    EntityQuery __query_1288933234_0;
    EntityQuery __query_1288933234_1;
    EntityQuery __query_1288933234_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StateUpdateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933234_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933234_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1288933234_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryManager>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
