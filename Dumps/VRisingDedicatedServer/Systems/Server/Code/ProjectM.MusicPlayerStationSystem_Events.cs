using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MusicPlayerStationSystem_Events : SystemBase
{
    EntityQuery _StartedInteractingEventQuery;
    EntityQuery _SetPausedEventQuery;
    EntityQuery _AddOrRemoveTrackFromPlaylistEventQuery;
    EntityQuery _PlayPreviousTrackEventQuery;
    EntityQuery _PlayNextTrackEventQuery;
    EntityQuery __query_186082734_0;
    EntityQuery __query_186082734_1;
    EntityQuery __query_186082734_2;
    EntityQuery __query_186082734_3;
    EntityQuery __query_186082734_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StartedInteractingEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.StartedInteractingEvent>(),
            },
        });
        
        _SetPausedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.TogglePausedEvent>(),
            },
        });
        
        _AddOrRemoveTrackFromPlaylistEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.AddOrRemoveTrackFromPlaylistEvent>(),
            },
        });
        
        _PlayPreviousTrackEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.PlayPreviousTrackEvent>(),
            },
        });
        
        _PlayNextTrackEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.PlayNextTrackEvent>(),
            },
        });
        
        __query_186082734_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.StartedInteractingEvent>(),
            },
        });
        
        __query_186082734_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.TogglePausedEvent>(),
            },
        });
        
        __query_186082734_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.AddOrRemoveTrackFromPlaylistEvent>(),
            },
        });
        
        __query_186082734_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.PlayPreviousTrackEvent>(),
            },
        });
        
        __query_186082734_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MusicPlayerStationEvents.PlayNextTrackEvent>(),
            },
        });
        
    }
    

}
