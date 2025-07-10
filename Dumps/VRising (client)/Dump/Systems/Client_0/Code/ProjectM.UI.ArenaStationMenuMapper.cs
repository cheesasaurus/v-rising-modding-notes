using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ArenaStationMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _InitQuery;
    EntityQuery __query_2046735904_0;
    EntityQuery __query_2046735904_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InitQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaStationMenu.InitData>(),
            },
        });
        
        __query_2046735904_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaStationMenu.InitData>(),
            },
        });
        
        __query_2046735904_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.ArenaStationMenu>(),
            },
        });
        
    }
    

}
