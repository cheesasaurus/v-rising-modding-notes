using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.WallpaperGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildMenuWallpaperOperationSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _OperationQuery;
    EntityQuery __query_2013417951_0;
    EntityQuery __query_2013417951_1;
    EntityQuery __query_2013417951_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _OperationQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperation>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationSequenceData>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationActiveSequenceElement>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperWallSelection>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperPillarSelection>(),
            },
        });
        
        __query_2013417951_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperation>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationSequenceData>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationActiveSequenceElement>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperWallSelection>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperPillarSelection>(),
            },
        });
        
        __query_2013417951_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.DeferredWallpaperPlacement>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2013417951_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
