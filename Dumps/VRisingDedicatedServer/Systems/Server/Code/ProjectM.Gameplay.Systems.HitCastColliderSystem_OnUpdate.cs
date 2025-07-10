using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HitCastColliderSystem_OnUpdate : SystemBase
{
    EntityQuery __query_911162766_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_911162766_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<ProjectM.HitTrigger>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast.CollisionCastOnUpdate>(),
            },
        });
        
    }
    

}
