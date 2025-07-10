using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.InputGroup))]
public class AimAssistSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_559637202_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_559637202_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
