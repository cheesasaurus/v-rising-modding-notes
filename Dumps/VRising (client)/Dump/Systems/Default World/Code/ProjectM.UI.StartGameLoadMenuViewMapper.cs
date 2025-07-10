using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StartGameLoadMenuViewMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1362486700_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.StartGameLoadMenuView>(),
            },
        });
        
        __query_1362486700_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.StartGameLoadMenuView>(),
            },
        });
        
    }
    

}
