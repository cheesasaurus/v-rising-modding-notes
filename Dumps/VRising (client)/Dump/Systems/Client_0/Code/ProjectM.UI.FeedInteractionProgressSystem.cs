using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FeedInteractionProgressSystem : SystemBase
{
    EntityQuery __query_1584242084_0;
    EntityQuery __query_1584242084_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1584242084_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_1584242084_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
