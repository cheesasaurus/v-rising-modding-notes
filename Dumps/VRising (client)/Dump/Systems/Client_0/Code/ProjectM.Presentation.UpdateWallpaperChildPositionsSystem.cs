using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateBefore(typeof(ProjectM.ReactToTilePositionGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateWallpaperChildPositionsSystem : SystemBase
{
    EntityQuery __query_1779855213_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1779855213_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.WallpaperParentTransform>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
        });
        
    }
    

}
