using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AiMoveSystem_Client_ReactToDisabled : SystemBase
{
    EntityQuery __query_1334111506_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1334111506_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ToggleDisabledDueToTimeoutEvent>(),
            },
        });
        
    }
    

}
