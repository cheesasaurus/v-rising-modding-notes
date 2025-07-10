using Unity.Entities;

namespace ProjectM.Contest;


public class ContestIdManagerSystem : SystemBase, ProjectM.IPersistentSystemSerializer
{
    EntityQuery __query_1276816715_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1276816715_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestIdManager>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
