using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TraderSpawnSystem : SystemBase
{
    EntityQuery __query_178718740_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_178718740_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Trader>(),
                ComponentType.ReadOnly<ProjectM.TraderCollectionGenerator>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
