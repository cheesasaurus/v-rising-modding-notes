using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.GlobalParticleLifetimeSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
public class GlobalParticleDecalLifetimeSystem : SystemBase
{
    EntityQuery __query_1011516873_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1011516873_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateGlobalParticleDecal>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateParticleSystem>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
    }
    

}
