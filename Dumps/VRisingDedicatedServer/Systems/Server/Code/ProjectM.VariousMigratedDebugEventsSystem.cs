using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class VariousMigratedDebugEventsSystem : SystemBase
{
    EntityQuery _SetTimeOfDayEventQuery;
    EntityQuery _ChangeDurabilityEventQuery;
    EntityQuery _ChangeHealthOfClosestToPositionEventQuery;
    EntityQuery _CompleteCurrentAchievementEventQuery;
    EntityQuery _RenamePlayerEventQuery;
    EntityQuery _GenerateBloodPotionEventQuery;
    EntityQuery _ConsumeBloodEventQuery;
    EntityQuery __query_615629718_0;
    EntityQuery __query_615629718_1;
    EntityQuery __query_615629718_2;
    EntityQuery __query_615629718_3;
    EntityQuery __query_615629718_4;
    EntityQuery __query_615629718_5;
    EntityQuery __query_615629718_6;
    EntityQuery __query_615629718_7;
    EntityQuery __query_615629718_8;
    EntityQuery __query_615629718_9;
    EntityQuery __query_615629718_10;
    EntityQuery __query_615629718_11;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SetTimeOfDayEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetTimeOfDayEvent>(),
            },
        });
        
        _ChangeDurabilityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeDurabilityDebugEvent>(),
            },
        });
        
        _ChangeHealthOfClosestToPositionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChangeHealthOfClosestToPositionDebugEvent>(),
            },
        });
        
        _CompleteCurrentAchievementEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.CompleteCurrentAchievementAdminEvent>(),
            },
        });
        
        _RenamePlayerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RenamePlayerEvent>(),
            },
        });
        
        _GenerateBloodPotionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.GenerateBloodPotionAdminEvent>(),
            },
        });
        
        _ConsumeBloodEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ConsumeBloodAdminEvent>(),
            },
        });
        
        __query_615629718_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DayNightCycle>(),
            },
        });
        
        __query_615629718_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerTime>(),
            },
        });
        
        __query_615629718_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VbloodGhostBuff_Shared>(),
                ComponentType.ReadWrite<ProjectM.Age>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_615629718_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.ActiveServantMission>(),
            },
        });
        
        __query_615629718_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServantCoffinstation>(),
            },
        });
        
        __query_615629718_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Stables_Server>(),
            },
        });
        
        __query_615629718_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_615629718_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_615629718_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconTargetEntity>(),
                ComponentType.ReadWrite<ProjectM.PlayerMapIcon>(),
            },
        });
        
        __query_615629718_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_615629718_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_615629718_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
