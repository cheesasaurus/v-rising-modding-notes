using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
public class InputActionSystem : SystemBase
{
    EntityQuery __query_1716268020_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1716268020_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InputActionsDisabled>(),
            },
        });
        
    }
    

}
