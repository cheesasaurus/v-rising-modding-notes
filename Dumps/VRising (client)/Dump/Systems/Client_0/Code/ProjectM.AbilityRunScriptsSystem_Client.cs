using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactToCastFinishGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityRunScriptsSystem_Client : SystemBase
{
    EntityQuery _RunScriptOnPreCastEndedQuery;
    EntityQuery __query_2147176445_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RunScriptOnPreCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnPreCastEnded>(),
            },
        });
        
        __query_2147176445_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastEndedEvent>(),
            },
        });
        
    }
    

}
