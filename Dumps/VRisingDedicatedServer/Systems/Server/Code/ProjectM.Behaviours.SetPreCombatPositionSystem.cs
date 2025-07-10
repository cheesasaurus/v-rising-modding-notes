using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class SetPreCombatPositionSystem : SystemBase
{
    EntityQuery __query_689776962_0;
    EntityQuery __query_689776962_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_689776962_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeState>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
                ComponentType.ReadOnly<ProjectM.UseBossCenterPositionAsPreCombatPosition>(),
            },
        });
        
        __query_689776962_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.AggroConsumer>(),
                ComponentType.ReadOnly<ProjectM.UseBossCenterPositionAsPreCombatPosition>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeState>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Minion>(),
            },
        });
        
    }
    

}
