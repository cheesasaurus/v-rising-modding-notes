using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.CharacterSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnCharacterSystem : SystemBase
{
    EntityQuery _SpawnCharacterQuery;
    EntityQuery _TerrainQuery;
    EntityQuery __query_662302358_0;
    EntityQuery __query_662302358_1;
    EntityQuery __query_662302358_2;
    EntityQuery __query_662302358_3;
    EntityQuery __query_662302358_4;
    EntityQuery __query_662302358_5;
    EntityQuery __query_662302358_6;
    EntityQuery __query_662302358_7;
    EntityQuery __query_662302358_8;
    EntityQuery __query_662302358_9;
    EntityQuery __query_662302358_10;
    EntityQuery __query_662302358_11;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SpawnCharacterQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnCharacter>(),
            },
        });
        
        _TerrainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainTag>(),
            },
        });
        
        __query_662302358_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnCharacter>(),
            },
        });
        
        __query_662302358_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodUnit>(),
                ComponentType.ReadOnly<ProjectM.UnitLevel>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_662302358_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Passive>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_662302358_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ResearchStation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.ResearchBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_662302358_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationTrack_Shared>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        __query_662302358_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.QuickStartup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_662302358_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.AchievementCollectionBuffer>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
