using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class ReactToInventoryChangedSystem : SystemBase
{
    EntityQuery __query_2096870026_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2096870026_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryChangedEvent>(),
            },
        });
        
    }
    

}
