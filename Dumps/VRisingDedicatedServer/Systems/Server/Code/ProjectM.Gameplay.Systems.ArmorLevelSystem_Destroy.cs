using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ArmorLevelSystem_Destroy : SystemBase
{
    EntityQuery __query_663986292_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_663986292_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.ArmorLevel>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
