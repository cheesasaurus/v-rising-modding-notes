using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientConsoleCommandSystem : ProjectM.GameplayConsoleCommandSystem
{
    EntityQuery __query_936739190_0;
    EntityQuery __query_936739190_1;
    EntityQuery __query_936739190_2;
    EntityQuery __query_936739190_3;
    EntityQuery __query_936739190_4;
    EntityQuery __query_936739190_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_936739190_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.CreateSequence>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_936739190_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceInstance>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.EventStateElement>(),
            },
        });
        
        __query_936739190_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
        });
        
        __query_936739190_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.PerformanceSummaryElement>(),
            },
        });
        
        __query_936739190_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ClanInviteRequest_Shared>(),
            },
        });
        
        __query_936739190_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
