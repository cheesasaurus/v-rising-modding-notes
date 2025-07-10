using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
[UpdateAfter(typeof(ProjectM.UI.GetCharacterHUDSystem))]
public class InteractHUDSystem : SystemBase
{
    EntityQuery __query_833671967_0;
    EntityQuery __query_833671967_1;
    EntityQuery __query_833671967_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_833671967_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.SpellTarget>(),
                ComponentType.ReadOnly<ProjectM.InteractBuff>(),
            },
        });
        
        __query_833671967_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_833671967_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.HideInteractHUDGamepad>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
