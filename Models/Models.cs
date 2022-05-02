using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.IO;

namespace WebApplication1.Models
{
    public class Models
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class DataPoints
    {
        public int? x { get; set; }
        public int? y { get; set; }
    }
    

        public class Department
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        
        //public int departmentId { get; set; }
        [Required]
        public string? departmentName { get; set; }

        [Display(Name = "Golbal Ranking")]
        public string? departmentRanking { get; set; }

        //public List<Student?> Students { get; set; }
        
    }

    
    public class Campus
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        //public int campusId { get; set; }
        [Required]
        public string? campusCity { get; set; }

        public string? campusState { get; set; }

        public string? campusTotEnrollments { get; set; }

        //public List<Student?> Students { get; set; }
    }

    public class Student
    {
        [Key]
        public int studentId { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string? studentName { get; set; }

        [Display(Name = "Student SAT Score")]
        public string? studentScore { get; set; }

        [Display(Name = "Apply To USF Campus")]
        public string? appliedUniversity { get; set; }

        //public string departmentName { get; set; }
        //public Department Department { get; set; }

        //public string campusName { get; set; }
        //public Campus Campus { get; set; }

    }


    public class BigModel
    {
        public Student? Student { get; set; }
        
        public Campus? Campus { get; set; }

        public Department? Department { get; set; }
    }

}