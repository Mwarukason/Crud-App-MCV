using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_App.Models
{   
    //apply validation in class
    [MetadataType(typeof (EmployeeMetadata))]
    public partial class Employee
    {
       
    }

    //server side validation
    public class EmployeeMetadata
    {
        [Required (AllowEmptyStrings = false, ErrorMessage = "Please provide first name")]
         public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide last name")]
        public string LastName { get; set; }
    }
}