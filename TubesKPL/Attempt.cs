﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesKPL
{
    public class Attempt
    {
        public int AttemptId { get; set; }
        public string UserName { get; set; }
        public string Level { get; set; }
        public double Score { get; set; }
        public DateTime AttemptDate { get; set; }
        public string Grade => GetGradeByScore(Score);

        public Attempt(int attemptId, string userName, string level, double score, DateTime attemptDate)
        {
            AttemptId = attemptId;
            UserName = userName;
            Level = level;
            Score = score;
            AttemptDate = attemptDate;
        }

        public static string GetGradeByScore(double score)
        {
            Debug.Assert(score >= 0 && score <= 100, "Score harus berada dalam rentang 0 - 100");
            string[] grade = { "A", "AB", "B", "BC", "C", "D", "E" };
            double[] rangeLimit = { 80.0, 70.0, 65.0, 60.0, 50.0, 40.0, 0.0 };
            int maxGradeLevel = grade.Length - 1;

            string studentGrade = "E";
            int gradeLevel = 0;
            while ((studentGrade == "E") && (gradeLevel < maxGradeLevel))
            {
                if (score > rangeLimit[gradeLevel])
                    studentGrade = grade[gradeLevel];
                gradeLevel = gradeLevel + 1;
            }

            return studentGrade;

        }
    }
}
