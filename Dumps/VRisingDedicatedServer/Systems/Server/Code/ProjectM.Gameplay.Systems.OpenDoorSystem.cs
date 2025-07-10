using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class OpenDoorSystem : SystemBase
{
    EntityQuery __query_1834203323_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1834203323_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.OpenDoor>(),
            },
        });
        
    }
    

}
