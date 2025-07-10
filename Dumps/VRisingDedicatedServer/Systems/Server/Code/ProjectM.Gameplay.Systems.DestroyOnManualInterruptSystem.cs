using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyOnManualInterruptSystem : SystemBase
{
    EntityQuery __query_889772139_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_889772139_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DestroyOnManualInterrupt>(),
            },
        });
        
    }
    

}
