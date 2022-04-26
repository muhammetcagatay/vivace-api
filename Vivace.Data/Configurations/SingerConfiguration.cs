using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivace.Core.Models;

namespace Vivace.Core.Configurations
{
    public class SingerConfiguration : IEntityTypeConfiguration<Singer>
    {
        public void Configure(EntityTypeBuilder<Singer> builder)
        {
            builder.HasMany(c => c.Songs).WithOne(c => c.Singer);
        }
    }
}
