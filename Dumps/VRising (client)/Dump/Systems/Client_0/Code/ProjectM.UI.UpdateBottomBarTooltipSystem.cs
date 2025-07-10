using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class UpdateBottomBarTooltipSystem : SystemBase
{
    EntityQuery __query_140836580_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_140836580_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.AbsorbBuff>(),
            },
        });
        
    }
    

}
