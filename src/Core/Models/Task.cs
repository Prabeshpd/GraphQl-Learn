public sealed record Task(
    string Id,
    string Title,
    string Description,
    string Status,
    string UserId,
    DateTime DueDate,
    DateTime CreatedDate,
    DateTime UpdatedDate
);
