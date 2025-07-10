using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ControllerVibrationSystem : SystemBase
{
    EntityQuery __query_1415753376_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1415753376_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
    }
    

}
