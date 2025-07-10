using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
public class CharacterHudProgressBarSystem : SystemBase
{
    EntityQuery __query_399423469_0;
    EntityQuery __query_399423469_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_399423469_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.CharacterHudProgressBar>(),
            },
        });
        
        __query_399423469_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UseCharacterHudProgressBar>(),
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.EntityCreator>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
