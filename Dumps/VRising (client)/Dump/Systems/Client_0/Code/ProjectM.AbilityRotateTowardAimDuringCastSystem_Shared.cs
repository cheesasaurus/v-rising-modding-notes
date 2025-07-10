using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityMoveGroup))]
[UpdateAfter(typeof(ProjectM.AbilityCast_SetupStartValues_Shared))]
[UpdateAfter(typeof(ProjectM.AbilityModifyMovementDuringCastSystem_Shared))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityRotateTowardAimDuringCastSystem_Shared : SystemBase
{
    EntityQuery __query_335314581_0;
    EntityQuery __query_335314581_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_335314581_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_335314581_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RotateTowardsAimDirectionDuringCastActive>(),
            },
        });
        
    }
    

}
