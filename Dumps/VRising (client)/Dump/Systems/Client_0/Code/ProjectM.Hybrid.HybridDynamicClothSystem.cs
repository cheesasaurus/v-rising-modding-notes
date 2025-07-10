using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridDynamicClothSystem : SystemBase
{
    EntityQuery __query_410008420_0;
    EntityQuery __query_410008420_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_410008420_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridClothUser>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelState>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_410008420_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
