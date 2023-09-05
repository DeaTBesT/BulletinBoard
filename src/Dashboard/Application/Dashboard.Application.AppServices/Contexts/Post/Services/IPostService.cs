using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Post.Services
{
    /// <summary>
    /// Сервис работы с объявлениями.
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Возвращает объявление по идетнификатору.
        /// </summary>
        /// <param name="id">Идетификатор объявления.</param>
        /// <param name="cancellationToken">Отмена операции.</param>
        /// <returns>Модель объявления <see cref="PostDto"/></returns>
        Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
