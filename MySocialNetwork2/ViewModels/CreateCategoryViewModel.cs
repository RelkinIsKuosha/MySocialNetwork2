﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySocialNetwork2.ViewModels
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string Name { get; set; }

    }
}