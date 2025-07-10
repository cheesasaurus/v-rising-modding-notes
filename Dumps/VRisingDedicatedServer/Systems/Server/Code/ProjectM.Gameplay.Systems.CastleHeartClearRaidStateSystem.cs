using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
public class CastleHeartClearRaidStateSystem : SystemBase
{
    EntityQuery _DestroyedCastleHeartQuery;
    EntityQuery __query_1288933498_0;
    EntityQuery __query_1288933498_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedCastleHeartQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933498_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933498_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.CastleHeartsRaidState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
