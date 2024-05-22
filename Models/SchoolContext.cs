﻿using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace CreateDbFromScratch.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PokemonCategory> PokemonCategories { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }


        public SchoolContext(DbContextOptions options) : base(options)
        {
           
        }

       
    }
}
