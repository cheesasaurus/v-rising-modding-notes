using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleHeartRebuildMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _InitInteractQuery;
    EntityQuery _MenuQuery;
    EntityQuery __query_88718552_0;
    EntityQuery __query_88718552_1;
    EntityQuery __query_88718552_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InitInteractQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildMenu.InitData>(),
            },
        });
        
        _MenuQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CastleHeartRebuildMenu>(),
            },
        });
        
        __query_88718552_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CastleHeartRebuildMenu>(),
            },
        });
        
        __query_88718552_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.CastleHeartRebuildMenu.InitData>(),
            },
        });
        
        __query_88718552_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CastleHeartRebuildMenu>(),
            },
        });
        
    }
    

}
