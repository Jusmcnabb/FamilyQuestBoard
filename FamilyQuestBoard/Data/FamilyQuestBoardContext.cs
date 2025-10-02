using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FamilyQuestBoard.Models;

namespace FamilyQuestBoard.Data
{
    public class FamilyQuestBoardContext : DbContext
    {
        public FamilyQuestBoardContext (DbContextOptions<FamilyQuestBoardContext> options)
            : base(options)
        {
        }

        public DbSet<FamilyQuestBoard.Models.Quest> Quest { get; set; } = default!;
    }
}
