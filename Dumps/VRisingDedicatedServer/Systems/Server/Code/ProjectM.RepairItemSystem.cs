using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RepairItemSystem : SystemBase
{
    EntityQuery _RepairItemEventQuery;
    EntityQuery _RepairEquippedItemEventQuery;
    EntityQuery __query_1831453087_0;
    EntityQuery __query_1831453087_1;
    EntityQuery __query_1831453087_2;
    EntityQuery __query_1831453087_3;
    EntityQuery __query_1831453087_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RepairItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RepairItemEvent>(),
            },
        });
        
        _RepairEquippedItemEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RepairEquippedItemEvent>(),
            },
        });
        
        __query_1831453087_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RepairItemEvent>(),
            },
        });
        
        __query_1831453087_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RepairEquippedItemEvent>(),
            },
        });
        
        __query_1831453087_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1831453087_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1831453087_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
