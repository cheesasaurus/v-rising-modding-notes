using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class WeaponLevelSystem_Spawn : SystemBase
{
    EntityQuery __query_1111682356_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1111682356_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.WeaponLevel>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
