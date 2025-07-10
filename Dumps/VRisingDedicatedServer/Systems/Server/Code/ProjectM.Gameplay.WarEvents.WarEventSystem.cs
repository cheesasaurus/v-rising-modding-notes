using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup))]
public class WarEventSystem : SystemBase, ProjectM.IPersistentSystemSerializer
{
    EntityQuery __query_303314001_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_303314001_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent>(),
            },
        });
        
    }
    

}
