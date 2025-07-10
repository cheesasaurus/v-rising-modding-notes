using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DeathMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _RequiredQuery;
    EntityQuery __query_642674229_0;
    EntityQuery __query_642674229_1;
    EntityQuery __query_642674229_2;
    EntityQuery __query_642674229_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RequiredQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.DeathMenu>(),
            },
        });
        
        __query_642674229_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.DeathMenu>(),
            },
        });
        
        __query_642674229_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconData>(),
                ComponentType.ReadOnly<ProjectM.SpawnLocationSelector>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
        });
        
        __query_642674229_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.DeathMenu>(),
            },
        });
        
        __query_642674229_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ChatInputFocused>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
