using Unity.Entities;

namespace Stunlock.Animation.StunCloth.Runtime;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[UpdateBefore(typeof(Rukhanka.MeshDeformationSystem))]
[UpdateAfter(typeof(Rukhanka.SkinnedMeshPreparationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunClothManager : SystemBase
{
    EntityQuery _AddClothQuery;
    EntityQuery _UpdateClothQuery;
    EntityQuery _RemoveClothQuery;
    EntityQuery __query_821791885_0;
    EntityQuery __query_821791885_1;
    EntityQuery __query_821791885_2;
    EntityQuery __query_821791885_3;
    EntityQuery __query_821791885_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AddClothQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.StunClothData>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.DeniedClothTag>(),
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.ActiveCloth>(),
            },
        });
        
        _UpdateClothQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.StunClothData>(),
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.ActiveCloth>(),
            },
        });
        
        _RemoveClothQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.ActiveCloth>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.StunClothData>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_821791885_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.StunClothData>(),
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.ActiveCloth>(),
            },
        });
        
        __query_821791885_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.StunClothData>(),
                ComponentType.ReadOnly<Rukhanka.DeniedClothTag>(),
            },
        });
        
        __query_821791885_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Animation.StunCloth.Runtime.ActiveCloth>(),
            },
        });
        
        __query_821791885_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RuntimeAnimationData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_821791885_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.DeformationRuntimeData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
