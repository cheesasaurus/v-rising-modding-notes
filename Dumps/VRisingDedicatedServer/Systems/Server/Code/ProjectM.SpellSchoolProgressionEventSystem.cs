using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellSchoolProgressionEventSystem : SystemBase
{
    EntityQuery _UnlockEventQuery;
    EntityQuery _ResetEventQuery;
    EntityQuery _UnlockPassiveEventQuery;
    EntityQuery _SharePassiveEventQuery;
    EntityQuery _ShareAllPassivesEventQuery;
    EntityQuery _LearnPassiveEventQuery;
    EntityQuery _LearnAllPassivesEventQuery;
    EntityQuery _DebugUnlockAllPassivesEventQuery;
    EntityQuery _DebugUnlockPassiveEventQuery;
    EntityQuery _DebugUnlockPassiveInStationEventQuery;
    EntityQuery __query_1453776405_0;
    EntityQuery __query_1453776405_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UnlockEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UnlockSpellSchoolProgression>(),
            },
        });
        
        _ResetEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ResetSpellSchoolProgression>(),
            },
        });
        
        _UnlockPassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UnlockSpellSchoolPassive>(),
            },
        });
        
        _SharePassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ShareSpellSchoolPassive>(),
            },
        });
        
        _ShareAllPassivesEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ShareAllSpellSchoolPassives>(),
            },
        });
        
        _LearnPassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.LearnSpellSchoolPassive>(),
            },
        });
        
        _LearnAllPassivesEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.LearnAllSpellSchoolPassives>(),
            },
        });
        
        _DebugUnlockAllPassivesEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UnlockAllSpellSchoolPassives>(),
            },
        });
        
        _DebugUnlockPassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DebugUnlockSpellSchoolPassive>(),
            },
        });
        
        _DebugUnlockPassiveInStationEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.DebugUnlockSpellSchoolPassiveInStation>(),
            },
        });
        
        __query_1453776405_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1453776405_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
