using System.Linq;
using Content.Server.Power.Components;
using Content.Server.Power.EntitySystems;
using JetBrains.Annotations;
using Robust.Shared.Random;

namespace Content.Server.StationEvents.Events;

[UsedImplicitly]
public sealed class BrandingChange : StationEvent
{
    public override string Name => "BrandingChange";
    public override string? StartAnnouncement =>
        Loc.GetString("station-event-branding-change-announcement");
    public override float Weight => WeightNormal;
    protected override float EndAfter => 1.0f;
    public override int? MaxOccurrences => 1;
    public override int MinimumPlayers => 5;
}
