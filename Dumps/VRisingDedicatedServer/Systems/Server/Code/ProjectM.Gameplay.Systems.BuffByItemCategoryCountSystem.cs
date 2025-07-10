using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuffByItemCategoryCountSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_342315205_0;
    EntityQuery __query_342315205_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BagEquipUpdateBuffByItemCategoryCountEvent>(),
            },
        });
        
        __query_342315205_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryChangedEvent>(),
            },
        });
        
        __query_342315205_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BagEquipUpdateBuffByItemCategoryCountEvent>(),
            },
        });
        
    }
    

}
