using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.AiGroup))]
public class ScriptUpdateServer : SystemBase
{
    EntityQuery _EntityQuery;
    EntityQuery __query_884425814_0;
    EntityQuery __query_884425814_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.Scripting.ScriptUpdate>(),
            },
        });
        
        __query_884425814_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.Scripting.ScriptUpdate>(),
            },
        });
        
        __query_884425814_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDataInitializedSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
