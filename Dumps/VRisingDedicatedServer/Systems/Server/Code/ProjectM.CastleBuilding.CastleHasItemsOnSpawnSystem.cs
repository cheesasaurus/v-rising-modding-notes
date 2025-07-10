using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHasItemsOnSpawnSystem : SystemBase
{
    EntityQuery __query_60442477_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_60442477_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
            },
        });
        
    }
    

}
