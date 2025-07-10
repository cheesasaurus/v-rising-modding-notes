using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
public class BoneVisualizationSystem : SystemBase
{
    EntityQuery cpuBoneVisualizeQuery;
    EntityQuery gpuBoneVisualizeQuery;
    EntityQuery __query_970733810_0;
    EntityQuery __query_970733810_1;
    EntityQuery __query_970733810_2;
    EntityQuery __query_970733810_3;
    EntityQuery __query_970733810_4;
    EntityQuery __query_970733810_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        cpuBoneVisualizeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RigDefinitionComponent>(),
                ComponentType.ReadOnly<Rukhanka.BoneVisualizationComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.GPUAnimationEngineTag>(),
            },
        });
        
        gpuBoneVisualizeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RigDefinitionComponent>(),
                ComponentType.ReadOnly<Rukhanka.BoneVisualizationComponent>(),
                ComponentType.ReadOnly<Rukhanka.GPUAnimationEngineTag>(),
            },
        });
        
        __query_970733810_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RigDefinitionComponent>(),
                ComponentType.ReadOnly<Rukhanka.BoneVisualizationComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.GPUAnimationEngineTag>(),
            },
        });
        
        __query_970733810_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RigDefinitionComponent>(),
                ComponentType.ReadOnly<Rukhanka.BoneVisualizationComponent>(),
                ComponentType.ReadOnly<Rukhanka.GPUAnimationEngineTag>(),
            },
        });
        
        __query_970733810_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Rukhanka.DebugDrawer.Drawer>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_970733810_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.RuntimeAnimationData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_970733810_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.DebugConfigurationComponent>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_970733810_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Rukhanka.GPURuntimeAnimationData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
