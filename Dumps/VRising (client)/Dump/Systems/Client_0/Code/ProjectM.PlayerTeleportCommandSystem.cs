using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
public class PlayerTeleportCommandSystem : ProjectM.ConsoleCommandSystem
{
    EntityQuery _ChunkWaypointQuery;
    EntityQuery __query_1963497460_0;
    EntityQuery __query_1963497460_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ChunkWaypointQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ChunkWaypoint>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.Network.NetworkId>(),
            },
        });
        
        __query_1963497460_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CursorPosition>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1963497460_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MarkerGuidanceSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
