﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings_Email
  {
    [Required]
    public string Value { get; set; } //Email Validation
  }
}