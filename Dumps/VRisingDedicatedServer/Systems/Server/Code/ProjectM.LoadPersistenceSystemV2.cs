using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LoadPersistenceGroup))]
[UpdateBefore(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class LoadPersistenceSystemV2 : SystemBase
{
    EntityQuery _LoadedFromSaveDataQuery;
    EntityQuery _LoadedBehaviourTreesQuery;
    EntityQuery __query_1555833558_0;
    EntityQuery __query_1555833558_1;
    EntityQuery __query_1555833558_2;
    EntityQuery __query_1555833558_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LoadedFromSaveDataQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _LoadedBehaviourTreesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeInstance>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeBinding>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.BlackboardElement>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1555833558_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MegaStaticManager>(),
                ComponentType.ReadWrite<ProjectM.MegaStaticInstanceBuffer>(),
                ComponentType.ReadWrite<ProjectM.MegaStaticServerInstanceBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1555833558_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1555833558_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1555833558_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SubSceneRemapping>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
