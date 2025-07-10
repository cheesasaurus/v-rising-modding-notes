using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public class Spawn_RemapAbilitySlotsForGamepadBuffSystem : SystemBase
{
    EntityQuery __query_156071901_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_156071901_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
