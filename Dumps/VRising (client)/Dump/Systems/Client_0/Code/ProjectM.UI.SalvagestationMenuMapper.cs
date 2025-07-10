using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SalvagestationMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _GetItemDatasQuery;
    EntityQuery __query_1211370543_0;
    EntityQuery __query_1211370543_1;
    EntityQuery __query_1211370543_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.SalvagestationMenu>(),
            },
        });
        
        _GetItemDatasQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ItemData>(),
                ComponentType.ReadWrite<Unity.Entities.Prefab>(),
            },
        });
        
        __query_1211370543_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.SalvagestationMenu.InitData>(),
            },
        });
        
        __query_1211370543_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.SalvagestationMenu>(),
            },
        });
        
        __query_1211370543_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.HideInteractHUDGamepad>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
