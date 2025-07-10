using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScriptUpdateClient : SystemBase
{
    EntityQuery __query_949122808_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_949122808_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadOnly<ProjectM.Scripting.ScriptUpdate>(),
            },
        });
        
    }
    

}
