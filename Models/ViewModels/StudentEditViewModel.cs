﻿using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExercises;
using StudentExercisesAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public Student Student { get; set; }
        public List<Exercise> Exercises { get; set; }
        public List<Cohort> Cohorts { get; set; }
        public List<SelectListItem> CohortOptions
        {
            get
            {
                if (Cohorts == null)
                {
                    return null;
                }

                return Cohorts.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.CohortName
                }).ToList();
            }
        }

        public List<SelectListItem> ExerciseOptions
        {
            get
            {
                if (Exercises == null)
                {
                    return null;
                }

                return Exercises.Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.ExerciseName
                }).ToList();
            }
        }
    }
}