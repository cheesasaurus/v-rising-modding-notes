using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UnitSpawnerstationSubMenuMapper : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_82596823_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UnitSpawnerstationSubMenu>(),
            },
        });
        
        __query_82596823_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UnitSpawnerstationSubMenu>(),
            },
        });
        
    }
    

}
