using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.FillAnimationsFromControllerSystem))]
public class AnimationCullingContextUpdateSystem : SystemBase
{
    EntityQuery __query_1678850098_0;
    EntityQuery __query_1678850098_1;
    EntityQuery __query_1678850098_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1678850098_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.AnimationCullingContext>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1678850098_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.DebugDrawer.Drawer>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1678850098_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.AnimationCullingContext>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
