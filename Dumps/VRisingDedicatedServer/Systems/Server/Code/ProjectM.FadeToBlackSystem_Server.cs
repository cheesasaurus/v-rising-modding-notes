using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FadeToBlackSystem_Server : SystemBase
{
    EntityQuery __query_1402653780_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1402653780_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.FadeToBlack>(),
                ComponentType.ReadWrite<ProjectM.FadeToBlack_Manual>(),
            },
        });
        
    }
    

}
