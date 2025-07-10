using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.CharacterSpawnGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.Systems.SpawnCharacterSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveReactToCharacterSpawnTag : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CharacterRespawnedEvent>(),
            },
        });
        
    }
    

}
