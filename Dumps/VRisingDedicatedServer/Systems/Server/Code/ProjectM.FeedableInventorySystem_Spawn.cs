using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FeedableInventorySystem_Spawn : SystemBase
{
    EntityQuery __query_1433501652_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1433501652_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.FeedableInventory>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
