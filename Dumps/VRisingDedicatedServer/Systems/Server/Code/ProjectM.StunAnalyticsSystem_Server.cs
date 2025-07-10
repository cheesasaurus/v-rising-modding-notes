using Unity.Entities;

namespace ProjectM;


public class StunAnalyticsSystem_Server : SystemBase
{
    EntityQuery __query_1762305004_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1762305004_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
    }
    

}
