using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class WarEventRegistrySystem : SystemBase
{
    EntityQuery _StartEvents;
    EntityQuery __query_145170328_0;
    EntityQuery __query_145170328_1;
    EntityQuery __query_145170328_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        // Error processing _StartEvents
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
        
        
        __query_145170328_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Shared.WarEvents.WarEvent_MapNode>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.WarEvents.WarEventRegistrySystem.Registered>(),
            },
        });
        
        __query_145170328_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_Gate>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.WarEvents.WarEventRegistrySystem.Registered>(),
            },
        });
        
        __query_145170328_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_Portal>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.WarEvents.WarEventRegistrySystem.Registered>(),
            },
        });
        
    }
    

}
