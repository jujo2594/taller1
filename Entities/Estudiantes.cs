
using System.Diagnostics.Contracts;

namespace taller1.Entities
{
    public class Estudiantes
    {
        //Definiendo las propiedad de la clases Estudiantes
        private string studentCode;
        private string name;
        private string email;
        private int age;
        private string adress; 

        private double[] quizes = {0, 0, 0 , 0};

        private double[] homework = {0, 0};

        private double[] exams = {0, 0, 0};

        private double quizFinal;

        private double homeworkFinal;

        private double examsFinal;
        
        public string StudentCode{
            get{ return studentCode;}
            set{studentCode = value;}
        }

        public string Name{
            get{ return name;}
            set{name = value;}
        }

        public string Email{
            get{ return email;}
            set{email = value;}
        }

        public int Age{
            get{ return age;}
            set{age = value;}
        }

        public string Adress{
            get{return adress;}
            set{adress = value;}
        }

        public double[] Quizes{
            get { return quizes; }
            set { quizes = value; }
        }

        public double[] Homework{
            get { return homework; }
            set { homework = value; }
        }

        public double[] Exams{
            get { return exams; }
            set { exams = value; }
        }

        public double QuizFinal{
            get { return quizFinal; }
            set { quizFinal = value; }
        }

        public double HomeworkFinal{
            get { return homeworkFinal; }
            set {homeworkFinal = value; }
        }

        public double ExamsFinal{
            get { return examsFinal; }
            set {examsFinal = value; }
        }
        //Definiendo el contructor de la clase 'Estudiantes'
        public Estudiantes()
        {
        }

        public Estudiantes(string studentCode, string name, string email, int age, string adress, double[] quizes, double[] homework, double[] exams)
        {
            this.studentCode = studentCode;
            this.name = name;
            this.email = email;
            this.age = age;
            this.adress = adress;
            this.quizes = quizes;
            this.homework = homework;
            this.exams = exams;
        }
    }
}