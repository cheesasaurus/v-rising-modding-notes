using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateCastleHeartModelSystem : SystemBase
{
    EntityQuery __query_1288933780_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1288933780_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartVisuals>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleHeartModelSwapData>(),
            },
        });
        
    }
    

}
