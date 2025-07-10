using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup), OrderFirst = true)]
public class UIDataSystem : SystemBase
{
    EntityQuery __query_120078636_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_120078636_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
