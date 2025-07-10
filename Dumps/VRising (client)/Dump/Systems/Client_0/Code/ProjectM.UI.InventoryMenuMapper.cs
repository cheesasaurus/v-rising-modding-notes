using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _GetItemDatasQuery;
    EntityQuery __query_1360274359_0;
    EntityQuery __query_1360274359_1;
    EntityQuery __query_1360274359_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.InventoryMenu>(),
            },
        });
        
        _GetItemDatasQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ItemData>(),
                ComponentType.ReadWrite<Unity.Entities.Prefab>(),
            },
        });
        
        __query_1360274359_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.InventoryMenu>(),
            },
        });
        
        __query_1360274359_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Mountable>(),
                ComponentType.ReadWrite<ProjectM.Team>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_1360274359_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.HideInteractHUDGamepad>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
