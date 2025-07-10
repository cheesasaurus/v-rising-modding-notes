using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.GetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Wind.WindMapZoneSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
public class MoodSystem : SystemBase
{
    EntityQuery _NewMoodVolumesQuery;
    EntityQuery __query_1647230845_0;
    EntityQuery __query_1647230845_1;
    EntityQuery __query_1647230845_2;
    EntityQuery __query_1647230845_3;
    EntityQuery __query_1647230845_4;
    EntityQuery __query_1647230845_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NewMoodVolumesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Presentation.MoodAssetRef>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.MoodIndex>(),
            },
        });
        
        __query_1647230845_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.FadeOutFlyMoodBuff>(),
            },
        });
        
        __query_1647230845_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.MoodColliderSphere>(),
                ComponentType.ReadOnly<ProjectM.Presentation.MoodIndex>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_1647230845_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.MoodColliderBox>(),
                ComponentType.ReadOnly<ProjectM.Presentation.MoodIndex>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_1647230845_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1647230845_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1647230845_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
