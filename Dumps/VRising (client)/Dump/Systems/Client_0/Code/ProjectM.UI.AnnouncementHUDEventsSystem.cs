using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AnnouncementHUDEventsSystem : SystemBase
{
    EntityQuery _MapZoneQuery;
    EntityQuery _AchievementQuery;
    EntityQuery _UnlockProgressionQuery;
    EntityQuery _BasicAnnouncementQuery;
    EntityQuery __query_249625726_0;
    EntityQuery __query_249625726_1;
    EntityQuery __query_249625726_2;
    EntityQuery __query_249625726_3;
    EntityQuery __query_249625726_4;
    EntityQuery __query_249625726_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MapZoneQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.MapZoneDiscoveredEvent>(),
            },
        });
        
        _AchievementQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.AchievementClaimedServerEvent>(),
            },
        });
        
        _UnlockProgressionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.UnlockProgressionServerEvent>(),
            },
        });
        
        _BasicAnnouncementQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BasicAnnouncement>(),
            },
        });
        
        __query_249625726_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_249625726_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UnlockProgressionServerEvent>(),
            },
        });
        
        __query_249625726_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.AchievementClaimedServerEvent>(),
            },
        });
        
        __query_249625726_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.MapZoneDiscoveredEvent>(),
            },
        });
        
        __query_249625726_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.BasicAnnouncement>(),
            },
        });
        
        __query_249625726_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
            },
        });
        
    }
    

}
