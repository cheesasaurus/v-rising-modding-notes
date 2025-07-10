using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellSchoolProgressionEventSystem_EquipPassives : SystemBase
{
    EntityQuery _EquipPassiveEventQuery;
    EntityQuery _UnEquipPassiveEventQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EquipPassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.EquipSpellSchoolPassive>(),
            },
        });
        
        _UnEquipPassiveEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.UnEquipSpellSchoolPassive>(),
            },
        });
        
    }
    

}
