using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class UICanvasSystem : SystemBase
{
    EntityQuery __query_1072822474_0;
    EntityQuery __query_1072822474_1;
    EntityQuery __query_1072822474_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1072822474_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.FadeToBlack>(),
            },
        });
        
        __query_1072822474_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.Script_EndGameCredits_Data>(),
            },
        });
        
        __query_1072822474_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.Script_EndGameCredits_Data>(),
            },
        });
        
    }
    

}
