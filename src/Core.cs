using Vintagestory.API.Common;
using Vintagestory.API.Util;

[assembly: ModInfo("Fancy Planters")]

namespace FancyPlanters
{
    public class Core : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("Planter2x1", typeof(BlockPlantContainer2x1));
            api.RegisterBlockBehaviorClass("FancyPlanters.BbName", typeof(BlockBehaviorName));
            api.World.Logger.Event("started 'Fancy Planters' mod");
        }

        public override void AssetsFinalize(ICoreAPI api)
        {
            foreach (var obj in api.World.Collectibles)
            {
                if (obj?.Attributes?["plantContainable"]?["fplanter2x1Container"]?.Exists == true)
                {
                    AddCreativeInventoryTab(obj, "fpallowed");
                }
            }
        }

        public static void AddCreativeInventoryTab(CollectibleObject obj, string tabName)
        {
            if (obj.CreativeInventoryTabs != null && obj.CreativeInventoryTabs.Length != 0 && !string.IsNullOrEmpty(obj?.CreativeInventoryTabs?[0]))
            {
                obj.CreativeInventoryTabs = obj.CreativeInventoryTabs.Append(tabName);
            }
        }
    }
}