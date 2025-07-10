using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.GetTranslationOnSpawnSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetOwnerRotationOnSpawnSystem : SystemBase
{
    EntityQuery __query_1724438999_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1724438999_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetOwnerRotation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
