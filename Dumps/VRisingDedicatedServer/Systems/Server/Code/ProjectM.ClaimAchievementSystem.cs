using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClaimAchievementSystem : SystemBase
{
    EntityQuery _ForceClaimQuery;
    EntityQuery _ClaimEventQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ForceClaimQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ForceClaimAchievement_Debug>(),
            },
        });
        
        _ClaimEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ClaimAchievementEvent>(),
            },
        });
        
    }
    

}
