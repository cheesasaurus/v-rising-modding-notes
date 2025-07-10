using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class ActionBarParentMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_100427749_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_100427749_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
        });
        
    }
    

}
