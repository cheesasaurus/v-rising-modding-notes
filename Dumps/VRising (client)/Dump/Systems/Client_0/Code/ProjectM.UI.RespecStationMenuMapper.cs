using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RespecStationMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery __query_1959399070_0;
    EntityQuery __query_1959399070_1;
    EntityQuery __query_1959399070_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.RespecStationMenu>(),
            },
        });
        
        __query_1959399070_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.RespecStationMenu.InitData>(),
            },
        });
        
        __query_1959399070_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.RespecStationMenu>(),
            },
        });
        
        __query_1959399070_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
