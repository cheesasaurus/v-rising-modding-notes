using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HitCastColliderSystem_OnSpawn : SystemBase
{
    EntityQuery __query_911162732_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_911162732_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<ProjectM.HitTrigger>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast.CollisionCastOnSpawn>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
