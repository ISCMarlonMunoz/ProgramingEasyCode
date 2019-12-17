using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProgramingEasy.Areas.Identity.Data;

namespace ProgramingEasy.Data
{
    public class ProgramingEasyContext : IdentityDbContext<ProgramingEasyUser>
    {
        public ProgramingEasyContext(DbContextOptions<ProgramingEasyContext> options)
            : base(options)
        {
        }

    }
}
