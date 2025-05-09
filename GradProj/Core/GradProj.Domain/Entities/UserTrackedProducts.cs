﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradProj.Domain.Entities
{
    public class UserTrackedProducts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public int TrackedProductId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

        [ForeignKey(nameof(TrackedProductId))]
        public virtual TrackedProducts TrackedProducts { get; set; } = null!;
    }
}
