using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToCharacterSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ResetBloodOnRespawnSystem : SystemBase
{
    EntityQuery __query_865506300_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_865506300_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CharacterRespawnedEvent>(),
            },
        });
        
    }
    

}
