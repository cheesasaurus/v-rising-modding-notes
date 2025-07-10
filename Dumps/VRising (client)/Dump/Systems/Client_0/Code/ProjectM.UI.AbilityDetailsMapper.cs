using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class AbilityDetailsMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_571531663_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_571531663_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
