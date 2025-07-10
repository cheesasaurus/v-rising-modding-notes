using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FusionForgeSystem_Events : SystemBase
{
    EntityQuery _InsertItemEventQuery;
    EntityQuery _RemoveItemEventQuery;
    EntityQuery _MergeSpellModsEventQuery;
    EntityQuery _CancelEventQuery;
    EntityQuery _ClaimEventQuery;
    EntityQuery __query_753054615_0;
    EntityQuery __query_753054615_1;
    EntityQuery __query_753054615_2;
    EntityQuery __query_753054615_3;
    EntityQuery __query_753054615_4;
    EntityQuery __query_753054615_5;
    EntityQuery __query_753054615_6;
    EntityQuery __query_753054615_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InsertItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.FusionForge_InsertItem>(),
            },
        });
        
        _RemoveItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.FusionForge_RemoveItem>(),
            },
        });
        
        _MergeSpellModsEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.MergeSpellMods>(),
            },
        });
        
        _CancelEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.CancelFusionForge>(),
            },
        });
        
        _ClaimEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.ClaimFusionForge>(),
            },
        });
        
        __query_753054615_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.FusionForge_InsertItem>(),
            },
        });
        
        __query_753054615_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.FusionForge_RemoveItem>(),
            },
        });
        
        __query_753054615_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.MergeSpellMods>(),
            },
        });
        
        __query_753054615_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.CancelFusionForge>(),
            },
        });
        
        __query_753054615_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.FusionForgeEvents.ClaimFusionForge>(),
            },
        });
        
        __query_753054615_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_753054615_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_753054615_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
