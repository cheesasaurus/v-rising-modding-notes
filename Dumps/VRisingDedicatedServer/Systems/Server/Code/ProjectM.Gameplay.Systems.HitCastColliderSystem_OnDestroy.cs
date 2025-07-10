using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class HitCastColliderSystem_OnDestroy : SystemBase
{
    EntityQuery __query_911162819_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_911162819_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<ProjectM.HitTrigger>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast>(),
                ComponentType.ReadOnly<ProjectM.HitColliderCast.CollisionCastOnDestroy>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
