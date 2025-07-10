using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BonfireSystemUpdateCloud : SystemBase
{
    EntityQuery __query_1818188778_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1818188778_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Bonfire>(),
                ComponentType.ReadWrite<ProjectM.CloudCookie>(),
            },
        });
        
    }
    

}
