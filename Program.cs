


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        // // Practice 1 დაწერეთ კონსოლ აპლიკაცია სადაც მომხმარებელს ექნება საშუალება შეიტანოს მთელი რიცხვი, პროგრამამ უნდა გაარკვიოს ეს რიცხვი ლუწია თუ კენტი და იმის მიხედვით დაბეჭდოს შესაბამისი შეტყობინება. პროგრამა უნდა გამოიყურებოდეს შემდეგნაირად :
        // Console.WriteLine("Enter integer number: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // string output = number % 2 == 0 ? $"Entered number {number} is even" : $"Entered number {number} is odd";
        // Console.WriteLine(output);


        // // Practice 2 დაწერეთ კონსოლ აპლიკაცია სადაც მომხმარებელს ექნება საშუალება შეიტანოს სამი რიცხვი მორიგეობით, პროგრამა კი დაუბეჭდავს შემოტანილი პარამეტრების გათვალისწინებით შესაძლებელია თუ არა ეს სამი რიცხვი იყოს სამკუთხედის გვერდები. პროგრამა უნდა გამოიყურებოდეს შემდეგნაირად :
        // int numberOfedges = 3;
        // int[] edges = new int[numberOfedges];

        // for(int i = 0; i < edges.Length; i++)
        // {
        //     Console.WriteLine("Enter number: ");
        //     int num = Convert.ToInt32(Console.ReadLine());
        //     edges[i] += num;
        // }

        // Array.Sort(edges);

        // if(edges[0] + edges[1] > edges[2])
        // {
        //     Console.WriteLine("This should be a triangle");
        // }
        // else
        // {
        //     Console.WriteLine("This should not be a triangle");
        // }





