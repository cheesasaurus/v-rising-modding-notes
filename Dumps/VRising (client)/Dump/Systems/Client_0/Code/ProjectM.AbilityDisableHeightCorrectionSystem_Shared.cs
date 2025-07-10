using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityDisableHeightCorrectionSystem_Shared : SystemBase
{
    EntityQuery __query_1175309148_0;
    EntityQuery __query_1175309148_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1175309148_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_1175309148_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastEndedEvent>(),
            },
        });
        
    }
    

}
