using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class DangerTextParentSystem : SystemBase
{
    EntityQuery __query_580474276_0;
    EntityQuery __query_580474276_1;
    EntityQuery __query_580474276_2;
    EntityQuery __query_580474276_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_580474276_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_580474276_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.Gameplay.Scripting.Script_Siphon_Blood_Buff_DataShared>(),
            },
        });
        
        __query_580474276_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartPhased>(),
            },
        });
        
        __query_580474276_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
