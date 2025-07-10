using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.CharacterHUDGroup))]
[UpdateAfter(typeof(ProjectM.UI.GetCharacterHUDSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetCharacterHUDSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1191101126_0;
    EntityQuery __query_1191101126_1;
    EntityQuery __query_1191101126_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        // Error processing _Query
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
        
        
        __query_1191101126_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_1191101126_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1191101126_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestHUDSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
