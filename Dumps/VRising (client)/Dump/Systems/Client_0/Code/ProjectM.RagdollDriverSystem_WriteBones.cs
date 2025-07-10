using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationInjectionSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RagdollDriverSystem_WriteBones : SystemBase
{
    EntityQuery __query_501954718_0;
    EntityQuery __query_501954718_1;
    EntityQuery __query_501954718_2;
    EntityQuery __query_501954718_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501954718_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RagdollDriver>(),
                ComponentType.ReadOnly<ProjectM.RagdollBoneEntityElement>(),
                ComponentType.ReadWrite<ProjectM.RagdollBoneTransformElement>(),
            },
        });
        
        __query_501954718_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RagdollDriver>(),
                ComponentType.ReadOnly<ProjectM.RagdollBoneTransformElement>(),
                ComponentType.ReadOnly<ProjectM.HybridRagdollComponent>(),
            },
        });
        
        __query_501954718_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Animation.RukhankaRagdollDriver>(),
                ComponentType.ReadOnly<ProjectM.RagdollDriver>(),
                ComponentType.ReadOnly<ProjectM.RagdollBoneTransformElement>(),
            },
        });
        
        __query_501954718_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RuntimeAnimationData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
