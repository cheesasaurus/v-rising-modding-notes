using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class DragAndDropViewMapperSystem : SystemBase
{
    EntityQuery __query_1826119471_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1826119471_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
