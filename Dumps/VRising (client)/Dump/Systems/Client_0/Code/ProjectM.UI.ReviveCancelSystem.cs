using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReviveCancelSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1443162773_0;
    EntityQuery __query_1443162773_1;
    EntityQuery __query_1443162773_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1443162773_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_1443162773_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickAfterDelay_DataServer>(),
                ComponentType.ReadOnly<ProjectM.ReviveCancelBuff>(),
            },
        });
        
        __query_1443162773_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestDownedBuff>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
