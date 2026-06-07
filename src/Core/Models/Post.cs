public sealed record Post(
    string Id,
    string Title,
    string Content,
    string AuthorId,
    string? CommunityId = null,
    DateTime CreatedDate,
    DateTime UpdatedDate
);
