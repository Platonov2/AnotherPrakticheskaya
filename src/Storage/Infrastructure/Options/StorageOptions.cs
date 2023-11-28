namespace Storage.Infrastructure.Options;

public sealed class StorageOptions
{
    public const string SectionName = "Storage";

    public string? Provider {  get; init; }

    public string? SqliteConnectionString { get; init; }

    public string? PgSqlConnectionString { get; init; }

    public string RequiredProvider => Provider ??
        throw new InvalidOperationException($"Не задано значение {nameof(Provider)}");

    public string RequiredSqliteConnectionString => SqliteConnectionString ??
        throw new InvalidOperationException($"Не задано значение {nameof(SqliteConnectionString)}");

    public string RequiredPgSqlConnectionString => PgSqlConnectionString ??
        throw new InvalidOperationException($"Не задано значение {nameof(PgSqlConnectionString)}");
}
