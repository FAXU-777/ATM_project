Console.Write("Enter number of students: " );
        
        int studentNumber = Convert.ToInt32(Console.ReadLine());
        
        string[] names = new string[studentNumber];
        int [] grades = new int [studentNumber];
        int avarageGrade = 0;
        int highestGrade = 0;
        
        
        for (int i = 1; i <=studentNumber; i++)
        {
            Console.Write("Student "+ i +" name: ");
            string name = Console.ReadLine();
            names[i - 1] = name;
            
            Console.Write("Enter "+name + "'s grade: ");
            string grade = Console.ReadLine();
            grades[i - 1] = Convert.ToInt32(grade); 
            Console.WriteLine();
        }
        int lowesGrade = grades[0];


        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i] + ": "+ grades[i]);
        }

        for (int i = 0; i < grades.Length; i++)
        {
            avarageGrade = avarageGrade + grades[i];
            
            if (highestGrade < grades[i])
            {
                highestGrade = grades[i];
            }
            if (grades[i] < lowesGrade)
            {
                lowesGrade = grades[i];
            }
            
            
        }
        Console.WriteLine("Avarage grade : " +avarageGrade/studentNumber);
        Console.WriteLine("The highest grade is: " + highestGrade);
        Console.WriteLine("The lowes grade is: "+lowesGrade);

    }