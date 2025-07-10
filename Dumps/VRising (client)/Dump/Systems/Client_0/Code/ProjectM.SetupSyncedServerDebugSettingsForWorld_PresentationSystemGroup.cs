using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
public class SetupSyncedServerDebugSettingsForWorld_PresentationSystemGroup : ProjectM.SetupSyncedServerDebugSettingsForWorld_Base
{
    EntityQuery __query_524302123_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_524302123_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SyncedServerDebugSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
