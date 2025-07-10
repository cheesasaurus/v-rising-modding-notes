using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
public class ReactToDeserializedDebugSettingsSystem_Client : SystemBase
{
    EntityQuery __query_524302153_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_524302153_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SyncedServerDebugSettings>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
