using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.StunCloth_UpdateBoneChain_System))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunCloth_SetBoneChain_System : SystemBase
{
    EntityQuery __query_501412041_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_501412041_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.BoneChain_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.BoneChainSegment_Data>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.StunclothBoneChainComponent>(),
            },
        });
        
    }
    

}
