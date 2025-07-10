using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup))]
public class InputSingletonSystem : SystemBase
{
    EntityQuery __query_885490062_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_885490062_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InputSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
