using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
public class ParticleLifetimeSystem : SystemBase
{
    EntityQuery __query_1993479255_0;
    EntityQuery __query_1993479255_1;
    EntityQuery __query_1993479255_2;
    EntityQuery __query_1993479255_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1993479255_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateParticleSystem>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
        __query_1993479255_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.ParticleScale>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.SequencerParticle>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<ProjectM.ParticleSettings>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
        __query_1993479255_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sequencer.VisualEffectParameterElement>(),
                ComponentType.ReadWrite<HybridVisualEffects>(),
            },
        });
        
        __query_1993479255_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sequencer.LineRendererPositionElement>(),
                ComponentType.ReadWrite<HybridLineRenderers>(),
            },
        });
        
    }
    

}
