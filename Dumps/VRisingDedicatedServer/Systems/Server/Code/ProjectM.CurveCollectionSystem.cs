using Unity.Entities;

namespace ProjectM;


public class CurveCollectionSystem : SystemBase
{
    EntityQuery __query_1746688711_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1746688711_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
