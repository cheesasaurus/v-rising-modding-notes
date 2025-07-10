using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TrophySystem_Events_Server : SystemBase
{
    EntityQuery __query_1256893520_0;
    EntityQuery __query_1256893520_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1256893520_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegionChangedEvent>(),
            },
        });
        
        __query_1256893520_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemEquipEventData>(),
            },
        });
        
    }
    

}
