using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DisableShowOnlyInPreviewSystem_Server : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBuildingShowOnlyInPreview>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
