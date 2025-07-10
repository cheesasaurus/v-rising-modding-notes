using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PauseInfoSystem : SystemBase
{
    EntityQuery __query_1625774864_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1625774864_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