/////////////////////////////////////////////////////////////////// // Practice 5 დავწეროთ კონსოლ აპლიკაცია სადაც გადავცემთ დაბადების დღეს და თვეს და დაგვიბრუნებს ჩვენს ზოდიაქოს. //////////////////////////////////////////////////////////////////





        // // Practice 4 დავწეროთ კონსოლ აპლიკაცია სადაც მომხმარებელი შეიტანს დაბადების წელს და ეტყვის ჩინური კალენდრის მიხედვით რის წელიწადშია დაბადებული.
        // Console.Write("enter a birth year: ");
        // int year = Convert.ToInt32(Console.ReadLine());
        
        // switch(year % 12)
        // {
        //     case 1: Console.WriteLine("ვირთხის");
        //     break;
        //     case 2: Console.WriteLine("ხარის");
        //     break;
        //     case 3: Console.WriteLine("ვეფხვის");
        //     break;
        //     case 4: Console.WriteLine("კურდღლის");
        //     break;
        //     case 5: Console.WriteLine("დრაკონის");
        //     break;
        //     case 6: Console.WriteLine("გველის");
        //     break;
        //     case 7: Console.WriteLine("ცხენის");
        //     break;
        //     case 8: Console.WriteLine("თხის");
        //     break;
        //     case 9: Console.WriteLine("მაიმუნის");
        //     break;
        //     case 10: Console.WriteLine("მამლის");
        //     break;
        //     case 11: Console.WriteLine("ძაღლის");
        //     break;
        //     case 12: Console.WriteLine("ტახის");
        //     break;
        //     default: Console.WriteLine("enter the correct birth year");
        //     break;
        // }


        // // Practice 3 დაწერეთ კონსოლ აპლიკაცია სადაც მომხმარებელს ექნება საშუალება შეიტანოს რიცხვი, ხოლო პროგრამა დაბეჭდავს მის კვადრატულ ხარისხსს.(მოიძიეთ გუგლში ფუნქცია რითი შეიძლება რიცხვის ახარისხება).პროგრამა უნდა გამოიყურებოდეს შემდეგნაირად :
        // Console.WriteLine("Enter number: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int pow = num * num;
        // Console.WriteLine($"the pow of the entered number is {pow} ");


        // // Practice 3 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს 1 დან ამ რიცხვის ჩათვლით ყველა რიცხვის კუბს
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // for(int i = 1; i <= number; i++)
        // {
        //     Console.WriteLine($"{i} cubed is {i * i * i}");
        // }


        // // Practice 2 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს 1 დან ამ რიცხვის ჩათვლით ყველა რიცხვის ჯამს
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int sum = 0;

        // for(int i = 0; i <= number; i++)
        // {
        //     sum += i;
        // }
        // Console.WriteLine($"Sum from 1 to {number} is {sum}");



        // // Practice 7 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს ამ მთელი რიცხვის რაოდენობის სტრიქონებიან ფლოიდის სამკუთხედს შედგენილს მხოლოდ 0 ებით და 1 ებით( ფლოიდის სამკუთხედი გამოიყურება შემდეგნრად)
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int[] numbers = new int[number+1];
        // numbers[0] = 0;
        // numbers[1] = numbers[2] = 1;

        // for(int i = 0; i < number - 1; i++)
        // {
        //     numbers[i+2] = numbers[i + 1] + numbers[i];
        // }
        // foreach (int integer in numbers)
        // {
        //     Console.Write($"{integer} ");
        // }


        // // Practice 4 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი რიცხვი და შემდეგ დაბეჭდავს 1 დან ამ რიცხვამდე კენტი რიცხვების ჯამს
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int sum = 0;
        // for(int i = 0; i <= number; i++)
        // {
        //     if(i % 2 == 1)
        //     {
        //         sum += i;
        //     }
        // }
        // Console.Write($"Sum of odd numbers from 1 to {number} is {sum}");






        // // Practice 8 დავწეროთ კონსოლ აპლიკაცია, რომელიც მთელ დადებით რიცხვებს გადაიყვანს ორობითში, არ გამოიყენოთ Convert კლასი გარდაქმნისათვის.
        // Console.Write("Enter a number: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int quotient = num;
        // int reminder = 0;
        // List<int> reminders = new List<int>();
        // do
        // {
        //     reminders.Add(quotient % 2);
        //     quotient /= 2;
        // }
        // while(quotient > 0);
        // reminders.Reverse();
        // string binaryString = string.Join("", reminders); 
        // int binaryNum = Convert.ToInt32(binaryString);
        // Console.WriteLine($"decimal {num} in binary is: {binaryNum}");





        // // Practice 6 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მთელი დადებითი რიცხვი და ბოლოს დაბეჭდავს ამ რიცხვის გამყოფებს.
        // Console.Write("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // List<int> divisiors = new List<int>();

        // for(int i = 1; i <= number; i++)
        // {
        //     if(number % i == 0)
        //     {
        //         divisiors.Add(i);
        //     }
        // }
        // Console.Write($"divisiors of {number} are: ");
        // foreach(int div in divisiors)
        // {
        //     Console.Write($"{div} ");
        // }


        // // Practice 1 დაწერეთ კონსოლ აპლიკაცია, რომელიც დაითვლის 0 დან 10 მდე რიცხვების ჯამს და დაბეჭდავს ამ შედეგს
        // int number = 10;
        // int sum = 0;
        // for(int i = 0; i <= number; i++)
        // {
        //     sum += i;
        // }
        // Console.WriteLine($"sum from 0 to {number} is {sum}");


        
        // // Practice 5 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს, ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოს დაბეჭდოს მისი ყველა უნიკალური ელემენტი (უნიკალურია ელემენტი რომელიც მხოლოდ ერთხელ გვხდება მასივში)
        // Console.Write("enter the size of array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());
        // int[] massive = new int[arraySize];
        // List<int> uniqueList = new List<int>();

        // for(int i = 0; i < massive.Length; i++)
        // {
        //     Console.Write($"Enter number for index {i}: ");
        //     massive[i] = Convert.ToInt32(Console.ReadLine());
        // }
           
        // for(int i = 0; i < massive.Length; i++)
        // {
        //     int count = 0;
        //     for(int j = 0; j < massive.Length; j++)
        //     {
        //         if(massive[i] == massive[j])
        //         {
        //             count++;
        //         }
        //     }
        //     if (count == 1)
        //     {
        //         uniqueList.Add(massive[i]);
        //     }
        // }
        // Console.Write("unique numbers are: ");
        // foreach(int unique in uniqueList)
        // {
        //     Console.Write($"{unique} ");
        // }





        // // Practice 2 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს, ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოდ დაბეჭდოს მასივი შებრუნებული მიმდევრობით.
        // Console.Write("enter the size of array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());
        // int[] massive = new int[arraySize];

        // for(int i = 0; i < arraySize; i++)
        // {
        //     Console.Write($"Enter number for index {i}: ");
        //     massive[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("here is your array in reverse order");

        // for(int i = massive.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(massive[i]);
        // }

        // // ან

        // Array.Reverse(massive);

        // foreach(int single in massive)
        // {
        //     Console.WriteLine($"{single} ");
        // }




        // // Practice 3 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს, ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოდ დაბეჭდოს მასივის ელემენტების ჯამი
        // Console.Write("enter the size of array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());
        // int[] massive = new int[arraySize];
        // int arraySum = 0;

        // for(int i = 0; i < arraySize; i++)
        // {
        //     Console.Write($"Enter number for index {i}: ");
        //     massive[i] = Convert.ToInt32(Console.ReadLine());
        //     arraySum += massive[i]; //
        // }
        // Console.Write("Sum of array elements is: {0}", arraySum); //

        // // ან 
        // arraySum = massive.Sum();
        // Console.Write("Sum of array elements is: {0}", arraySum);



        // // Practice 4 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს, ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოს დაბეჭდოს მასივის ელემენტების ნამრავლი.
        // Console.Write("enter the size of array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());
        // int[] massive = new int[arraySize];
        // int product = 1;

        // for(int i = 0; i < massive.Length; i++)
        // {
        //     Console.Write($"Enter number for index {i}: ");
        //     massive[i] = Convert.ToInt32(Console.ReadLine());
        //     product *= massive[i];
        // }
        // Console.WriteLine(string.Concat("product of array elements is: ", product));





        // // Practice 1 დაწერეთ კონსოლ აპლიკაცია, რომელიც მომხმარებელს მოსთხოვს შეიტანოს მასივის ზომა და შექმნის ამ ზომის მასივს, ასევე მომხმარებელმა უნდა შეძლოს მასივის ყველა ელემენტის შეტანა და პროგრამამ უნდა გადაავსოს მასივი შემოტანილი ინფორმაციით. საბოლოოდ დაბეჭდოს მასივის ყველა ელემენტი
        // Console.Write("enter the size of array: ");
        // int arraySize = Convert.ToInt32(Console.ReadLine());
        // int[] massive = new int[arraySize];

        // for(int i = 0; i < arraySize; i++)
        // {
        //     Console.Write($"Enter number for index {i}: ");
        //     massive[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // foreach(int single in massive)
        // {
        //     Console.Write($"{single} ");
        // }



        // // Practice 2 დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომლიც პარამეტრად მიიღებს სტრინგს და დაბეჭდავს მას უკუღმა (თქვენი გადასაწყვეტია იუზერს შეაყვანინებთ თუ არა ინფუთს). მაგ: Hello -> olleH
        // Console.Write("Enter a string: ");
        // string input = Console.ReadLine();
        // string reversedInput = "";

        // Method 1
        // for(int i = input.Length - 1; i >= 0; i--)
        // {
        //     reversedInput += input[i];
        // }
        // foreach(char str in reversedInput)
        // {
        //     Console.Write($"{str}");
        // }


        // // Method 2
        // for(int i = input.Length - 1; i >= 0; i--)
        // {
        //     Console.Write(input[i]);
        // }


        // // Method 3
        // Console.Write("Enter a string: ");
        // string input = Console.ReadLine();
        // char[] charArray = input.ToCharArray();
        // Array.Reverse(charArray);
        // string result = new string(charArray);
        // Console.WriteLine(result);




        // // Practice 4 დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია რომელიც პარამეტრად მიიღებს სტრინგს და დააბრუნებს რიცხვს, რომელიც აღნიშნავს სტრინგში სიტყვების რაოდენობას. დაწერეთ მეორე ფუნქცია, რომელიც დაბეჭდავს ამ რიცხვს.
        // int count = 0;
        // string sentence = "use only this one";
        // char[] chars = sentence.ToCharArray();
        // for(int i = 0; i < chars.Length; i++)
        // {
        //     if(chars[i].Equals(' '))
        //     {
        //         count++;
        //     }
        // }
        // Console.WriteLine($"The number of words are: {count + 1}");







        // // Practice 1 დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პარამეტრად მიიღებს ტექსტს (თქვენ გადაწყვიტეთ იუზერის ინფუთს მიიღებთ თუ არა) და დააბრუნებს ხმოვნების ან თანხმოვების რაოდენობას, ხმოვანი დაბრუნდება თუ თანხმოვანი მეთოდს უნდა გაყვეს პარამეტრად, გულისხმობის პრიპნციპით უნდა იყოს ხმოვანი. შექმენით მეორე ფუნქცია რომელიც შესაბამისად დაბეჭდავს მხოლოდ ხმოვნებს ან თანხმოვნებს იმავე პრინციპით. Method input: “Hello, world!”
        // char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        // Console.Write("enter a string: ");
        // string input = Console.ReadLine();
        // int vowelsCount = 0;
        // int consonant = 0;

        // foreach(char single in input.ToLower())
        // {
        //     for(int i = 0; i < vowels.Length; i++)
        //     {
        //         if(single.Equals(vowels[i]))
        //         {
        //             Console.WriteLine($"{single} ");
        //             vowelsCount++;
        //         }
        //     }
        // }
        // Console.WriteLine();
        // Console.WriteLine($"count of vowels is {vowelsCount}");
        // Console.WriteLine("---------------------------");
        
        // foreach(char single in input.ToLower())
        // {
        //     if((single >= 'a' && single <= 'z') && (single != 'a' && single != 'e' && single != 'i' && single != 'o' && single != 'u'))
        //     {
        //         Console.WriteLine($"{single} ");
        //         consonant++;
        //     }
        // }
        // Console.WriteLine();
        // Console.WriteLine($"count of consonant is {consonant}");





        // // Practice 3 დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქცია, რომელიც პარამეტრად მიიღებს სტრინგს და დაბეჭდავს მას გამოყოფილს სფეისებით. მაგ: hello -> H E L L O
        // Console.Write("enter a string: ");
        // string input = Console.ReadLine().ToUpper();

        // char[] charArray = input.ToCharArray();
        // foreach(char single in charArray)
        // {
        //     Console.Write($"{single} ");
        // }



        // // Practice 5 დაწერეთ კონსოლ აპლიკაცია, შექმენით ფუნქციები, რომელსაც პარამეტრად გადაეწოდება სტრინგი. პირველი დააბრუნებს სტრინგში ასოების რაოდენობას, მე-2-ე სტრინგში რიცხვების რაოდენობას, შექმენით კიდევ ერთი ფუნქცია, რომელიც ზემოთ აღწერილ 2 დაბრუნებულ პარამეტრს და დამატებით ორიგინალ ტექსტს, იღებს არგუმენტად და ბეჭდავს მათ. მაგ: Hello 1 ! - > letters: 5 , numbers: 1, Others: 3 Method input: “Hello 1 !” 
        // Console.Write("Enter a string: ");
        // string input = Console.ReadLine();
        // int length = NumberOfChars(input);
        // int count = NumberOfNumbers(input);
        // string returnText = ReturnText(length, count, input);
        // Console.WriteLine(returnText);

        // int i = 0;
        // for(; i < 5;)
        // {
        //     // Console.WriteLine(i);
        //     i++;
        // }
        // Console.WriteLine(i);

        // int i = 5;
        // Console.WriteLine(++i);
        // Console.WriteLine(i++);
        // Console.WriteLine(i);

        // Console.WriteLine((double)2.3 + (double)2.8);




        // int i = 5;
        // if ((i++ > 0) || (i++ > 0))
        // {
        //     Console.WriteLine(i);
        // }

        // if ((i++ > 0) | (i++ > 0))
        // {
        //     Console.WriteLine(i);
        // }

        // if ((i++ > 0) && (i++ > 0))
        // {
        //     Console.WriteLine(i);
        // }

        // if ((i++ > 0) & (i++ > 0))
        // {
        //     Console.WriteLine(i);
        // }

        Console.WriteLine($"size of int = {sizeof(float)}");
        Console.WriteLine($"int.MinValue = {int.MinValue}");
        Console.WriteLine($"int.MinValue = {int.MinValue}");

        Console.WriteLine($"float.MinValue = {float.MinValue}");
        Console.WriteLine($"float.MinValue = {float.MinValue}");

        Console.WriteLine($"double.MinValue = {double.MinValue}");
        Console.WriteLine($"double.MinValue = {double.MinValue}");

    }
    static int NumberOfChars(string singleString)
    {
        return singleString.Count(char.IsLetter);
    }
    static int NumberOfNumbers(string singleString)
    {
        int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int count = 0;
        for(int i = 0; i < singleString.Length; i++)
        {
            if(char.IsDigit(singleString[i]))
            {
                count++;
            }
        }
        return count;
    }
    static string ReturnText(int length, int numbers, string text)
    {
        int others = text.Length - length - numbers;
        return $"{text} -> Letters: {length}, Numbers: {numbers}, Others: {others}";
    }
}
