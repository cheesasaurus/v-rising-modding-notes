using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PvPToggleChatSystem : SystemBase
{
    EntityQuery _ToggleEventsQuery;
    EntityQuery __query_675019342_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ToggleEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.PvPToggleEvent>(),
            },
        });
        
        __query_675019342_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.PvPToggleEvent>(),
            },
        });
        
    }
    

}
