using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.ParticleLifetimeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ParticleBudgetSystem : SystemBase
{
    EntityQuery __query_993399903_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_993399903_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.SequencerParticle>(),
                ComponentType.ReadWrite<ProjectM.ParticleSettings>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.GlobalParticleSystem>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.BulletHellParticleSystem>(),
            },
        });
        
    }
    

}
