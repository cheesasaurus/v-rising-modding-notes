using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHeartVisualStateSystem : SystemBase
{
    EntityQuery _VisualQuery;
    EntityQuery __query_1288933716_0;
    EntityQuery __query_1288933716_1;
    EntityQuery __query_1288933716_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _VisualQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleHeartVisuals>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
        });
        
        __query_1288933716_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleHeartVisuals>(),
                ComponentType.ReadOnly<ProjectM.RefinementstationRecipesBuffer>(),
            },
        });
        
        __query_1288933716_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1288933716_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
