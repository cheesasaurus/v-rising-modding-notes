using Unity.Entities;

namespace ProjectM.AimPreviewSplines.System;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimPreviewMeshGenSystem : SystemBase
{
    EntityQuery __query_1617475038_0;
    EntityQuery __query_1617475038_1;
    EntityQuery __query_1617475038_2;
    EntityQuery __query_1617475038_3;
    EntityQuery __query_1617475038_4;
    EntityQuery __query_1617475038_5;
    EntityQuery __query_1617475038_6;
    EntityQuery __query_1617475038_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1617475038_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.Component.AimPreviewBezierComponent>(),
            },
        });
        
        __query_1617475038_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewBezierComponent>(),
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewBezierMeshDataComponent>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.System.AimPreviewRenderer>(),
            },
        });
        
        __query_1617475038_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewCircleComponent>(),
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewCircleMeshDataComponent>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.System.AimPreviewRenderer>(),
            },
        });
        
        __query_1617475038_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewConeComponent>(),
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewConeMeshDataComponent>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.System.AimPreviewRenderer>(),
            },
        });
        
        __query_1617475038_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.Component.AimPreviewQuadComponent>(),
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.System.AimPreviewRenderer>(),
            },
        });
        
        __query_1617475038_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimPreview>(),
            },
        });
        
        __query_1617475038_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AimPreviewSplines.Component.AimPreviewCommonData>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.AimPreviewSplines.System.AimPreviewRenderer>(),
            },
        });
        
        __query_1617475038_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
