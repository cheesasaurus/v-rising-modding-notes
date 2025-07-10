using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.ParticleLifetimeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class GlobalParticleLifetimeSystem : SystemBase
{
    EntityQuery _EmissionQuery;
    EntityQuery _ParticleStateQuery;
    EntityQuery _CheckIfShouldSpawnGlobalQuery;
    EntityQuery __query_753652041_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EmissionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleIndex>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.GlobalParticleEmissionData>(),
            },
        });
        
        _ParticleStateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleIndex>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.SequencerParticle>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.GlobalParticleEmissionData>(),
            },
        });
        
        _CheckIfShouldSpawnGlobalQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateParticleSystem>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
        __query_753652041_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.InstantiateParticleSystem>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
    }
    

}
