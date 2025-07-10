using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
public class SetCursorSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_896860632_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_896860632_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.DisableUISettingsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
