using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterRecursiveSpawnDestroyGroup))]
public class BlinkSystems_Server : SystemBase
{
    EntityQuery __query_1958717933_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1958717933_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BlinkSystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
