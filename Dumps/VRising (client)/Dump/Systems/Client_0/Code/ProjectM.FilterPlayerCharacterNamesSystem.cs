using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FilterPlayerCharacterNamesSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1496016438_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadWrite<ProjectM.PlayerCharacter_Client>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FilterPlayerCharacterNamesSystem.Handled>(),
            },
        });
        
        __query_1496016438_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadWrite<ProjectM.PlayerCharacter_Client>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FilterPlayerCharacterNamesSystem.Handled>(),
            },
        });
        
    }
    

}
