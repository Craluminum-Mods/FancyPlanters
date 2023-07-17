using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Datastructures;
using Vintagestory.API.MathTools;

namespace FancyPlanters;

public class BlockBehaviorName : BlockBehavior
{
    private string name;

    public BlockBehaviorName(Block block) : base(block) { }

    public override void Initialize(JsonObject properties)
    {
        base.Initialize(properties);

        var main = properties["main"].AsString();
        var parts = properties["parts"].AsObject<List<string>>();
        name = ConstructName(main, parts);
    }

    private static string ConstructName(string main, List<string> parts)
    {
        var sb = new StringBuilder();
        sb.Append(Lang.GetMatchingIfExists(main));
        foreach (var part in parts)
        {
            sb.Append(Lang.GetMatchingIfExists(part) ?? part);
        }

        return sb.ToString();
    }

    public override void GetHeldItemName(StringBuilder sb, ItemStack itemStack)
    {
        sb.Clear();
        sb.Append(name);
    }

    public override void GetPlacedBlockName(StringBuilder sb, IWorldAccessor world, BlockPos pos)
    {
        sb.Clear();
        sb.Append(name);
    }
}