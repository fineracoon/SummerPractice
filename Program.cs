using System;

namespace task0
{
    class Program
    {
        interface MarkSettings
        {
            public double GetAvgMark();
            public void ResetAllMarks();
        }

        class Student : MarkSettings
        {
            private string studName;
            private int studAge;
            private Mark[] studMarks;

            public Student()
            { }

            public Student(string name, int age)
            {
                studName = name;
                studAge = age;
            }

            public string GetName()
            {
                return studName;
            }

            public void SetName(string name)
            {
                studName = name;
            }

            public int GetAge()
            {
                return studAge;
            }

            public void SetAge(int age)
            {
                studAge = age;
            }

            public void AddMark(Mark mark)
            {
                studMarks[studMarks.Length] = mark;
            }

            public Mark[] GetStudentSMarks()
            {
                return studMarks;
            }

            public double GetAvgMark()
            {
                double avg = 0.0;
                foreach (Mark mark in studMarks)
                {
                    avg += mark.GetMark();
                }
                avg /= studMarks.GetLength(1);
                return avg;
            }

            public void ResetAllMarks()
            {
                foreach (Mark mark in studMarks)
                {
                    mark.SetMark(0);
                }
            }

            
            public string StudentRate(Student student)
            {
                if (GetAvgMark() >= 9)
                {
                    return "отличник";
                }
                else if (GetAvgMark() >= 7)
                {
                    return "хорошист";
                }
                else if (GetAvgMark() >= 4)
                {
                    return "средний";
                }
                else
                {
                    return "отчислен";
                }
            }

            public void PositiveMarksCount(out int count)
            {
                int i;
                for (i = 0, count = 0; i < studMarks.Length; i++)
                {
                    if (studMarks[i].GetMark() >= 4)
                        count++;
                }
            }

            public void PassTheExamAgain(ref Mark badMark)
            {
                switch (badMark.GetMark())
                {
                    case 1:
                        badMark.SetMark(4);
                        break;
                    case 2:
                        goto case 1;
                    case 3:
                        goto case 1;
                    default:
                        Console.WriteLine("Оценку исправлять не нужно");
                        break;
                }
            }
        }

        class Mark
        {
            private string subjectName;
            private int mark;

            public Mark()
            { }

            public Mark(string subj, int m)
            {
                subjectName = subj;
                mark = m;
            }

            public Mark(Mark m)
            {
                this.subjectName = m.GetSubject();
                this.mark = m.GetMark();
            }

            public string GetSubject()
            {
                return subjectName;
            }

            public void SetSubject(string subj)
            {
                subjectName = subj;
            }

            public int GetMark()
            {
                return mark;
            }

            public void SetMark(int m)
            {
                mark = m;
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
