using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ShowAiSystem : SystemBase
{
    EntityQuery _AiDebugTargetQuery;
    EntityQuery __query_122197692_0;
    EntityQuery __query_122197692_1;
    EntityQuery __query_122197692_2;
    EntityQuery __query_122197692_3;
    EntityQuery __query_122197692_4;
    EntityQuery __query_122197692_5;
    EntityQuery __query_122197692_6;
    EntityQuery __query_122197692_7;
    EntityQuery __query_122197692_8;
    EntityQuery __query_122197692_9;
    EntityQuery __query_122197692_10;
    EntityQuery __query_122197692_11;
    EntityQuery __query_122197692_12;
    EntityQuery __query_122197692_13;
    EntityQuery __query_122197692_14;
    EntityQuery __query_122197692_15;
    EntityQuery __query_122197692_16;
    EntityQuery __query_122197692_17;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AiDebugTargetQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.AiDebugTarget>(),
            },
        });
        
        __query_122197692_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapCollision>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.AiDebugDraw>(),
                ComponentType.ReadWrite<ProjectM.Pathfinding.PathBuffer>(),
                ComponentType.ReadWrite<ProjectM.Pathfinding.UnsmoothedPathBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MoveTowardsPositionBuff_PathElement>(),
            },
        });
        
        __query_122197692_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.GainAggroByVicinity>(),
                ComponentType.ReadOnly<ProjectM.AggroModifiers>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeState>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GainAlertByVicinity>(),
                ComponentType.ReadOnly<ProjectM.AlertModifiers>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeState>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.AggroBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AlertBuffer>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AiMove_Server>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Dead>(),
            },
        });
        
        __query_122197692_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PatrolState>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.FormationOffsetBuffer>(),
            },
        });
        
        __query_122197692_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WaypointTargetBufferEntry>(),
            },
        });
        
        __query_122197692_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MovePatrolState>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.FormationOffsetBuffer>(),
            },
        });
        
        __query_122197692_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_122197692_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AiPrioritization_State>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_122197692_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
            },
        });
        
        __query_122197692_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<ProjectM.IdleInteractionPointBuffer>(),
            },
        });
        
        __query_122197692_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ShowAi>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_122197692_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_122197692_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
