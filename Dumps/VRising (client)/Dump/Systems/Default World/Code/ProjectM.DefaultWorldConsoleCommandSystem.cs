using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
public class DefaultWorldConsoleCommandSystem : ProjectM.ConsoleCommandSystem
{
    EntityQuery __query_238250386_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_238250386_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DisableUseFastQueries>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
