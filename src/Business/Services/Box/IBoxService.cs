namespace Business.Services.Box;

/// <summary>
/// Интерфейс сервиса коробок
/// </summary>
public interface IBoxService : ICrudService<Models.Box>
{
    public Task<ICollection<Models.Box>> GetAllAsync(CancellationToken cancellationToken);
}
