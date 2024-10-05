﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LogAPI.Models
{
    public class LogSearch
    {
        public int? Id { get; set; }
        public Guid? CorrelationId { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? Thread { get; set; }
        public string? Level { get; set; }
        public string? Logger { get; set; }
        public string? Message { get; set; }
        public string? Exception { get; set; }
    }
}
