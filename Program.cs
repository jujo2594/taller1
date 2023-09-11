using System.Runtime.InteropServices.Marshalling;
using taller1.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiantes> Curso = new List<Estudiantes>();
        Console.WriteLine("Ingrese la cantidad de estudiantes del curso: ");
        short numeroEstudiantes = Convert.ToInt16(Console.ReadLine());
        short n = 0;
        bool iniciar = true;
        while(n <= numeroEstudiantes && iniciar){
            Console.WriteLine("Ingrese las siguientes opciones:\n1. Ingrese nombre del estudiante:\n2. Ingrese el email del estudiante:\n3. Ingrese la edad del estudiante\n4. Ingrese la dirección de residencia del estudiante\n5. Calcular definitiva quizes\n6. Calcular definitiva trabajos\n7. Calcular definitiva parciales\n8. Listado de notas del curso\n9. Listado de definitivas\n10. Salir del programa.");
            short opcion = Convert.ToInt16(Console.ReadLine());
            Estudiantes alumno = new Estudiantes();
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine(alumno.StudentCode);
            if(opcion == 1){
                //'Guid.NewGuid()' genera un código aleatorio que no se repite
                String Code = Guid.NewGuid().ToString();
                // '.Substring()' corta un string se especifica la posicion y la cantidad de caracteres a cortar
                alumno.StudentCode = Code.Substring(0,15);
                bool addName = true;
                while(addName){
                    Console.WriteLine("Ingrese el nombre del estudiante: ");
                    string alumnoName = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    if(alumnoName.Length <= 40){
                        alumno.Name = alumnoName;
                        Curso.Add(alumno);
                        n++;
                        addName = false;
                    }else{
                        Console.WriteLine("Ingrese un nombre que contenga menos de 40 caracteres");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }else if(opcion == 2){
                bool addEmail = true;
                while(addEmail){
                for(int i = 0; i < Curso.Count; i++){
                    Console.WriteLine($@"Codigo Alumno:{Convert.ToString(Curso[i].StudentCode)} ----- Nombre Alumno:{Convert.ToString(Curso[i].Name)}");
                }
                Console.WriteLine("Ingrese el codigo del estudiante para agregar su email: ");
                String codeSearch = Convert.ToString(Console.ReadLine());
                bool found = false;
                for(int i = 0; i < Curso.Count; i++){
                    if(codeSearch == Curso[i].StudentCode){
                            Console.WriteLine("Ingrese el email del estudiante: ");
                            string alumnoEmail = Console.ReadLine();
                            if(alumnoEmail.Length <= 40){
                                Curso[i].Email = alumnoEmail;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addEmail = false;
                                break;
                            }else{
                                Console.WriteLine("Ingrese un email que contenga menos de 40 caracteres.");
                                Console.ReadKey();
                                found = true;
                                addEmail = false;
                                break;
                            }
                    }
                }
                if(!found){
                    Console.WriteLine("El codigo ingresado no se encuentra en la lista");
                    Console.ReadKey();
                    addEmail = false;
                }
                } 
            }else if(opcion == 3){
                bool addAge = true;
                while(addAge){
                    for(int i = 0; i < Curso.Count; i++){
                    Console.WriteLine($"Codigo Alumno:{Convert.ToString(Curso[i].StudentCode)} ----- Nombre Alumno: {Convert.ToString(Curso[i].Name)} ----- Email Alumno:{Convert.ToString(Curso[i].Email)}");
                    }
                    Console.WriteLine("Ingrese el código del estudiante para agregar su edad: ");
                    string codeSearch = Console.ReadLine();
                    bool found = false;
                    for(int i = 0; i < Curso.Count; i++){
                        if(codeSearch == Curso[i].StudentCode ){
                            Console.WriteLine("Ingrese la edad del estudiante: ");
                            short alumnoAge = Convert.ToInt16(Console.ReadLine());
                            Curso[i].Age = alumnoAge;
                            Console.ReadKey();
                            Console.Clear();
                            found = true;
                            addAge = false;
                            break;
                        }
                    }
                    if(!found){
                        Console.WriteLine("El codigo ingresado no se encuentra en la lista");
                        Console.ReadKey();
                        Console.Clear();
                        addAge = false;
                    }    
                }
            }else if(opcion == 4){
                bool addAdress = true;
                while(addAdress){
                for(int i = 0; i < Curso.Count; i++){
                    Console.WriteLine($"Codigo Alumno:{Convert.ToString(Curso[i].StudentCode)} ----- Nombre Alumno:{Convert.ToString(Curso[i].Name)} ----- Email Alumno:{Convert.ToString(Curso[i].Email)} ----- Edad Alumno:{Convert.ToString(Curso[i].Age)}");
                }
                Console.WriteLine("Ingrese el código del estudiante para añadir su direccion:");
                string codeSearch = Console.ReadLine();
                bool found = false;
                for(int i = 0; i < Curso.Count; i++){
                    if(codeSearch == Curso[i].StudentCode ){
                        Console.WriteLine("Ingrese la dirección de residencia del alumno: ");
                        string alumnoAdress = Console.ReadLine();
                            if(alumnoAdress.Length <= 35){
                                Curso[i].Adress = alumnoAdress;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addAdress = false;
                                break;
                            }else{
                                Console.WriteLine("Ingrese una direccion de menos de 35 caracteres.");
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addAdress = false;
                                break;
                            }
                        }    
                }
                if(!found){
                    Console.WriteLine("Ingrese un codigo que este dentro de la lista de alumnos");
                    Console.ReadKey();
                    Console.Clear();
                    addAdress = false;
                }   
            }
            }else if(opcion == 5){
                bool addQuizes = true;
                while(addQuizes){
                    for(int i = 0; i < Curso.Count; i++){
                        Console.WriteLine($"Nombre Alumno: {Convert.ToString(Curso[i].Name)} ----- Codigo Alumno: {Convert.ToString(Curso[i].StudentCode)}");
                    }
                    Console.WriteLine("Ingrese el código del alumno a ingresar Quiz");
                    String codeSearch = Console.ReadLine();
                    bool found = false;
                    Console.WriteLine("Ingrese la opcion que desea realizar:\n5.1. Ingresar Quiz 1\n5.2. Ingresar Quiz 2\n5.3. Ingresar Quiz 3\n5.4. Ingresar el Quiz 4");
                    double quizOption = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del quiz: ");
                    double quizNote = Convert.ToDouble(Console.ReadLine());
                    const short quizCant = 4;
                    const double quizPercentage = 0.25d;
                    double quizPartial; 
                    for(int i = 0; i < Curso.Count; i++){
                        if(Curso[i].StudentCode == codeSearch){
                            if(quizOption == 5.1 && quizNote >= 0 && quizNote <= 5.0){
                                Curso[i].Quizes[0] = quizNote;
                                quizPartial = ((Curso[i].Quizes[0]+Curso[i].Quizes[1]+Curso[i].Quizes[2]+Curso[i].Quizes[3])/quizCant)*quizPercentage;
                                Curso[i].QuizFinal = quizPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addQuizes = false;
                            }else if(quizOption == 5.2 && quizNote >= 0 && quizNote <= 5.0){
                                Curso[i].Quizes[1] = quizNote;
                                quizPartial = ((Curso[i].Quizes[0]+Curso[i].Quizes[1]+Curso[i].Quizes[2]+Curso[i].Quizes[3])/quizCant)*quizPercentage;
                                Curso[i].QuizFinal = quizPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addQuizes = false;
                            }else if(quizOption == 5.3 && quizNote >= 0 && quizNote <= 5.0){
                                Curso[i].Quizes[2] = quizNote;
                                quizPartial = ((Curso[i].Quizes[0]+Curso[i].Quizes[1]+Curso[i].Quizes[2]+Curso[i].Quizes[3])/quizCant)*quizPercentage;
                                Curso[i].QuizFinal = quizPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addQuizes = false;
                            }else if(quizOption == 5.4 && quizNote >= 0 && quizNote <= 5.0){
                                Curso[i].Quizes[3] = quizNote;
                                quizPartial = ((Curso[i].Quizes[0]+Curso[i].Quizes[1]+Curso[i].Quizes[2]+Curso[i].Quizes[3])/quizCant)*quizPercentage;
                                Curso[i].QuizFinal = quizPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addQuizes = false;
                            }else{
                                Console.WriteLine("Revise la opcion o la nota ingresada.");
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addQuizes = false;
                            }
                        }
                    if(!found){
                        Console.WriteLine("El código del estudiante no se encuentra en la lista");
                        Console.ReadKey();
                        Console.Clear();
                        addQuizes = false;
                    }
                    }
                }
            }else if(opcion == 6){
            bool addHomework = true;
            while(addHomework){
                for(int i = 0; i < Curso.Count; i++){
                    Console.WriteLine($"Nombre Alumno: {Convert.ToString(Curso[i].Name)} ----- Codigo Alumno: {Convert.ToString(Curso[i].StudentCode)}");
                }
                Console.WriteLine("Ingrese el código del alumno a ingresar Quiz");
                String codeSearch = Console.ReadLine();
                bool found = false;
                Console.WriteLine("Ingrese la opcion que desea realizar:\n6.1. Ingresar homework 1\n6.2. Ingresar homework 2");
                double homeworkOption = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la nota del quiz: ");
                double homeworkNote = Convert.ToDouble(Console.ReadLine());
                const short homeworkCant = 2;
                const double homeworkPercentage = 0.15d;
                double homeworkPartial; 
                for(int i = 0; i < Curso.Count; i++){
                    if(Curso[i].StudentCode == codeSearch){
                        if(homeworkOption == 6.1 && homeworkNote >= 0 && homeworkNote <= 5.0){
                            Curso[i].Homework[0] = homeworkNote;
                            homeworkPartial = ((Curso[i].Homework[0]+Curso[i].Homework[1])/homeworkCant)*homeworkPercentage;
                            Curso[i].HomeworkFinal = homeworkPartial;
                            Console.ReadKey();
                            Console.Clear();
                            found = true;
                            addHomework = false;
                        }else if(homeworkOption == 6.2 && homeworkNote >= 0 && homeworkNote <= 5.0){
                            Curso[i].Homework[1] = homeworkNote;
                            homeworkPartial = ((Curso[i].Homework[0]+Curso[i].Homework[1])/homeworkCant)*homeworkPercentage;
                            Curso[i].HomeworkFinal = homeworkPartial;
                            Console.ReadKey();
                            Console.Clear();
                            found = true;
                            addHomework = false;
                        }else{
                            Console.WriteLine("Revise la opcion o la nota ingresada.");
                            Console.ReadKey();
                            Console.Clear();
                            found = true;
                            addHomework = false;
                        }
                    }
                if(!found){
                    Console.WriteLine("El código del estudiante no se encuentra en la lista");
                    Console.ReadKey();
                    Console.Clear();
                    addHomework = false;
                    }
                }
            }
            }else if(opcion == 7){
                bool addExams = true;
                while(addExams){
                    for(int i = 0; i < Curso.Count; i++){
                        Console.WriteLine($"Nombre Alumno: {Convert.ToString(Curso[i].Name)} ----- Codigo Alumno: {Convert.ToString(Curso[i].StudentCode)}");
                    }
                    Console.WriteLine("Ingrese el código del alumno a ingresar Quiz");
                    String codeSearch = Console.ReadLine();
                    bool found = false;
                    Console.WriteLine("Ingrese la opcion que desea realizar:\n7.1. Ingresar Parcial 1\n7.2. Ingresar Parcial 2\n7.3. Ingresar Parcial 3");
                    double examsOption = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del quiz: ");
                    double examsNote = Convert.ToDouble(Console.ReadLine());
                    const short examsCant = 3;
                    const double examsPercentage = 0.60d;
                    double examsPartial; 
                    for(int i = 0; i < Curso.Count; i++){
                        if(Curso[i].StudentCode == codeSearch){
                            if(examsOption == 7.1 && examsNote >= 0 && examsNote <= 5.0){
                                Curso[i].Exams[0] = examsNote;
                                examsPartial = ((Curso[i].Exams[0]+Curso[i].Exams[1]+Curso[i].Exams[2])/examsCant)*examsPercentage;
                                Curso[i].ExamsFinal = examsPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addExams = false;
                            }else if(examsOption == 7.2 && examsNote >= 0 && examsNote <= 5.0){
                                Curso[i].Exams[1] = examsNote;
                                examsPartial = ((Curso[i].Exams[0]+Curso[i].Exams[1]+Curso[i].Exams[2])/examsCant)*examsPercentage;
                                Curso[i].ExamsFinal = examsPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addExams = false;
                            }else if(examsOption == 7.3 && examsNote >= 0 && examsNote <= 5.0){
                                Curso[i].Exams[2] = examsNote;
                                examsPartial = ((Curso[i].Exams[0]+Curso[i].Exams[1]+Curso[i].Exams[2])/examsCant)*examsPercentage;
                                Curso[i].ExamsFinal = examsPartial;
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addExams = false;
                            }else{
                                Console.WriteLine("Revise la opcion o la nota ingresada.");
                                Console.ReadKey();
                                Console.Clear();
                                found = true;
                                addExams = false;
                            }
                        }
                    if(!found){
                        Console.WriteLine("El código del estudiante no se encuentra en la lista");
                        Console.ReadKey();
                        Console.Clear();
                        addExams = false;
                    }
                    }
                }
            }else if(opcion == 8){
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0,-25} {1,-40} {2,5} {3,5} {4,5} {5,5} {6,5} {7,5} {8,5} {9,5} {10,5}", "Cod. Alumno", "Nombre Alumno", "Q1", "Q2", "Q3", "Q4", "T1", "T2", "P1", "P2", "P3");
                for(int i = 0; i < Curso.Count; i++){
                    Console.WriteLine("{0,-25} {1,-45} {2,40} {3,30} {4,20}", Curso[i].StudentCode, Curso[i].Name, Curso[i].Quizes[0], Curso[i].Quizes[1], Curso[i].Quizes[2], Curso[i].Quizes[3], Curso[i].Homework[0], Curso[i].Homework[1], Curso[i].Exams[0], Curso[i].Exams[1], Curso[i].Exams[2]);
                }
            }else if(opcion == 9){
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0,-25} {1,-40} {2,10} {3,10} {4,10} {4,10}", "Cod. Alumno", "Nombre Alumno", " Def. Quizes", "Def. Trabajos", "Def. Examanes", "Definitiva Materia");
                for(int i = 0; i < Curso.Count; i++){
                    double Definitiva = Curso[i].QuizFinal+Curso[i].HomeworkFinal+Curso[i].ExamsFinal;
                    Console.WriteLine("{0,-25} {1,-40} {2,10} {3,10} {4,10} {5,10}", Curso[i].StudentCode, Curso[i].Name, Curso[i].QuizFinal, Curso[i].HomeworkFinal, Curso[i].ExamsFinal, Definitiva);
                }
            }else if(opcion == 10){
                iniciar = false;
            }else{
                Console.WriteLine("Ingrese una opcion que se encuentre dentro del menu");
            }
        }
    }
}
