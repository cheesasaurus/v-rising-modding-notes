using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientAdminConsoleCommandSystem : ProjectM.ConsoleCommandSystem
{
    EntityQuery __query_1991583611_0;
    EntityQuery __query_1991583611_1;
    EntityQuery __query_1991583611_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1991583611_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_NetworkedGate>(),
            },
        });
        
        __query_1991583611_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_MapNode>(),
            },
        });
        
        __query_1991583611_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
