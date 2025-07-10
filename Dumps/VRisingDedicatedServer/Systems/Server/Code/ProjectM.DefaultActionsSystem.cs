using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DefaultActionsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_140578809_0;
    EntityQuery __query_140578809_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UseDefaultActionEvent>(),
            },
        });
        
        __query_140578809_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UseDefaultActionEvent>(),
            },
        });
        
        __query_140578809_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
