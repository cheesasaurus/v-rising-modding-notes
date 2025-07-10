using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ForgeSystem_Events : SystemBase
{
    EntityQuery _InsertItemEventQuery;
    EntityQuery _RemoveItemEventQuery;
    EntityQuery _ClaimItemEventQuery;
    EntityQuery _RepairItemEventQuery;
    EntityQuery _CancelRepairEventQuery;
    EntityQuery __query_1536473672_0;
    EntityQuery __query_1536473672_1;
    EntityQuery __query_1536473672_2;
    EntityQuery __query_1536473672_3;
    EntityQuery __query_1536473672_4;
    EntityQuery __query_1536473672_5;
    EntityQuery __query_1536473672_6;
    EntityQuery __query_1536473672_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InsertItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.InsertItem>(),
            },
        });
        
        _RemoveItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.RemoveItem>(),
            },
        });
        
        _ClaimItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.ClaimItem>(),
            },
        });
        
        _RepairItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.StartRepair>(),
            },
        });
        
        _CancelRepairEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.CancelRepair>(),
            },
        });
        
        __query_1536473672_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.InsertItem>(),
            },
        });
        
        __query_1536473672_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.RemoveItem>(),
            },
        });
        
        __query_1536473672_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.ClaimItem>(),
            },
        });
        
        __query_1536473672_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.StartRepair>(),
            },
        });
        
        __query_1536473672_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.ForgeEvents.CancelRepair>(),
            },
        });
        
        __query_1536473672_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1536473672_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1536473672_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
