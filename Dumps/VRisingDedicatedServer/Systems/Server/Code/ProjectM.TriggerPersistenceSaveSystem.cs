using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterDestroyGroup_Server))]
[UpdateBefore(typeof(ProjectM.PersistenceGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TriggerPersistenceSaveSystem : SystemBase
{
    EntityQuery _TriggerSaveAdminEvent;
    EntityQuery __query_597412366_0;
    EntityQuery __query_597412366_1;
    EntityQuery __query_597412366_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _TriggerSaveAdminEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.TriggerServerAutoSaveAdminEvent>(),
            },
        });
        
        __query_597412366_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SavePersistentDataEvent>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_597412366_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_597412366_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
