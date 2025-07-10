using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class WorldLoadingManagerSystem : SystemBase
{
    EntityQuery _ChunksLoadingQuery;
    EntityQuery __query_1918895966_0;
    EntityQuery __query_1918895966_1;
    EntityQuery __query_1918895966_2;
    EntityQuery __query_1918895966_3;
    EntityQuery __query_1918895966_4;
    EntityQuery __query_1918895966_5;
    EntityQuery __query_1918895966_6;
    EntityQuery __query_1918895966_7;
    EntityQuery __query_1918895966_8;
    EntityQuery __query_1918895966_9;
    EntityQuery __query_1918895966_10;
    EntityQuery __query_1918895966_11;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        // Error processing _ChunksLoadingQuery
        // 
        // Il2CppInterop.Runtime.Il2CppException: System.NullReferenceException: Object reference not set to an instance of an object.
        //  --- BEGIN IL2CPP STACK TRACE ---
        //  System.NullReferenceException: Object reference not set to an instance of an object.
        //    at Unity.Entities.EntityQuery.get_IsCacheValid () [0x00000] in <00000000000000000000000000000000>:0 
        //  --- END IL2CPP STACK TRACE ---
        //  
        //     at Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(IntPtr returnedException) in C:\Work\-\VRisingBepInExBuild\Il2CppInterop\Il2CppInterop.Runtime\Il2CppException.cs:line 36
        //     at Unity.Entities.EntityQuery.get_IsCacheValid()
        //     at cheesasaurus.VRisingMods.SystemsDumper.CodeGeneration.EcsSystemCodeGenerator.GenerateEntityQueryExampleInitializationLines(NamedEntityQuery namedQuery)
        
        
        __query_1918895966_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.TravelBuff>(),
            },
        });
        
        __query_1918895966_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.TeleportBuff>(),
            },
        });
        
        __query_1918895966_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkLoader>(),
            },
        });
        
        __query_1918895966_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_1918895966_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnCharacter>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1918895966_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadata>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.ProcessedMetadataTag>(),
            },
        });
        
        __query_1918895966_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.LoadTerrainChunkRequest>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.SceneTag>(),
            },
        });
        
        __query_1918895966_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChunkPortal>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_1918895966_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1918895966_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1918895966_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1918895966_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
