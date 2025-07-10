using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ImprisonedBuffSystem : SystemBase
{
    EntityQuery __query_1231815368_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1231815368_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.ImprisonedBuff>(),
            },
        });
        
    }
    

}
