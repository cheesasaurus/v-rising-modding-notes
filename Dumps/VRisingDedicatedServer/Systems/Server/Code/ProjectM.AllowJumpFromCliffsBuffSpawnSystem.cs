using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AllowJumpFromCliffsBuffSpawnSystem : SystemBase
{
    EntityQuery __query_754105110_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_754105110_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.AllowJumpFromCliffsBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
