using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class PlayerCombatBuffSystem_Reapplication : SystemBase
{
    EntityQuery __query_928948900_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_928948900_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
                ComponentType.ReadOnly<ProjectM.InverseAggroBufferElement>(),
            },
        });
        
    }
    

}
