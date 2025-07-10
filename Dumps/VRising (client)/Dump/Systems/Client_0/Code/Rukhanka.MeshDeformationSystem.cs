using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.SkinnedMeshPreparationSystem))]
public class MeshDeformationSystem : SystemBase
{
    EntityQuery activeDeformedEntitiesQuery;
    EntityQuery __query_525329052_0;
    EntityQuery __query_525329052_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        activeDeformedEntitiesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.AnimatedSkinnedMeshComponent>(),
            },
        });
        
        __query_525329052_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.AnimatedSkinnedMeshComponent>(),
            },
        });
        
        __query_525329052_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.DeformationRuntimeData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
