using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryStartItemsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_892640883_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<ProjectM.InventoryStartItems>(),
            },
        });
        
        __query_892640883_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
                ComponentType.ReadOnly<ProjectM.InventoryStartItems>(),
            },
        });
        
    }
    

}
