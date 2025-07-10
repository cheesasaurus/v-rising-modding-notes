using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroySpawnChainChildrenOnDestroySystem : SystemBase
{
    EntityQuery __query_823274541_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_823274541_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SpawnChainData.ActiveChildElement>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
