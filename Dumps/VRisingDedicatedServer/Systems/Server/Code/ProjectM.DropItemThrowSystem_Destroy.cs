using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DropItemThrowSystem_Destroy : SystemBase
{
    EntityQuery __query_2070481925_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2070481925_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DropItemThrowSystem.DropItem>(),
                ComponentType.ReadOnly<ProjectM.SpellMovement>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
