using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReplaceMapIconNamesByChunkSystem : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_1643157119_0;
    EntityQuery __query_1643157119_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MapIconData>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1643157119_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MapIconData>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1643157119_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChunkDataRemappings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
