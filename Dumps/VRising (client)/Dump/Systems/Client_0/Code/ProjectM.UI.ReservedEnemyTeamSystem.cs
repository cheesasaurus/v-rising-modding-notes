using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
[UpdateBefore(typeof(ProjectM.UI.SetCharacterHUDSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReservedEnemyTeamSystem : SystemBase
{
    EntityQuery __query_1574276004_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1574276004_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CheckOnScreen>(),
                ComponentType.ReadWrite<ProjectM.CharacterHUD>(),
                ComponentType.ReadOnly<ProjectM.Team>(),
            },
        });
        
    }
    

}
