using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ConsumeRevealedMapEventSystem : SystemBase
{
    EntityQuery _RevealedMapEventQuery;
    EntityQuery __query_1615387334_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RevealedMapEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RevealedMapEvent>(),
            },
        });
        
        __query_1615387334_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RevealedMapEvent>(),
            },
        });
        
    }
    

}
