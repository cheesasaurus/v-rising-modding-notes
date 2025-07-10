using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StablesMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _GetItemDatasQuery;
    EntityQuery __query_811637408_0;
    EntityQuery __query_811637408_1;
    EntityQuery __query_811637408_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.StablesMenu>(),
            },
        });
        
        _GetItemDatasQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ItemData>(),
                ComponentType.ReadWrite<Unity.Entities.Prefab>(),
            },
        });
        
        __query_811637408_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.StablesMenu.InitData>(),
            },
        });
        
        __query_811637408_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.StablesMenu>(),
            },
        });
        
        __query_811637408_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.HideInteractHUDGamepad>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
