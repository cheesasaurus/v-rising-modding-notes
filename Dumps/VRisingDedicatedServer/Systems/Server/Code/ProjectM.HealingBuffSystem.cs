using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HealingBuffSystem : SystemBase
{
    EntityQuery __query_674052621_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_674052621_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.HealingBuff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
            },
        });
        
    }
    

}
