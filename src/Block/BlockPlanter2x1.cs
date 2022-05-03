using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace FancyPlanters
{
  public class BlockPlantContainer2x1 : BlockPlantContainer, IMultiBlockMonolithicSmall
  {
    Cuboidf[] mirroredColBox;
    public override void OnLoaded(ICoreAPI api)
    {
      base.OnLoaded(api);

      mirroredColBox = new Cuboidf[] { CollisionBoxes[0].RotatedCopy(0, 180, 0, new Vec3d(0.5, 0.5, 0.5)) };
    }

    public Cuboidf[] MBGetCollisionBoxes(IBlockAccessor blockAccessor, BlockPos pos, Vec3i offset)
    {
      return mirroredColBox;
    }

    public Cuboidf[] MBGetSelectionBoxes(IBlockAccessor blockAccessor, BlockPos pos, Vec3i offset)
    {
      return mirroredColBox;
    }
  }
}