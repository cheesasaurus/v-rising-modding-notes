using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
[UpdateBefore(typeof(ProjectM.StartSimulationNetworkGroup))]
[UpdateAfter(typeof(ProjectM.StartSimulationGroupBarrier))]
public class TileCollisionHistorySystem_Base : SystemBase
{
    EntityQuery __query_1019329300_0;
    EntityQuery __query_1019329300_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1019329300_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.InputCommandDataProxy>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.Network.TileCollisionHistoryElement>(),
                ComponentType.ReadWrite<ProjectM.Network.TileGameplayHeightsHistoryElement>(),
                ComponentType.ReadWrite<ProjectM.Network.TileCollisionHistoryMetadataElement>(),
                ComponentType.ReadWrite<ProjectM.Network.TileDisabledCollisionHistoryElement>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_1019329300_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
