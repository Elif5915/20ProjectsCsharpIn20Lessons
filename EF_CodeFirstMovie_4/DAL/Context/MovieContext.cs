using EF_CodeFirstMovie_4.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirstMovie_4.DAL.Context
{
    public class MovieContext :DbContext
    {
        //sınıf isimleri yalın, veritabanında oluşacak tablo isimlerimiz çoğul olur.
        //yani movie = class, movies = tablo ismim db de.
        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Category> Categories { get; set; }
    }
}
