using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UnitCompositionSpawnerDestroyTagChildrenSystem : SystemBase
{
    EntityQuery __query_707729463_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_707729463_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UnitCompositionActiveUnit>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
