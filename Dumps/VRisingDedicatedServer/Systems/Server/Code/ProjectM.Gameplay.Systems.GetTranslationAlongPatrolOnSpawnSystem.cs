using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step1))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetTranslationAlongPatrolOnSpawnSystem : SystemBase
{
    EntityQuery __query_20499646_0;
    EntityQuery __query_20499646_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_20499646_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetTranslationAlongPatrolOnSpawn>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_20499646_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GetTranslationAlongPatrolOnSpawn>(),
                ComponentType.ReadWrite<ProjectM.LastTranslation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
