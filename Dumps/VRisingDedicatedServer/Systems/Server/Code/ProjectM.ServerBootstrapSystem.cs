using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationNetworkGroup))]
public class ServerBootstrapSystem : SystemBase, ProjectM.IPersistentSystemSerializer, Stunlock.Network.ISendPacketToClient
{
    EntityQuery __query_677018907_0;
    EntityQuery __query_677018907_1;
    EntityQuery __query_677018907_2;
    EntityQuery __query_677018907_3;
    EntityQuery __query_677018907_4;
    EntityQuery __query_677018907_5;
    EntityQuery __query_677018907_6;
    EntityQuery __query_677018907_7;
    EntityQuery __query_677018907_8;
    EntityQuery __query_677018907_9;
    EntityQuery __query_677018907_10;
    EntityQuery __query_677018907_11;
    EntityQuery __query_677018907_12;
    EntityQuery __query_677018907_13;
    EntityQuery __query_677018907_14;
    EntityQuery __query_677018907_15;
    EntityQuery __query_677018907_16;
    EntityQuery __query_677018907_17;
    EntityQuery __query_677018907_18;
    EntityQuery __query_677018907_19;
    EntityQuery __query_677018907_20;
    EntityQuery __query_677018907_21;
    EntityQuery __query_677018907_22;
    EntityQuery __query_677018907_23;
    EntityQuery __query_677018907_24;
    EntityQuery __query_677018907_25;
    EntityQuery __query_677018907_26;
    EntityQuery __query_677018907_27;
    EntityQuery __query_677018907_28;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_677018907_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityInput>(),
                ComponentType.ReadWrite<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_677018907_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_677018907_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegion>(),
            },
        });
        
        __query_677018907_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerritoryWorldRegion>(),
            },
        });
        
        __query_677018907_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
            },
        });
        
        __query_677018907_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUsers>(),
            },
        });
        
        __query_677018907_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUser>(),
            },
        });
        
        __query_677018907_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_677018907_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.SyncToUserBitMask>(),
                ComponentType.ReadOnly<ProjectM.Network.SyncToUserBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.UpToDateUserBitMask>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.SyncToUserBitMask>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SyncToUserBitMask>(),
                ComponentType.ReadOnly<ProjectM.Network.DestroyedEntity>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldZoneId>(),
            },
        });
        
        __query_677018907_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserOwner>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_677018907_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_18 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_19 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldAssetSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_20 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationsRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_21 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationCleanupSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_22 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_23 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_24 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_25 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_26 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetupNetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_27 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemKeyLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_677018907_28 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
