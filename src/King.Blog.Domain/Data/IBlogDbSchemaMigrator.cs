using System.Threading.Tasks;

namespace King.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
