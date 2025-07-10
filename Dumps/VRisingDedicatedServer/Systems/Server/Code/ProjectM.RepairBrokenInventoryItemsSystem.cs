using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.AttachSystem_ReactToPersistenceLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public class RepairBrokenInventoryItemsSystem : SystemBase
{
    EntityQuery __query_1206340050_0;
    EntityQuery __query_1206340050_1;
    EntityQuery __query_1206340050_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1206340050_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InventoryBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1206340050_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Equipment>(),
                ComponentType.ReadWrite<ProjectM.AttachedBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1206340050_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServantEquipment>(),
                ComponentType.ReadWrite<ProjectM.AttachedBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
