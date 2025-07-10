using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AdditionalInteractBuffComponentDestroySystem : SystemBase
{
    EntityQuery __query_343062795_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_343062795_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AdditionalInteractBuff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
