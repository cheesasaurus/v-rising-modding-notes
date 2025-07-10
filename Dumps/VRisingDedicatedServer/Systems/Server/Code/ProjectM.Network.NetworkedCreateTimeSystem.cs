using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SpawnGroup))]
[UpdateAfter(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class NetworkedCreateTimeSystem : SystemBase
{
    EntityQuery __query_434759789_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_434759789_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.Networked>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
