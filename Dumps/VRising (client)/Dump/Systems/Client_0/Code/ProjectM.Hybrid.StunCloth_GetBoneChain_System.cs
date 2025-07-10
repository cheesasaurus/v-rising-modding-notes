using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.GetAndSetHybridModelTransformSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunCloth_GetBoneChain_System : SystemBase
{
    EntityQuery __query_501411790_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501411790_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.BoneChain_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.BoneChainSegment_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.StunCloth_Collider_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.StunclothBoneChainComponent>(),
            },
        });
        
    }
    

}
