﻿
namespace ResumeBuilder.ViewModels
{
    public class EducationUIModel
    {
        public string CourseName { get; set; }

        public int PassingYear { get; set; }

        public string Board { get; set; }

        public string Stream { get; set; }

        public bool CGPAOrPercentage { get; set; }

        public double TotalPercentorCGPAValue { get; set; }
    }
}