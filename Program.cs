using System;

namespace task0
{
    class Program
    {
        interface MarkSettings
        {
            public double GetAvgMark(Mark[] marks);
            public void ResetAllMarks(Mark[] marks);
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

            public double GetAvgMark(Mark[] marks)
            {
                double avg = 0.0;
                foreach (Mark mark in marks)
                {
                    avg += mark.GetMark();
                }
                avg /= marks.GetLength(1);
                return avg;
            }

            public void ResetAllMarks(Mark[] marks)
            {
                foreach (Mark mark in marks)
                {
                    mark.SetMark(0);
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
