using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RandomLifeTimeSystem_Spawn : SystemBase
{
    EntityQuery __query_1624508077_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1624508077_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<ProjectM.SpawnRandomLifeTime>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
