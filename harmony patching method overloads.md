# using Harmony to patch a method with overloads

The third param of HarmonyPatch takes a Type array, to specify the types of the arguments for the method you want to patch.

```
[HarmonyPatch(typeof(InventoryUtilitiesServer), nameof(InventoryUtilitiesServer.TryAddItem), new Type[] { typeof(AddItemSettings), typeof(Entity), typeof(PrefabGUID), typeof(int) })]
[HarmonyPrefix]
public static void TryAddItem_Prefix(
    ref AddItemSettings addItemSettings,
    Entity target,
    PrefabGUID itemType,
    int amount
)
{
    LogUtil.LogInfo($"trying to add item");
    addItemSettings.EquipIfPossible = false;
}
```
