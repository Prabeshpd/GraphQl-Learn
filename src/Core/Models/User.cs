public sealed record User(
    string Id,
    string Name,
    string Email,
    string AvatarUrl,
    List<string?> CommunityIds = new List<string?>()
);
