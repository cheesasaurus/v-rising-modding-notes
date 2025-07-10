using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StablesSystem_ClientEvents : SystemBase
{
    EntityQuery _BindMountEventQuery;
    EntityQuery _UnlockPerkEventQuery;
    EntityQuery __query_1751579397_0;
    EntityQuery __query_1751579397_1;
    EntityQuery __query_1751579397_2;
    EntityQuery __query_1751579397_3;
    EntityQuery __query_1751579397_4;
    EntityQuery __query_1751579397_5;
    EntityQuery __query_1751579397_6;
    EntityQuery __query_1751579397_7;
    EntityQuery __query_1751579397_8;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _BindMountEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.StablesEvents.BindMountIfEmpty>(),
            },
        });
        
        _UnlockPerkEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.StablesEvents.UnlockPerk>(),
            },
        });
        
        __query_1751579397_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.StablesEvents.BindMountIfEmpty>(),
            },
        });
        
        __query_1751579397_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.StablesEvents.UnlockPerk>(),
            },
        });
        
        __query_1751579397_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CollisionDetectionSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UtcTicksSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1751579397_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
