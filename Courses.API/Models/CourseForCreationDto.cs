using Courses.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different from description")]
    public class CourseForCreationDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 caracters.")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "The title shouldn't have more than 500 caracters.")]
        public string Description { get; set; }
    }
}
