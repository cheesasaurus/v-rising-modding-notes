using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SubScenePrefabSpawnerSystem : SystemBase, ProjectM.IDeclareTerrainChunkDependenciesOnLoad
{
    EntityQuery _NetworkedQuery;
    EntityQuery _MegaStaticManagerQuery;
    EntityQuery _SpawnChainQuery;
    EntityQuery _MicroPoiQuery;
    EntityQuery __query_199320026_0;
    EntityQuery __query_199320026_1;
    EntityQuery __query_199320026_2;
    EntityQuery __query_199320026_3;
    EntityQuery __query_199320026_4;
    EntityQuery __query_199320026_5;
    EntityQuery __query_199320026_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NetworkedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneNetworkedPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        _MegaStaticManagerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.SpawnMegaStaticManager>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        _SpawnChainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneSpawnChainPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        _MicroPoiQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneMicroPOIManager>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneNetworkedPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.SpawnMegaStaticManager>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneSpawnChainPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneMicroPOIManager>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneNetworkedPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneSpawnChainPrefab>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
        __query_199320026_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneMicroPOIManager>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
        });
        
    }
    

}
