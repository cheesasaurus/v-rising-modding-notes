using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateBefore(typeof(ProjectM.UI.AbilityBarParentMapper))]
public class AbilityBarParentBinderSystem : SystemBase
{
    EntityQuery __query_571532210_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_571532210_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityBar_Client>(),
                ComponentType.ReadOnly<ProjectM.AbilityBar_Shared>(),
                ComponentType.ReadWrite<ProjectM.AbilityGroupSlotBuffer>(),
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
        });
        
    }
    

}
