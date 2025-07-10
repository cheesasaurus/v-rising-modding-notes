using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReceiveSerializePersistenceFailedFeedbackEventSystem : SystemBase
{
    EntityQuery _FeedbackEventQuery;
    EntityQuery __query_1201126626_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _FeedbackEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SerializePersistenceFailedFeedbackEvent>(),
            },
        });
        
        __query_1201126626_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SerializePersistenceFailedFeedbackEvent>(),
            },
        });
        
    }
    

}
