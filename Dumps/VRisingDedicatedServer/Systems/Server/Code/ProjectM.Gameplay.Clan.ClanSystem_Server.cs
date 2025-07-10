using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class ClanSystem_Server : SystemBase
{
    EntityQuery _InvitePlayerToClanQuery;
    EntityQuery _ClanInviteResponseQuery;
    EntityQuery _LeaveClanEventQuery;
    EntityQuery _ChangeRoleRequestQuery;
    EntityQuery _KickRequestQuery;
    EntityQuery _ExistingClanInvites;
    EntityQuery _CreateClanEventQuery;
    EntityQuery _EditClanEventQuery;
    EntityQuery _UserConnectionChangedEventQuery;
    EntityQuery __query_369389083_0;
    EntityQuery __query_369389083_1;
    EntityQuery __query_369389083_2;
    EntityQuery __query_369389083_3;
    EntityQuery __query_369389083_4;
    EntityQuery __query_369389083_5;
    EntityQuery __query_369389083_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InvitePlayerToClanQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.InvitePlayerToClan>(),
            },
        });
        
        _ClanInviteResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.ClanInviteResponse>(),
            },
        });
        
        _LeaveClanEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.LeaveClan>(),
            },
        });
        
        _ChangeRoleRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.ChangeRole_Request>(),
            },
        });
        
        _KickRequestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.Kick_Request>(),
            },
        });
        
        _ExistingClanInvites = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Server>(),
            },
        });
        
        _CreateClanEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadWrite<ProjectM.Network.ClanEvents_Client.CreateClan_Request>(),
            },
        });
        
        _EditClanEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Client.EditClan>(),
            },
        });
        
        _UserConnectionChangedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
            },
        });
        
        __query_369389083_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Client.EditClan>(),
            },
        });
        
        __query_369389083_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Server>(),
            },
        });
        
        __query_369389083_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_369389083_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
            },
        });
        
        __query_369389083_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_369389083_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_369389083_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
