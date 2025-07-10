using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SleepInsideSystem : SystemBase
{
    EntityQuery __query_904963989_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_904963989_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.SpawnSleepingBuff>(),
                ComponentType.ReadOnly<ProjectM.InsideBuff>(),
            },
        });
        
    }
    

}
