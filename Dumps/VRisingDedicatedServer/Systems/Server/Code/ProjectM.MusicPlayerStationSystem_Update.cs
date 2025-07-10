using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MusicPlayerStationSystem_Update : SystemBase
{
    EntityQuery __query_186082667_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_186082667_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.MusicPlayerStation_Server>(),
                ComponentType.ReadWrite<ProjectM.MusicPlayer_Shared>(),
                ComponentType.ReadWrite<ProjectM.MusicPlayerStation_PlaylistElement>(),
            },
        });
        
    }
    

}
