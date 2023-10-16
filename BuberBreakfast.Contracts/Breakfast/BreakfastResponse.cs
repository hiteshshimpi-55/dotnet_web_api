namespace BuberBreakfast.Contracts.BuberBreakfast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime LastModified,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);