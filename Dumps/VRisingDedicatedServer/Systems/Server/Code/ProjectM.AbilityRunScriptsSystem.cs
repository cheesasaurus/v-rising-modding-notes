using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactToCastFinishGroup))]
public class AbilityRunScriptsSystem : SystemBase
{
    EntityQuery _RunScriptOnCastStartedQuery;
    EntityQuery _RunScriptOnCastUpdateQuery;
    EntityQuery _RunScriptOnPreCastFinishedQuery;
    EntityQuery _RunScriptOnPreCastEndedQuery;
    EntityQuery _RunScriptOnPostCastFinishedQuery;
    EntityQuery _RunScriptOnPostCastEndedQuery;
    EntityQuery _RunScriptOnCastEndedQuery;
    EntityQuery _RunScriptOnInterruptedQuery;
    EntityQuery _OnCastStartedQuery;
    EntityQuery _OnPreCastFinishedQuery;
    EntityQuery _OnPreCastEndedQuery;
    EntityQuery _OnPostCastFinishedQuery;
    EntityQuery _OnPostCastEndedQuery;
    EntityQuery _OnCastEndedQuery;
    EntityQuery _OnInterruptedQuery;
    EntityQuery __query_2147175953_0;
    EntityQuery __query_2147175953_1;
    EntityQuery __query_2147175953_2;
    EntityQuery __query_2147175953_3;
    EntityQuery __query_2147175953_4;
    EntityQuery __query_2147175953_5;
    EntityQuery __query_2147175953_6;
    EntityQuery __query_2147175953_7;
    EntityQuery __query_2147175953_8;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RunScriptOnCastStartedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnCastStarted>(),
            },
        });
        
        _RunScriptOnCastUpdateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnCastUpdate>(),
            },
        });
        
        _RunScriptOnPreCastFinishedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnPreCastFinished>(),
            },
        });
        
        _RunScriptOnPreCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnPreCastEnded>(),
            },
        });
        
        _RunScriptOnPostCastFinishedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnPostCastFinished>(),
            },
        });
        
        _RunScriptOnPostCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnPostCastEnded>(),
            },
        });
        
        _RunScriptOnCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnCastEnded>(),
            },
        });
        
        _RunScriptOnInterruptedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RunScriptOnInterrupted>(),
            },
        });
        
        _OnCastStartedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        _OnPreCastFinishedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        _OnPreCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastEndedEvent>(),
            },
        });
        
        _OnPostCastFinishedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPostCastFinishedEvent>(),
            },
        });
        
        _OnPostCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPostCastEndedEvent>(),
            },
        });
        
        _OnCastEndedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastEndedEvent>(),
            },
        });
        
        _OnInterruptedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInterruptedEvent>(),
            },
        });
        
        __query_2147175953_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_2147175953_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        __query_2147175953_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastEndedEvent>(),
            },
        });
        
        __query_2147175953_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPostCastFinishedEvent>(),
            },
        });
        
        __query_2147175953_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPostCastEndedEvent>(),
            },
        });
        
        __query_2147175953_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastEndedEvent>(),
            },
        });
        
        __query_2147175953_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInterruptedEvent>(),
            },
        });
        
        __query_2147175953_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataInitializedSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2147175953_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurrentCastsSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
