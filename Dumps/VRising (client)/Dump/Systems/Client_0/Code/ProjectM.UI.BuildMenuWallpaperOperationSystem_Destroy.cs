using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildMenuWallpaperOperationSystem_Destroy : SystemBase
{
    EntityQuery _DestroyQuery;
    EntityQuery __query_2013417914_0;
    EntityQuery __query_2013417914_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperation>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationActiveSequenceElement>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperWallSelection>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperPillarSelection>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2013417914_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperation>(),
                ComponentType.ReadWrite<ProjectM.UI.BuildMenuWallpaperOperationActiveSequenceElement>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperWallSelection>(),
                ComponentType.ReadWrite<ProjectM.UI.WallpaperPillarSelection>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_2013417914_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
