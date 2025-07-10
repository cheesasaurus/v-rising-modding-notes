using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GlobalWorldVFXInstanceSystem : SystemBase
{
    EntityQuery _AddedQuery;
    EntityQuery _UpdateQuery;
    EntityQuery _RemovedQuery;
    EntityQuery _LocalPlayerQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AddedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.WorldVFXSpawn>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorldVFXSpawnManagerIndex>(),
            },
        });
        
        _UpdateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.WorldVFXSpawnManagerIndex>(),
                ComponentType.ReadWrite<ProjectM.WorldVFXSpawn>(),
            },
        });
        
        _RemovedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.WorldVFXSpawnManagerIndex>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorldVFXSpawn>(),
            },
        });
        
        _LocalPlayerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Controller>(),
                ComponentType.ReadWrite<ProjectM.Network.LocalUser>(),
            },
        });
        
    }
    

}
