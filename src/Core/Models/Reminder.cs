public sealed record Reminder(
    string Id,
    string Title,
    string Description,
    DateTime ReminderDate,
    string UserId,
    DateTime CreatedDate,
    DateTime UpdatedDate
);
