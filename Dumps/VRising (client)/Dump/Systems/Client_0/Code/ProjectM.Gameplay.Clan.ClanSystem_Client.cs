using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClanSystem_Client : SystemBase
{
    EntityQuery _ClanInvitationResultQuery;
    EntityQuery _ClanInvitationResponseQuery;
    EntityQuery _LeaveClanResultResponseQuery;
    EntityQuery _AcceptClanInviteResultResponseQuery;
    EntityQuery _RoleChangedEventQuery;
    EntityQuery _MemberConnectionChangedEventQuery;
    EntityQuery _KickedEventQuery;
    EntityQuery _CreateClanResponseQuery;
    EntityQuery __query_369389886_0;
    EntityQuery __query_369389886_1;
    EntityQuery __query_369389886_2;
    EntityQuery __query_369389886_3;
    EntityQuery __query_369389886_4;
    EntityQuery __query_369389886_5;
    EntityQuery __query_369389886_6;
    EntityQuery __query_369389886_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ClanInvitationResultQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.ClanInvitationResult>(),
            },
        });
        
        _ClanInvitationResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.ClanInvitationResponse>(),
            },
        });
        
        _LeaveClanResultResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.LeaveClanResultResponse>(),
            },
        });
        
        _AcceptClanInviteResultResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.AcceptClanInviteResultResponse>(),
            },
        });
        
        _RoleChangedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.RoleChangedEvent>(),
            },
        });
        
        _MemberConnectionChangedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.MemberConnectionChangedEvent>(),
            },
        });
        
        _KickedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.KickedEvent>(),
            },
        });
        
        _CreateClanResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.CreateClan_Response>(),
            },
        });
        
        __query_369389886_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.ClanInvitationResult>(),
            },
        });
        
        __query_369389886_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.ClanInvitationResponse>(),
            },
        });
        
        __query_369389886_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.LeaveClanResultResponse>(),
            },
        });
        
        __query_369389886_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.AcceptClanInviteResultResponse>(),
            },
        });
        
        __query_369389886_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.RoleChangedEvent>(),
            },
        });
        
        __query_369389886_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.MemberConnectionChangedEvent>(),
            },
        });
        
        __query_369389886_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.KickedEvent>(),
            },
        });
        
        __query_369389886_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClanEvents_Server.CreateClan_Response>(),
            },
        });
        
    }
    

}
