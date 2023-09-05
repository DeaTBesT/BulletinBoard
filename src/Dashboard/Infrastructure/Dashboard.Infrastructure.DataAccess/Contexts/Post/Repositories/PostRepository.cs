using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories
{
    /// <inheritdoc />
    public class PostRepository : IPostRepository
    {
        /// <inheritdoc />
        public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return Task.Run(() => new PostDto
            {
                Id = Guid.NewGuid(),
                Title = "Title",
                Description = "Description",
                CategoryName = "Category",
                TagNames = new[] {"Tag1", "Tag2"},
                Price = 0
            }, cancellationToken);
        }
    }
}
