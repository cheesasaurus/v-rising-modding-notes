using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class BacktraceSystem : SystemBase
{
    EntityQuery __query_1712042593_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1712042593_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
