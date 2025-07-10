using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.CastleHeartEventSystem))]
public class CastleHeartDetectRaidSystem : SystemBase
{
    EntityQuery _RaidedCastleHeartQuery;
    EntityQuery __query_1288933432_0;
    EntityQuery __query_1288933432_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RaidedCastleHeartQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933432_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933432_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.CastleHeartsRaidState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
