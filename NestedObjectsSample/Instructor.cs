using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// An individual instructor
    /// </summary>
    class Instructor
    {
        public Instructor()
        {
            CourseLoad = new List<Course>();
        }

        /// <summary>
        /// The official @cptc.edu work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The location of the office in building/room format
        /// ex. B11R112
        /// </summary>
        public string OfficeLocation { get; set; }

        /// <summary>
        /// The 4 digit extension
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// The first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The ciyrses the instructor is currently teaching
        /// </summary>
        public List<Course> CourseLoad { get; set; }

        public void AddCourse(Course c)
        {
            if(CourseLoad == null)
            {
                CourseLoad = new List<Course>();
            }
            CourseLoad.Add(c);
        }
    }
}
