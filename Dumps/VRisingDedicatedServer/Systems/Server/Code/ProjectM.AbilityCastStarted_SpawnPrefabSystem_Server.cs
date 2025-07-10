using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactToCastStartGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityCastStarted_SpawnPrefabSystem_Server : SystemBase
{
    EntityQuery __query_577032100_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_577032100_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
    }
    

}
