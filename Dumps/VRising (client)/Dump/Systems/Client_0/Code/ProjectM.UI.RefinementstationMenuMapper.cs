using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RefinementstationMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _GetItemDatasQuery;
    EntityQuery __query_819857818_0;
    EntityQuery __query_819857818_1;
    EntityQuery __query_819857818_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.RefinementstationMenu>(),
            },
        });
        
        _GetItemDatasQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ItemData>(),
                ComponentType.ReadWrite<Unity.Entities.Prefab>(),
            },
        });
        
        __query_819857818_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.RefinementstationMenu.InitData>(),
            },
        });
        
        __query_819857818_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.RefinementstationMenu>(),
            },
        });
        
        __query_819857818_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.HideInteractHUDGamepad>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
