using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportationRequestSystem : SystemBase
{
    EntityQuery _TeleportRequestQuery;
    EntityQuery __query_816085233_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _TeleportRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TeleportationRequest>(),
            },
        });
        
        __query_816085233_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TeleportationRequest>(),
            },
        });
        
    }
    

}
