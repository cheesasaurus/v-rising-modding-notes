using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.ParticleLifetimeSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
public class BulletHellParticleLifetimeSystem : SystemBase
{
    EntityQuery _ParticleStateQuery;
    EntityQuery __query_2105604579_0;
    EntityQuery __query_2105604579_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ParticleStateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleIndex>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.SequencerParticle>(),
            },
        });
        
        __query_2105604579_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateParticleSystem>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
            },
        });
        
        __query_2105604579_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleIndex>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.SequencerParticle>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
    }
    

}
