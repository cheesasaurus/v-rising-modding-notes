using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SendAlliedUserInfoOnChangedTeamEventSystem : SystemBase
{
    EntityQuery _ChangedTeamQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ChangedTeamQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChangedTeamEvent>(),
            },
        });
        
    }
    

}
