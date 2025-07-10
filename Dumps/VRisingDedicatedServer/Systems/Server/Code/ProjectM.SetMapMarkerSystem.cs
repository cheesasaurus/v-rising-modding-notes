using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetMapMarkerSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_16518511_0;
    EntityQuery __query_16518511_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SetMapMarkerEvent>(),
            },
        });
        
        __query_16518511_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SetMapMarkerEvent>(),
            },
        });
        
        __query_16518511_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.MapIconData>(),
            },
        });
        
    }
    

}
