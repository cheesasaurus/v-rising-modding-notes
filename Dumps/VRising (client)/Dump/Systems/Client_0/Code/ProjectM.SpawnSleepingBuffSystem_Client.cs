using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnSleepingBuffSystem_Client : SystemBase
{
    EntityQuery __query_1075095618_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1075095618_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpawnSleepingBuff>(),
            },
        });
        
    }
    

}
