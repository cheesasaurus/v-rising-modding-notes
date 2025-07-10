using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BindCoffinSystem : SystemBase
{
    EntityQuery __query_796452872_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_796452872_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.BindCoffin>(),
            },
        });
        
    }
    

}
