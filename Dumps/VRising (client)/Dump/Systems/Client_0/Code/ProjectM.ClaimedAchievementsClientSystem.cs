using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClaimedAchievementsClientSystem : SystemBase
{
    EntityQuery __query_2001856168_0;
    EntityQuery __query_2001856168_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2001856168_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.AchievementClaimedServerEvent>(),
            },
        });
        
        __query_2001856168_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClaimedAchievementsEvent>(),
            },
        });
        
    }
    

}
