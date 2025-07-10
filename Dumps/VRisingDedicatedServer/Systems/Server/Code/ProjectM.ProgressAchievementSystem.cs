using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProgressAchievementSystem : SystemBase
{
    EntityQuery _SubAchievementQuery;
    EntityQuery _ParentAchievementQuery;
    EntityQuery _Query;
    EntityQuery __query_342548256_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SubAchievementQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AchievementSubTaskData>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _ParentAchievementQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AchievementData>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.AchievementSubTaskEntry>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
        });
        
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProgressAchievementEventV2>(),
            },
        });
        
        __query_342548256_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ProgressAchievementEventV2>(),
            },
        });
        
    }
    

}
