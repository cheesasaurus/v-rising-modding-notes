using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GallopBuffSystem_Server : SystemBase
{
    EntityQuery __query_1211623210_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1211623210_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.GallopBuff>(),
            },
        });
        
    }
    

}
