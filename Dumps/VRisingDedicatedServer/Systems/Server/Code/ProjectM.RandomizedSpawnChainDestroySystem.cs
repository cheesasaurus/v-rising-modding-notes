using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RandomizedSpawnChainDestroySystem : SystemBase
{
    EntityQuery __query_192737031_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_192737031_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RandomizedSpawnChain>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
