using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface ITestimonialService
    {
        public List<Testimonial> GetTestimonial();
        public bool InsertTestimonial(Testimonial Testimonial);
        public bool UpdateTestimonial(Testimonial Testimonial);
        public bool DeleteTestimonial(int id);
        public List<Testimonial> GetActiveTestimonial();
    }
}
