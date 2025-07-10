using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class LeftFarbaneAchievementSystem : SystemBase
{
    EntityQuery _RegionChangedEventQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegionChangedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegionChangedEvent>(),
            },
        });
        
    }
    

}
