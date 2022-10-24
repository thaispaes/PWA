﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Domain.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}