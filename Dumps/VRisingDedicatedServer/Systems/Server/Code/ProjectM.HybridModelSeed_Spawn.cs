using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridModelSeed_Spawn : SystemBase
{
    EntityQuery __query_586292612_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_586292612_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelSeed>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
