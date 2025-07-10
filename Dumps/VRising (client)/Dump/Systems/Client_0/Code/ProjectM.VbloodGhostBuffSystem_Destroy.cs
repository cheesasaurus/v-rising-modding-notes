using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VbloodGhostBuffSystem_Destroy : SystemBase
{
    EntityQuery __query_1898401317_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1898401317_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VbloodGhostBuff_Client>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
