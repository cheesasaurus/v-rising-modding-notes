using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FadeToBlackSystem_Client : SystemBase
{
    EntityQuery __query_1402653729_0;
    EntityQuery __query_1402653729_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1402653729_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.FadeToBlack>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FadeToBlack_Manual>(),
            },
        });
        
        __query_1402653729_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.FadeToBlack>(),
                ComponentType.ReadWrite<ProjectM.FadeToBlack_Manual>(),
            },
        });
        
    }
    

}
