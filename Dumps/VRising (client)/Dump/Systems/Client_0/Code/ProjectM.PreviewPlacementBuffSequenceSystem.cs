using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
public class PreviewPlacementBuffSequenceSystem : SystemBase
{
    EntityQuery __query_851070354_0;
    EntityQuery __query_851070354_1;
    EntityQuery __query_851070354_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_851070354_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PreviewPlacementBuff>(),
            },
        });
        
        __query_851070354_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_851070354_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModePlacementOperation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
