using Unity.Entities;

namespace ProjectM;


public class AttachParentIdSystem : SystemBase
{
    EntityQuery __query_1229206112_0;
    EntityQuery __query_1229206112_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1229206112_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AttachParentIdData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1229206112_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AttachParentIdData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
