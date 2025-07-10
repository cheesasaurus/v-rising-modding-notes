using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.DealDamageSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StatChangeMutationSystem : SystemBase
{
    EntityQuery _StatChangeEventQuery;
    EntityQuery _RegisterListenerQuery;
    EntityQuery _UnregisterListenerQuery;
    EntityQuery _NullifyDamageQuery;
    EntityQuery _LastStrikeQuery;
    EntityQuery _FirstStrikeQuery;
    EntityQuery _IncreaseMountAttackQuery;
    EntityQuery __query_1145359205_0;
    EntityQuery __query_1145359205_1;
    EntityQuery __query_1145359205_2;
    EntityQuery __query_1145359205_3;
    EntityQuery __query_1145359205_4;
    EntityQuery __query_1145359205_5;
    EntityQuery __query_1145359205_6;
    EntityQuery __query_1145359205_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StatChangeEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StatChangeEvent>(),
            },
        });
        
        _RegisterListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StatChangeListener>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.StatChangeMutationSystem.RegisteredListener>(),
            },
        });
        
        _UnregisterListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.StatChangeMutationSystem.RegisteredListener>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StatChangeListener>(),
            },
        });
        
        _NullifyDamageQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_Brute_NulifyAndEmpower>(),
            },
        });
        
        _LastStrikeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_LastStrike>(),
            },
        });
        
        _FirstStrikeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_FirstStrike>(),
            },
        });
        
        _IncreaseMountAttackQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_Rogue_MountDamageBonus>(),
            },
        });
        
        __query_1145359205_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.StatChangeEvent>(),
                ComponentType.ReadOnly<ProjectM.StatChangeEventCallback>(),
            },
        });
        
        __query_1145359205_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_Brute_NulifyAndEmpower>(),
            },
        });
        
        __query_1145359205_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.StatChangeEvent>(),
            },
        });
        
        __query_1145359205_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_LastStrike>(),
            },
        });
        
        __query_1145359205_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_FirstStrike>(),
            },
        });
        
        __query_1145359205_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.BloodBuffScript_Rogue_MountDamageBonus>(),
            },
        });
        
        __query_1145359205_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1145359205_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
