using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class BuffBarParentSystem : SystemBase
{
    EntityQuery __query_1023508113_0;
    EntityQuery __query_1023508113_1;
    EntityQuery __query_1023508113_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1023508113_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ShowOnBuffBar>(),
            },
        });
        
        __query_1023508113_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WeaponCoating.Coatable>(),
                ComponentType.ReadOnly<ProjectM.Equippable>(),
            },
        });
        
        __query_1023508113_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
