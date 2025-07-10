using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.StartSimulationNetworkGroup))]
[UpdateAfter(typeof(ProjectM.ServerBootstrapSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class UserConnectionChangedEventSystem : SystemBase
{
    EntityQuery _NewQuery;
    EntityQuery _OldQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NewQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _OldQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
            },
        });
        
    }
    

}
