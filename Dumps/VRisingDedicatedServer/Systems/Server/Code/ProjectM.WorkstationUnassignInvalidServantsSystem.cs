using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class WorkstationUnassignInvalidServantsSystem : SystemBase
{
    EntityQuery __query_1276241390_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1276241390_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.WorkstationAssignedServant>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
