using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.UI.DurabilityUISystem))]
[UpdateAfter(typeof(ProjectM.UI.ClockHUDSystem))]
public class AlertsUISystem : SystemBase
{
    EntityQuery _WarEventGateQuery;
    EntityQuery __query_1484274500_0;
    EntityQuery __query_1484274500_1;
    EntityQuery __query_1484274500_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _WarEventGateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_Gate>(),
            },
        });
        
        __query_1484274500_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_NetworkedData>(),
            },
        });
        
        __query_1484274500_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1484274500_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
