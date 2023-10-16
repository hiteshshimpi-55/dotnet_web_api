namespace BuberBreakfast.Contracts.BuberBreakfast;

public record UpSertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);