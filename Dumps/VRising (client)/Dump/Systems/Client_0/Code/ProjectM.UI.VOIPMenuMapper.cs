using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VOIPMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery __query_2042774401_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.VOIPMenu>(),
            },
        });
        
        __query_2042774401_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.VOIPMenu>(),
            },
        });
        
    }
    

}
