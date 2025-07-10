using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.BeforeTransformSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunCloth_ResetBoneChain_System : SystemBase
{
    EntityQuery __query_501411762_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501411762_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.BoneChainSegment_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.StunclothBoneChainComponent>(),
            },
        });
        
    }
    

}
