using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.ReactToPlayerCharacterSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilitySpawnSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1690740297_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attach>(),
                ComponentType.ReadOnly<ProjectM.Network.SyncToUserBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityState>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupState>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot>(),
            },
        });
        
        __query_1690740297_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attach>(),
                ComponentType.ReadOnly<ProjectM.Network.SyncToUserBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityState>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupState>(),
                ComponentType.ReadOnly<ProjectM.AbilityGroupSlot>(),
            },
        });
        
    }
    

}
