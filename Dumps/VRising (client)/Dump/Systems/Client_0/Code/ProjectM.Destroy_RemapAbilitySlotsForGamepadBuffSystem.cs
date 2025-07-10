using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_RemapAbilitySlotsForGamepadBuffSystem : SystemBase
{
    EntityQuery __query_156071928_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_156071928_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
