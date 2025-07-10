using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleParentGroup))]
[UpdateBefore(typeof(ProjectM.ScheduleGroup))]
public class GarbageCollectArchetypeSystem : SystemBase
{
    EntityQuery _SceneTagQuery;
    EntityQuery _PrefabQuery;
    EntityQuery __query_1722191443_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SceneTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.SceneTag>(),
            },
        });
        
        _PrefabQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Entities.Prefab>(),
            },
        });
        
        __query_1722191443_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DisableUseFastQueries>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
