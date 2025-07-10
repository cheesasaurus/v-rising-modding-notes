using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class KnockbackSystemSpawn : SystemBase
{
    EntityQuery __query_1729431709_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1729431709_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadWrite<ProjectM.Knockback>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
