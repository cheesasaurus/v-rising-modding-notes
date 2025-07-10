using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CombatMusicSystem_Server : SystemBase
{
    EntityQuery __query_1806426269_0;
    EntityQuery __query_1806426269_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1806426269_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InverseAggroEvents.Added>(),
            },
        });
        
        __query_1806426269_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InverseAggroEvents.Removed>(),
            },
        });
        
    }
    

}
