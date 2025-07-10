using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
public class WorldLoadStartupTracker : SystemBase
{
    EntityQuery _SceneLoadRequestQuery;
    EntityQuery __query_1780669885_0;
    EntityQuery __query_1780669885_1;
    EntityQuery __query_1780669885_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SceneLoadRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RequestSceneLoaded>(),
            },
        });
        
        __query_1780669885_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1780669885_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataInitializedSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1780669885_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.WorldTypeSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
