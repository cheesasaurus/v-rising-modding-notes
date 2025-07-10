using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemapAbilitySlotsForGamepadSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_156071991_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RecalculateRemapAbilitySlotsEvent>(),
            },
        });
        
        __query_156071991_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
