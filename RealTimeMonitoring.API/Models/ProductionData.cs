using System;
using System.ComponentModel.DataAnnotations;

namespace RealTimeMonitoring.API.Models
{
    public class ProductionData
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string MachineName { get; set; } = string.Empty;  // Prevent null errors

        [Required]
        public double Efficiency { get; set; }

        [Required]
        public string Status { get; set; } = string.Empty;  // Prevent null errors

        [Required]
        public int ProductionCount { get; set; }

        [Required]
        public double Temperature { get; set; }

        [Required]
        public double Humidity { get; set; }

        [Required]
        public string ErrorLog { get; set; } = string.Empty;  // Prevent null errors

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.Now; // Default timestamp
    }
}
