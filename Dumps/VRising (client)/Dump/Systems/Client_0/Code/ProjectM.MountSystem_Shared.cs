using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MountSystem_Shared : SystemBase
{
    EntityQuery __query_1228664933_0;
    EntityQuery __query_1228664933_1;
    EntityQuery __query_1228664933_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1228664933_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.MountBuff>(),
            },
        });
        
        __query_1228664933_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Mountable>(),
                ComponentType.ReadOnly<ProjectM.SaddleBearer>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.UseHybridModel>(),
            },
        });
        
        __query_1228664933_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.MountBuff>(),
            },
        });
        
    }
    

}
