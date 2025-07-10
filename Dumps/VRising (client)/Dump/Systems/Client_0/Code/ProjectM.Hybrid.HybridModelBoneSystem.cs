using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.PresentationGraphSystem_Update))]
public class HybridModelBoneSystem : SystemBase
{
    EntityQuery __query_810312037_0;
    EntityQuery __query_810312037_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_810312037_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelBones>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_810312037_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelBones>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
