using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class DebugViewBinderSystem : SystemBase
{
    EntityQuery _AllClientEntitiesDisabled;
    EntityQuery _AllClientEntitiesEnabled;
    EntityQuery _AllClientNetworkedEntities;
    EntityQuery __query_1062804861_0;
    EntityQuery __query_1062804861_1;
    EntityQuery __query_1062804861_2;
    EntityQuery __query_1062804861_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AllClientEntitiesDisabled = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _AllClientEntitiesEnabled = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _AllClientNetworkedEntities = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1062804861_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ClientReplayPlayerEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1062804861_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Replays.ClientReplayRecorderEnabled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1062804861_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1062804861_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
