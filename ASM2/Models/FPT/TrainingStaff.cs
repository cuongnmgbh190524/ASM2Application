﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class TrainingStaff
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please choose Name")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please choose Contact")]
    public string Contact { get; set; }
    
}
