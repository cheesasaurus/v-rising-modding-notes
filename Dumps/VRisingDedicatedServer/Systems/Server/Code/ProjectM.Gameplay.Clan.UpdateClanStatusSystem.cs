using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateClanStatusSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ClanMemberStatus>(),
            },
        });
        
    }
    

}
