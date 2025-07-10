using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DisconnectSettingsSystem : SystemBase
{
    EntityQuery __query_235889473_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_235889473_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.DisconnectSunImmunityTimeTag>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
