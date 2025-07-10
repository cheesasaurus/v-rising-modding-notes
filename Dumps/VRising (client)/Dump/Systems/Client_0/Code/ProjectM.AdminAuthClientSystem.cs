using Unity.Entities;

namespace ProjectM;


public class AdminAuthClientSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_339168976_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_339168976_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
