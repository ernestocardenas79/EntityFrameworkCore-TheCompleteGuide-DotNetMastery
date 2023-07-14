using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess;

public class ApplicationDataContext : DbContext
{
    public DbSet<Book> Books { get; set; }
}
