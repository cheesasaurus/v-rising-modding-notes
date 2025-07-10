using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ResetBuffAgeEventSystem_Server : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_401358877_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CreateResetBuffAgeNetworkEvent>(),
            },
        });
        
        __query_401358877_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CreateResetBuffAgeNetworkEvent>(),
            },
        });
        
    }
    

}
