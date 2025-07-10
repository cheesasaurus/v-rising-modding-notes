using Unity.Entities;

namespace ProjectM.Audio;


[UpdateInGroup(typeof(ProjectM.AudioGroup))]
public class FootstepSystem : SystemBase
{
    EntityQuery __query_671649534_0;
    EntityQuery __query_671649534_1;
    EntityQuery __query_671649534_2;
    EntityQuery __query_671649534_3;
    EntityQuery __query_671649534_4;
    EntityQuery __query_671649534_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_671649534_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DisableFootsteps>(),
            },
        });
        
        __query_671649534_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.StudioListener>(),
            },
        });
        
        __query_671649534_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelDOTSAnimator>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelFootstepComponentDOTS>(),
            },
        });
        
        __query_671649534_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_671649534_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_671649534_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Audio.FakeTurnOffStudioListener>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
