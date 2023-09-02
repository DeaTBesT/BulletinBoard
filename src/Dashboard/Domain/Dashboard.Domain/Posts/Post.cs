using Dashboard.Domain.Base;

namespace Dashboard.Domain.Posts
{
    /// <summary>
    /// Сущность объявлений.
    /// </summary>
    public class Post : BaseEntity
    {
        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор категории.
        /// </summary>
        public Guid CategoryName { get; set; }

        /// <summary>
        /// Наименование тегов.
        /// </summary>
        public string[] TagNames { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public decimal Price { get; set; }
    }
}
