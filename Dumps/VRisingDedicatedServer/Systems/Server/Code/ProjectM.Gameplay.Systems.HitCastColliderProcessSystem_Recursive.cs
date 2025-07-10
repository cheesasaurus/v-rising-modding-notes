using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.HandleGameplayEventsRecursiveSystem))]
[UpdateAfter(typeof(ProjectM.SpawnGroup))]
public class HitCastColliderProcessSystem_Recursive : SystemBase
{
    EntityQuery __query_911162862_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_911162862_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
