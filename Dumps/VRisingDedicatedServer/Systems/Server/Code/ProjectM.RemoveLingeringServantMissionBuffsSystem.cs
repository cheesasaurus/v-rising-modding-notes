using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RemoveLingeringServantMissionBuffsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _ActiveMissionsQuery;
    EntityQuery __query_1849383848_0;
    EntityQuery __query_1849383848_1;
    EntityQuery __query_1849383848_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantData>(),
            },
        });
        
        // Error processing _ActiveMissionsQuery
        // 
        // Il2CppInterop.Runtime.Il2CppException: System.NullReferenceException: Object reference not set to an instance of an object.
        //  --- BEGIN IL2CPP STACK TRACE ---
        //  System.NullReferenceException: Object reference not set to an instance of an object.
        //    at Unity.Entities.EntityQuery.get_IsCacheValid () [0x00000] in <00000000000000000000000000000000>:0 
        //  --- END IL2CPP STACK TRACE ---
        //  
        //     at Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(IntPtr returnedException) in C:\Work\-\VRisingBepInExBuild\Il2CppInterop\Il2CppInterop.Runtime\Il2CppException.cs:line 36
        //     at Unity.Entities.EntityQuery.get_IsCacheValid()
        //     at cheesasaurus.VRisingMods.SystemsDumper.CodeGeneration.EcsSystemCodeGenerator.GenerateEntityQueryExampleInitializationLines(NamedEntityQuery namedQuery)
        
        
        __query_1849383848_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantData>(),
            },
        });
        
        __query_1849383848_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ActiveServantMission>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1849383848_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantMissionSettingsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
