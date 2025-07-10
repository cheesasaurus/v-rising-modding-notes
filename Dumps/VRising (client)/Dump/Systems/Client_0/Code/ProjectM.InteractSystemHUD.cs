using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class InteractSystemHUD : SystemBase
{
    EntityQuery _GoToHUDMenuQuery;
    EntityQuery __query_611024430_0;
    EntityQuery __query_611024430_1;
    EntityQuery __query_611024430_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _GoToHUDMenuQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.UI.GoToHUDMenu>(),
                ComponentType.ReadWrite<ProjectM.Network.NetworkId>(),
            },
        });
        
        __query_611024430_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Team>(),
                ComponentType.ReadOnly<ProjectM.ChunkWaypoint>(),
            },
        });
        
        __query_611024430_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadWrite<ProjectM.UI.GoToHUDMenu>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
        });
        
        __query_611024430_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
