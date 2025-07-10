using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.EarlyUpdateGroup))]
public class ScriptMapperPrepareDependenciesSystem : SystemBase
{
    EntityQuery __query_884425773_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_884425773_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataInitializedSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
