using Unity.Entities;

namespace ProjectM.Wind;


[UpdateInGroup(typeof(PresentationSystemGroup))]
public class WindMapZoneSystem : SystemBase
{
    EntityQuery __query_22682122_0;
    EntityQuery __query_22682122_1;
    EntityQuery __query_22682122_2;
    EntityQuery __query_22682122_3;
    EntityQuery __query_22682122_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_22682122_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Wind.WindZoneSphere>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_22682122_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Wind.WindZoneBox>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
        __query_22682122_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_22682122_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraTarget>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_22682122_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
