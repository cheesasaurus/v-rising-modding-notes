using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class LegDirectionSystem_Spawn : SystemBase
{
    EntityQuery __query_1821474721_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1821474721_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.LegDirection_Server>(),
                ComponentType.ReadWrite<ProjectM.Movement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
