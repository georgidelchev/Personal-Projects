using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class QuizChapters
    {
        QuizAnswersMenu chaptersMenu = new QuizAnswersMenu();
        ProgrammingQuizMainScreen bgn = new ProgrammingQuizMainScreen();
        BigTexts conditions = new BigTexts();

        public static int wrongAnswers;
        public static bool flag;
        public static bool musicFlag = true;

        public static string[] questions = new string[5];

        public static string[][] answers = new string[5][];

        public static int[] correctAnswers = new int[5];

        public static bool isJavaPicked = false;
        public static bool isCSharpPicked = false;
        public static bool isJavaScriptPicked = false;
        public static bool isPythonPicked = false;
        public static bool isHtml_CssPicked = false;
        public static bool isPhpPicked = false;
        public static bool isCPlusPlusPicked = false;
        public static bool isSqlPicked = false;
        public static bool isCPicked = false;
        public static bool isSwiftPicked = false;

        public static bool isFootballPicked = false;
        public static bool isBasketballPicked = false;
        public static bool isTennisPicked = false;
        public static bool isVolleyballPicked = false;

        public static bool isContinentsPicked = false;
        public static bool isPlantsPicked = false;
        public static bool isCitiesPicked = false;
        public static bool isCapitalsPicked = false;
        public static bool isCapitalsSecondPicked = false;
        public static bool isCapitalsThirdPicked = false;
        public static bool isCapitalsForthPicked = false;
        public static bool isCapitalsFifthPicked = false;
        public static bool isDesertsPicked = false;
        public static bool isMountainsPicked = false;
        public static bool isAtmospherePicked = false;
        public static bool isOceansPicked = false;

        public static bool isAudiPicked = false;
        public static bool isBMWPicked = false;
        public static bool isMercedesPicked = false;
        public static bool isPeugeotPicked = false;
        public static bool isCitroenPicked = false;
        public static bool isHondaPicked = false;
        public static bool isVWPicked = false;
        public static bool isFerrariPicked = false;
        public static bool isPaganiPicked = false;
        public static bool isBugattiPicked = false;
        public static bool isLamborghiniPicked = false;
        public static bool isPorschePicked = false;
        public static bool isToyotaPicked = false;
        public static bool isNissanPicked = false;
        public static bool isMazdaPicked = false;

        public static bool isCounterStrikePicked = false;
        public static bool isWorldOfWarcraftPicked = false;
        public static bool isMinecraftPicked = false;
        public static bool isLeagueOfLegendsPicked = false;
        public static bool isFortnitePicked = false;

        // Movies
        public static bool isHobbitPicked = false;
        public static bool isTheLordOfTheRingsPicked = false;
        public static bool isHarryPotterPicked = false;
        // Series
        public static bool isThe100Picked = false;
        public static bool isTheWalkingDeadPicked = false;
        public static bool isVanHelsingPicked = false;

        public static bool isAncientHistoryPicked = false;
        public static bool isMedievalHistoryPicked = false;
        public static bool isModernHistoryPicked = false;

        // PROGRAMMING QUIZ CHAPTERS:
        public void CSharpChapter()
        {
            Console.WriteLine("csharp");
            Thread.Sleep(2000);
            Console.Clear();

            answers[0] = new string[5]
            {
                "Oracle",
                "PHP",
                "Microsoft",
                "Visual Studio",
                "Microsystems"
            };
            answers[1] = new string[5]
            {
                "CSharp is only for Machine Learning.",
                "CSharp is object-oriented lang.",
                "Facebook owns CSharp.",
                "CSharp is Cascading-Styles-Sheets.",
                "Microsoft made it for 10 Months."
            };
            answers[2] = new string[5]
            {
                "False",
                "true",
                "True",
                "result",
                "RunTime Error"
            };
            answers[3] = new string[5]
            {
                "2001",
                "2002",
                "1999",
                "2000",
                "2003"
            };
            answers[4] = new string[5]
            {
                "Library",
                "Operating System",
                "Browser",
                "Language",
                "Class"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 2;
            correctAnswers[2] = 3;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] Who owns CSharp?";
            questions[1] = " [2] Which one is TRUE?";
            questions[2] = $" [3] What will be the output?{Environment.NewLine} int a = 5;{Environment.NewLine} string result = a <= 5 ? true.ToString() : false.ToString();{Environment.NewLine} Console.WriteLine(result);";
            questions[3] = " [4] When was first CSharp released?";
            questions[4] = " [5] What is - using System;?";

            isCSharpPicked = true;
            WholeLogic();
        }
        public void JavaChapter()
        {
            answers[0] = new string[5]
            {
                "1998'",
                "1994'",
                "2001'",
                "1996'",
                "1995'"
            };
            answers[1] = new string[5]
            {
                "Nancy Kane",
                "James Gosling",
                "Kierra Gentry",
                "Bradyn Kramer",
                "Gwendolyn York"
            };
            answers[2] = new string[5]
            {
                "Hyper-Text Language",
                "Statically-Typed",
                "Object-Oriented",
                "Based on C-style Syntax",
                "Almost purely Object-Oriented"
            };
            answers[3] = new string[5]
            {
                "Web Dev",
                "TV-Shows",
                "Making car parts",
                "Math Calculations",
                "Produce clothes"
            };
            answers[4] = new string[5]
            {
                "HTML",
                "Angular",
                "React",
                "RxJava",
                "Citroen"
            };

            correctAnswers[0] = 5;
            correctAnswers[1] = 2;
            correctAnswers[2] = 3;
            correctAnswers[3] = 1;
            correctAnswers[4] = 4;

            questions[0] = " [1] When was invented Java?";
            questions[1] = " [2] Who invented Java?";
            questions[2] = " [3] What type of language is Java?";
            questions[3] = " [4] For what is Java used mostly?";
            questions[4] = " [5] For which one is used Java?";

            isJavaPicked = true;
            WholeLogic();

        }
        public void JavaScriptChapter()
        {
            answers[0] = new string[5]
           {
                "<head>",
                "<.script>",
                "<body>",
                "<jscript>",
                "<script>"
           };
            answers[1] = new string[5]
            {
                "James Gosling",
                "Arnold Pennyies",
                "Brendan Eich",
                "Mark Cooper",
                "Elija Fox"
            };
            answers[2] = new string[5]
            {
                "Feeding the animals",
                "CPU's Making",
                "Mobile Apps",
                "Web Development",
                "Sorting Data"
            };
            answers[3] = new string[5]
            {
                "November 2, 2001'",
                "December 4, 1995'",
                "January 30, 1996'",
                "December 15, 1994'",
                "December 4, 1996'"
            };
            answers[4] = new string[5]
            {
                ".js .mjs",
                ".js .ijs",
                ".js .jsc",
                ".js .ujs",
                ".js .jscrpt"
            };

            correctAnswers[0] = 5;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 2;
            correctAnswers[4] = 1;

            questions[0] = " [1] What is the HTML tag for JavaScript?";
            questions[1] = " [2] Who invented JavaScript?";
            questions[2] = " [3] For what type of Development is JavaScript using usually?";
            questions[3] = " [4] When was released for the first time JavaScript?";
            questions[4] = " [5] What is the filename extensions for JavaScript?";

            isJavaScriptPicked = true;
            WholeLogic();
        }
        public void PythonChapter()
        {
            answers[0] = new string[5]
            {
                "2^63 - 1",
                "2^64 + 1",
                "2^62 - 1",
                "2^64 - 1",
                "2^65"
            };
            answers[1] = new string[5]
            {
                "'it's me'",
                "\"it's me\"",
                "\"\"it's me\"\"",
                "'it's' \"me\"",
                "'its'me"
            };
            answers[2] = new string[5]
            {
                "out('message')",
                "console.print(message)",
                "print(\"message\");",
                "print('message')",
                "Console.WriteLine(\"message\");"
            };
            answers[3] = new string[5]
            {
                "C++",
                "Java",
                "C",
                "C#",
                "Ruby"
            };
            answers[4] = new string[5]
            {
                "Game Development",
                "Making computer parts",
                "To store folders",
                "Machine Learning",
                "Web & Net Development",
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 1;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 5;

            questions[0] = " [1] What is the max value for int int Python?";
            questions[1] = " [3] What will you use to declare string: it's me";
            questions[2] = " [4] What is the syntax of printing an message?";
            questions[3] = " [5] What Language is used for writing Python?";
            questions[4] = " [2] Where is Python mostly used?";

            isPythonPicked = true;
            WholeLogic();
        }
        public void HTML_CssChapter()
        {
            answers[0] = new string[5]
            {
                "HyperText Markup Language & Cascading Style Sheets",
                "HyperTexting Markup Learning & Cassy Styles Sheets",
                "Hovered Texting Markup Loop & Car Stone Steve",
                "Home Text Mined Leaves & Counter Strike Shoot",
                "Heavy Text Markup Language & Colored Style Sheets"
            };
            answers[1] = new string[5]
            {
                "To connect computers",
                "To connect wireless unlimited machines",
                "To create documents (pages)",
                "To display memes",
                "To sell T-Shirts"
            };
            answers[2] = new string[5]
            {
                "To draw in Paint",
                "T-Shirt designs",
                "To Make games",
                "To Describing colors, layouts, fonts etc.",
                "To Run Browsers"
            };
            answers[3] = new string[5]
            {
                "HTML1",
                "HTML5",
                "HTML2",
                "HTML4",
                "HTML3"
            };
            answers[4] = new string[5]
            {
                "CSS1",
                "CSS2",
                "CSS4",
                "CSS5",
                "CSS3"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 2;
            correctAnswers[4] = 5;

            questions[0] = " [1] What is HTML & CSS?";
            questions[1] = " [2] For what is using HTML?";
            questions[2] = " [3] For what is using CSS?";
            questions[3] = " [4] What is the latest version of HTML?";
            questions[4] = " [5] What is the latest version of CSS?";

            isHtml_CssPicked = true;
            WholeLogic();
        }
        public void PhpChapter()
        {
            answers[0] = new string[5]
            {
                "The PHP configuration file, php.ini, is the final and most immediate way to affect PHP's functionality.",
                "The php.ini file is read each time PHP is initialized.",
                "Both of the above.",
                "The php.ini is not reading.",
                "None of the above."
            };
            answers[1] = new string[5]
            {
                "Methods",
                "Strings",
                "Arrays",
                "Objects",
                "Resources"
            };
            answers[2] = new string[5]
            {
                "Constants may be defined and accessed anywhere without regard to variable scoping rules.",
                "Once the Constants have been set, may not be redefined or undefined.",
                "Both of the above.",
                "Once the Constants have been set, may be redefined or undefined.",
                "None of the above."
            };
            answers[3] = new string[5]
            {
                "_FUNCTION_",
                " _FILE_",
                " _METHOD_",
                "_CLASS_",
                "_OBJECT_"
            };
            answers[4] = new string[5]
            {
                "array_slice()",
                "array_shift()",
                "array_search()",
                "array_reverse()",
                "array_copy();"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 5;
            correctAnswers[2] = 3;
            correctAnswers[3] = 3;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which of the following is true about php.ini file?";
            questions[1] = " [2] Which of the following type of variables are special variables that hold references to resources external to PHP (such as database connections)?";
            questions[2] = " [3] Which of the following is correct about constants vs variables in PHP";
            questions[3] = " [4] Which of the following magic constant of PHP returns class method name?";
            questions[4] = " [5] Which of the following function can be used to get an array in the reverse order?";

            isPhpPicked = true;
            WholeLogic();
        }
        public void CPlusPlusChapter()
        {
            answers[0] = new string[5]
            {
                "Developing the suites of a Game Tool",
                "Developing the animations of a Web Sites",
                "Producing pipes",
                "Making IDE-s",
                "Search engine"
            };
            answers[1] = new string[5]
            {
                "Only Object-Oriented",
                "Hybrid",
                "Using for Functional programming only",
                "Only Assembly lang.",
                "Only for ML"
            };
            answers[2] = new string[5]
            {
                "printf (\"Hello World\")",
                "System.out.println(\"Hello World\");",
                "print (\"Hello World\");",
                "Console.WriteLine(\"Hello World\");",
                "cout << \"Hello World\";"
            };
            answers[3] = new string[5]
            {
                "2001",
                "2002",
                "1985",
                "2000",
                "2003"
            };
            answers[4] = new string[5]
            {
                "Will Smith",
                "Anita Keujerc",
                "Bjorn Towards",
                "Bjarne Stroustrup",
                "John Tuple"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 2;
            correctAnswers[2] = 5;
            correctAnswers[3] = 3;
            correctAnswers[4] = 4;

            questions[0] = " [1] What C++ is used for?";
            questions[1] = " [2] What is the type of C++?";
            questions[2] = " [5] What is a correct syntax to output \"Hello World\" in C++?";
            questions[3] = " [4] When was first C++ released?";
            questions[4] = " [3] Who made C++?";

            isCPlusPlusPicked = true;
            WholeLogic();
        }
        public void SqlChapter()
        {
            answers[0] = new string[5]
            {
                "SQL statements are not case sensitive.",
                "SQL statements can be written on one or more lines.",
                "Clauses must be written on separate lines.",
                "Keywords cannot be split across lines.",
                "All of the above."
            };
            answers[1] = new string[5]
            {
                "They may modify the data type.",
                "They operate on single rows only and return one result per row.",
                "They accept arguments that could be a column or any expression.",
                "They cannot be nested.",
                "All of the above."
            };
            answers[2] = new string[5]
            {
                "ON clause is used to specify conditions or specify columns to join.",
                "ON clause makes the query easy to understand.",
                "ON clause does not allow three way joins.",
                "All of the above.",
                "None of the above."
            };
            answers[3] = new string[5]
            {
                "The WHERE clause",
                "The HAVING clause",
                "The FROM clause",
                "All of the above.",
                "Nothing of the above."
            };
            answers[4] = new string[5]
            {
                "You can update some rows in a table based on values from another table.",
                "If you try to update a record related to an integrity constraint, it raises an error.",
                "You can modify multiple columns.",
                "All of the above.",
                "Nothing of the above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 3;
            correctAnswers[3] = 4;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which of the following is not true about SQL statements?";
            questions[1] = " [2] Which of the following is not true about single row functions?";
            questions[2] = " [3] Which of the following is not true about the ON clause?";
            questions[3] = " [4] A subquery can be placed in which of the SQL clauses?";
            questions[4] = " [5] Which of the following is true about modifying rows in a table?";

            isSqlPicked = true;
            WholeLogic();
        }
        public void C_Chapter()
        {
            answers[0] = new string[5]
            {
                "$",
                "@",
                "_",
                ".",
                "="
            };
            answers[1] = new string[5]
            {
                "__FILE__",
                "__C++__",
                "__DATE__",
                "__TIME__",
                "All of the above."
            };
            answers[2] = new string[5]
            {
                "Declare a function",
                "Define a function",
                "Erase a function",
                "All of the above",
                "None of the above."
            };
            answers[3] = new string[5]
            {
                "malloc() and memalloc()",
                "memalloc()and alloc() ",
                "memalloc() and calloc()",
                "malloc() and calloc()",
                "Nothin from above."
            };
            answers[4] = new string[5]
            {
                "% / * = + -",
                "* / % = + -",
                "* / % + - =",
                " / * % - + =",
                "- + = * % /",
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 2;
            correctAnswers[2] = 1;
            correctAnswers[3] = 4;
            correctAnswers[4] = 3;

            questions[0] = " [1] Special symbol permitted with in the identifier name?";
            questions[1] = " [2] Choose the invalid predefined macro as per ANSI C.";
            questions[2] = " [3] The prototype of a function can be used to?";
            questions[3] = " [4] Which library functions help users to dynamically allocate memory?";
            questions[4] = " [5] The correct order of evaluation for the expression “z = x + y * z / 4 % 2 – 1”";

            isCPicked = true;
            WholeLogic();
        }
        public void SwiftChapter()
        {
            answers[0] = new string[5]
            {
                ".NET",
                "Microsoft",
                "Apple",
                "Scala",
                "Italy"
            };
            answers[1] = new string[5]
            {
                "2010",
                "2011",
                "2013",
                "2014",
                "2012"
            };
            answers[2] = new string[5]
            {
                ".swf",
                ".s",
                ".swift",
                ".sft",
                ".sw"
            };
            answers[3] = new string[5]
            {
                "Mac iOS apps",
                "Windows apps",
                "Linux apps",
                "assembly lang.",
                "Count digits"
            };
            answers[4] = new string[5]
            {
                "Software devs.com",
                "Windows",
                "PhP",
                "Microsoft",
                "Apple Inc."
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 4;
            correctAnswers[2] = 3;
            correctAnswers[3] = 1;
            correctAnswers[4] = 5;

            questions[0] = " [1] Who owns Swift?";
            questions[1] = " [2] Swift release date?";
            questions[2] = " [3] Swift file extension?";
            questions[3] = " [4] For what is Swift made?";
            questions[4] = " [5] Who made Swift?";

            isSwiftPicked = true;
            WholeLogic();
        }


        // SPORTS QUIZ CHAPTERS:
        public void FootballChapter()
        {
            answers[0] = new string[5]
            {
                "2",
                "4",
                "5",
                "3",
                "6"
            };
            answers[1] = new string[5]
            {
                "Brasil",
                "Argentina",
                "USA",
                "France",
                "Germany"
            };
            answers[2] = new string[5]
            {
                "1-0",
                "2-1",
                "2-3",
                "1-2",
                "4-2"
            };
            answers[3] = new string[5]
            {
                "4",
                "3",
                "1",
                "2",
                "5"
            };
            answers[4] = new string[5]
            {
                "[694] apps - [650] goals",
                "[624] apps - [687] goals",
                "[599] apps - [364] goals",
                "[690] apps - [660] goals",
                "[351] apps - [784] goals"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 4;
            correctAnswers[2] = 5;
            correctAnswers[3] = 3;
            correctAnswers[4] = 1;

            questions[0] = " [1] How many golden balls Ronaldo have?";
            questions[1] = " [2] Who won World Cup 2018?";
            questions[2] = " [3] What was the result of World Cup 2018 Final?";
            questions[3] = " [4] In how many clubs Messi played in his professional carrier?";
            questions[4] = " [5] How much apps-goals have Pele in his professional carrier?";

            isFootballPicked = true;
            WholeLogic();
        }
        public void BasketballChapter()
        {
            answers[0] = new string[5]
            {
                "Miami Heat",
                "Los Angeles Lakers",
                "Boston Celtics",
                "Denver Nuggets",
                "Los Angeles Clippers"
            };
            answers[1] = new string[5]
            {
                "Kareem Abdul-Jabbar",
                "Jack Sikma",
                "Hakeem Olajuwon",
                "Kobe",
                "Tim Duncan"
            };
            answers[2] = new string[5]
            {
                "Chris Bosh",
                "Kobe",
                "Dwyane Wade ",
                "Darko Milicic",
                "LeBron James"
            };
            answers[3] = new string[5]
            {
                "Utah Jazz",
                "Toronto Raptors",
                "Golden State Warriors",
                "Los Angeles Clippers",
                "Boston Celtics"
            };
            answers[4] = new string[5]
            {
                "Ben Wallace",
                "Shaquille O'Neal",
                "Wilt Chamberlain",
                "Bill Russell",
                "LeBron James"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 1;
            correctAnswers[2] = 5;
            correctAnswers[3] = 2;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which team has won most NBA championships??";
            questions[1] = " [2] Who holds the record for the most points scored over their career?";
            questions[2] = " [3] Which player was drafted #1 at the 2003 NBA Draft??";
            questions[3] = " [4] Which of these franchises never relocated?";
            questions[4] = " [5] Who holds the record for most rebounds in one season??";

            isBasketballPicked = true;
            WholeLogic();
        }
        public void TennisChapter()
        {
            answers[0] = new string[5]
            {
                "Equality",
                "Draw",
                "Equal",
                "Even Stevens",
                "Deuce"
            };
            answers[1] = new string[5]
            {
                "A trick shot",
                "A ball which is smashed into the net",
                "A ball which is not returned by the server's opponent",
                "A trick shot",
                "All from the above."
            };
            answers[2] = new string[5]
            {
                "1919",
                "1900",
                "1976",
                "1877",
                "1949"
            };
            answers[3] = new string[5]
            {
                "Grass",
                "Clay",
                "Stone",
                "Gravel",
                "Hardcourt"
            };
            answers[4] = new string[5]
            {
                "Boris Becker",
                "Roger Federer",
                "Andy Murray",
                "Novak Djokovic",
                "Grigor Dimitrov"
            };

            correctAnswers[0] = 5;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 1;
            correctAnswers[4] = 2;

            questions[0] = " [1] When the score is 40-40, what is it otherwise called?";
            questions[1] = " [2] What is an ace?";
            questions[2] = " [3] In which year did the Wimbledon Championships start?";
            questions[3] = " [4] The Wimbledon Championships are played on which surface?";
            questions[4] = " [5] Who won the 2017 Men's Singles at Wimbledon?";

            isTennisPicked = true;
            WholeLogic();
        }
        public void VolleyballChapter()
        {
            answers[0] = new string[5]
            {
                "6",
                "4",
                "2",
                "5",
                "3"
            };
            answers[1] = new string[5]
            {
                "Lacrosse",
                "Grass Ball",
                "CourtBall",
                "Volley Ball",
                "Mintonette"
            };
            answers[2] = new string[5]
            {
                "1912",
                "1895",
                "2004",
                "2005",
                "1995"
            };
            answers[3] = new string[5]
            {
                "Mathew Fin",
                "Elija Fox",
                "John A. Belstrad",
                "William G. Morgan",
                "Elijah C. Campwood"
            };
            answers[4] = new string[5]
            {
                "1954 / 1965",
                "1854 / 1856",
                "1949 / 1952",
                "1872 / 1918",
                "2000 / 2004"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 5;
            correctAnswers[2] = 2;
            correctAnswers[3] = 4;
            correctAnswers[4] = 3;

            questions[0] = " [1] How many people on each team are in the court?";
            questions[1] = " [2] What was the original name of volleyball?";
            questions[2] = " [3] When was volleyball created?";
            questions[3] = " [4] Who created volleyball?";
            questions[4] = " [5] When were the first volleyball World Championships held?";

            isTennisPicked = true;
            WholeLogic();
        }


        // GEOGRAPHY QUIZ CHAPTERS:
        public void Continents()
        {
            answers[0] = new string[5]
            {
                "Africa",
                "Asia",
                "North America",
                "Europe",
                "Australia"
            };
            answers[1] = new string[5]
            {
                "Plants",
                "Desert",
                "Ocean",
                "Sea",
                "IceLand"
            };
            answers[2] = new string[5]
            {
                "Asia",
                "NA",
                "Europe",
                "Africa",
                "SA"
            };
            answers[3] = new string[5]
            {
                "NA",
                "Europe",
                "Africa",
                "Asia",
                "SA"
            };
            answers[4] = new string[5]
            {
                "China",
                "India",
                "USA",
                "Indonesia",
                "Brazil"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 2;
            correctAnswers[2] = 4;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] Which continent is the largest?";
            questions[1] = " [2] For what type of continens is considered Antarctica?";
            questions[2] = " [3] Which Continent is the second most populated continent with 900 million people?";
            questions[3] = " [4] Which Continent is the most populated continent?";
            questions[4] = " [5] Which Country is the most populated country?";

            isContinentsPicked = true;
            WholeLogic();
        }
        public void Plants()
        {
            answers[0] = new string[5]
            {
                "The word “annual” means to occur every year.",
                "One that lives for more than two years",
                "This is a biennial plant.",
                "A plant that loses its leaves in winter is a deciduous plant.",
                "All of above."
            };
            answers[1] = new string[5]
            {
                "A plant uses its leaves to harness the sun’s energy.",
                "A plant uses its roots to draw up water and nutrients from the soil.",
                "Though water does travel up a plant’s stem.",
                "A plant’s flowers are used to attract insects.",
                "All of above."
            };
            answers[2] = new string[5]
            {
                "Though this may give you some idea of the tree’s age.",
                "Though this may give you some idea of the tree's age.",
                "Counting the number of leaves does not tell you the age of the tree.",
                "Each ring counts for one year of the tree’s life.",
                "All of above."
            };
            answers[3] = new string[5]
            {
                "Pollen is produced by the male parts of the flower.",
                "The stigma receives the pollen from the male parts of the flower.",
                "The male parts are the stamens, which produce pollen.",
                "The carpels are the female parts of the flower—they produce ovules, which eventually become seeds.",
                "All of above."
            };
            answers[4] = new string[5]
            {
                "Though they may be added to chocolate to give it a coffee flavor.",
                "Though chicory may be added to chocolate to give it a spicy flavor.",
                "Durum wheat is used to make pasta.",
                "Chocolate—whether white, milk, or dark—is made from cocoa beans.",
                "All of above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 2;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 4;

            questions[0] = " [1] What is an annual plant?";
            questions[1] = " [2] How does a plant get water from the soil?";
            questions[2] = " [3] How can you tell the age of most trees?";
            questions[3] = " [4] What are the male parts of a flower called?";
            questions[4] = " [5] What is chocolate made from?";

            isPlantsPicked = true;
            WholeLogic();
        }
        public void Cities()
        {
            answers[0] = new string[5]
            {
                "Bulgaria",
                "USA",
                "Brasil",
                "China",
                "India"
            };
            answers[1] = new string[5]
            {
                "Bulgaria",
                "USA",
                "Portugal",
                "Macedonia",
                "Turkey"
            };
            answers[2] = new string[5]
            {
                "Spain",
                "France",
                "Australia",
                "Portugal",
                "China"
            };
            answers[3] = new string[5]
            {
                "Libya",
                "Iran",
                "Irak",
                "Russia",
                "Korea"
            };
            answers[4] = new string[5]
            {
                "Mexico",
                "Brasil",
                "USA",
                "Portugal",
                "Canada"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 5;
            correctAnswers[3] = 1;
            correctAnswers[4] = 4;

            questions[0] = " [1] In which country is located New York?";
            questions[1] = " [2] In which country is located Sofia?";
            questions[2] = " [3] In which country is located Hong Kong?";
            questions[3] = " [4] In which country is located Tripoli?";
            questions[4] = " [5] In which country is located Lissabon?";

            isCitiesPicked = true;
            WholeLogic();
        }
        public void Capitals()
        {
            answers[0] = new string[5]
            {
                "Abidjan",
                "Yamoussoukro",
                "Abu Dhabi",
                "Abuja",
                "Accra"
            };
            answers[1] = new string[5]
            {
                "Adamstown",
                "Algiers",
                "Abuja",
                "Abu Dhabi",
                "Addis Ababa"
            };
            answers[2] = new string[5]
            {
                "Alofi",
                "Adamstown",
                "Amsterdam",
                "Amman",
                "Accra"
            };
            answers[3] = new string[5]
            {
                "Sana'a",
                "Amman",
                "Accra",
                "Addis Ababa",
                "Andorra la Vella"
            };
            answers[4] = new string[5]
            {
                "Abuja",
                "Yamoussoukro",
                "Algiers",
                "Amman",
                "Accra"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 2;
            correctAnswers[2] = 4;
            correctAnswers[3] = 1;
            correctAnswers[4] = 5;

            questions[0] = " [1] Which one is the capital of UAE(United Arab Emirates)?";
            questions[1] = " [2] Which one is the capital of Algeria?";
            questions[2] = " [3] Which one is the capital of Jordan?";
            questions[3] = " [4] Which one is the capital of Yemen?";
            questions[4] = " [5] Which one is the capital of Ghana?";

            isCapitalsPicked = true;
            WholeLogic();
        }
        public void CapitalsSecond()
        {
            answers[0] = new string[5]
            {
                "Andorra la Vella",
                "Avarua",
                "Antananarivo",
                "Ankara",
                "Bamako"
            };
            answers[1] = new string[5]
            {
                "Baku",
                "Ashgabat",
                "Azaz",
                "Avarua",
                "Athens"
            };
            answers[2] = new string[5]
            {
                "Avarua",
                "Belmopan",
                "Beirut",
                "Belgrade",
                "Berlin"
            };
            answers[3] = new string[5]
            {
                "Paris",
                "Beijing",
                "Ankara",
                "Baku",
                "Basseterre"
            };
            answers[4] = new string[5]
            {
                "Banjul",
                "Sofia",
                "Bern",
                "Bishkek",
                "Belgrade"
            };

            correctAnswers[0] = 4;
            correctAnswers[1] = 5;
            correctAnswers[2] = 4;
            correctAnswers[3] = 1;
            correctAnswers[4] = 2;

            questions[0] = " [1] Which one is the capital of Turkey?";
            questions[1] = " [2] Which one is the capital of Greece?";
            questions[2] = " [3] Which one is the capital of Serbia?";
            questions[3] = " [4] Which one is the capital of France?";
            questions[4] = " [5] Which one is the capital of Bulgaria?";

            isCapitalsSecondPicked = true;
            WholeLogic();
        }
        public void CapitalsThird()
        {
            answers[0] = new string[5]
            {
                "Bratislava",
                "Plymouth ",
                "Brussels",
                "Bridgetown",
                "Brazzaville"
            };
            answers[1] = new string[5]
            {
                "Canberra",
                "Cairo",
                "Buenos Aires",
                "Budapest",
                "Bucharest"
            };
            answers[2] = new string[5]
            {
                "Canberra",
                "Cairo",
                "Brasilia",
                "Budapest",
                "Bucharest"
            };
            answers[3] = new string[5]
            {
                "Canberra",
                "Brussels",
                "Bloemfontein",
                "Bishkek",
                "Bern"
            };
            answers[4] = new string[5]
            {
                "Cape Town ",
                "Berlin",
                "Bogota",
                "Bishkek",
                "Bern"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 5;
            correctAnswers[2] = 4;
            correctAnswers[3] = 1;
            correctAnswers[4] = 2;

            questions[0] = " [1] Which one is the capital of Belgium?";
            questions[1] = " [2] Which one is the capital of Romania?";
            questions[2] = " [3] Which one is the capital of Hungary?";
            questions[3] = " [4] Which one is the capital of Australia?";
            questions[4] = " [5] Which one is the capital of Germany?";

            isCapitalsThirdPicked = true;
            WholeLogic();
        }
        public void CapitalsForth()
        {
            answers[0] = new string[5]
            {
                "Conakry",
                "Sri Jayawardenepura Kotte",
                "Charlotte Amalie",
                "Podgorica",
                "Colombo"
            };
            answers[1] = new string[5]
            {
                "Dhaka",
                "Dili",
                "Damascus",
                "Porto-Novo",
                "Dakar"
            };
            answers[2] = new string[5]
            {
                "Dodoma",
                "Damascus",
                "Dakar",
                "Dushanbe",
                "Edinburgh of the Seven Seas"
            };
            answers[3] = new string[5]
            {
                "Lima",
                "London",
                "Lilongwe",
                "Libreville",
                "Luanda"
            };
            answers[4] = new string[5]
            {
                "Madrid",
                "Malabo",
                "Majuro",
                "Luxembourg",
                "London"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 5;
            correctAnswers[2] = 1;
            correctAnswers[3] = 4;
            correctAnswers[4] = 5;

            questions[0] = " [1] Which one is the capital of Sri Lanka?";
            questions[1] = " [2] Which one is the capital of Senegal?";
            questions[2] = " [3] Which one is the capital of Tanzania?";
            questions[3] = " [4] Which one is the capital of Gabon?";
            questions[4] = " [5] Which one is the capital of United Kingdom?";

            isCapitalsForthPicked = true;
            WholeLogic();
        }
        public void CapitalsFifth()
        {
            answers[0] = new string[5]
            {
                "Moscow",
                "Monaco",
                "Monrovia",
                "Montevideo",
                "Nassau"
            };
            answers[1] = new string[5]
            {
                "New York",
                "New Delhi",
                "Moroni",
                "Hong Kong",
                "Oslo"
            };
            answers[2] = new string[5]
            {
                "Pago Pago",
                "Ouagadougou",
                "Ottawa",
                "Palikir",
                "Oslo"
            };
            answers[3] = new string[5]
            {
                "Ouagadougou",
                "Panama City",
                "Palikir",
                "Paris",
                "Oranjestad"
            };
            answers[4] = new string[5]
            {
                "Port of Spain",
                "Prague",
                "Port-au-Prince",
                "Phnom Penh",
                "Port Louis"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 2;
            correctAnswers[2] = 5;
            correctAnswers[3] = 1;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which one is the capital of Russia?";
            questions[1] = " [2] Which one is the capital of India?";
            questions[2] = " [3] Which one is the capital of Norway?";
            questions[3] = " [4] Which one is the capital of Burkina Faso?";
            questions[4] = " [5] Which one is the capital of Cambodia?";

            isCapitalsFifthPicked = true;
            WholeLogic();
        }
        public void Deserts()
        {
            answers[0] = new string[5]
            {
                "Great Sandy",
                "Thar",
                "Kalahari",
                "Gobi",
                "All of above."
            };
            answers[1] = new string[5]
            {
                "Sahara",
                "Kalahari",
                "Namib",
                "Gobi",
                "All of above."
            };
            answers[2] = new string[5]
            {
                "Chihuahua",
                "Great Basin",
                "Great Sandy",
                "Atacama",
                "All of above."
            };
            answers[3] = new string[5]
            {
                "Sahara",
                "Atacama Desert",
                "Antarctica",
                "Namib",
                "All of above."
            };
            answers[4] = new string[5]
            {
                "Antarctica",
                "Sahara",
                "Gobi",
                "Chihuahua",
                "All of above."
            };

            correctAnswers[0] = 4;
            correctAnswers[1] = 3;
            correctAnswers[2] = 1;
            correctAnswers[3] = 2;
            correctAnswers[4] = 2;

            questions[0] = " [1] Which of these is NOT a hot desert?";
            questions[1] = " [2] Which coastal desert is found in southern Africa?";
            questions[2] = " [3] What is the largest desert in North America?";
            questions[3] = " [4] What is the driest place on Earth?";
            questions[4] = " [5] What is the world's largest hot desert?";

            isDesertsPicked = true;
            WholeLogic();
        }
        public void Mountains()
        {
            answers[0] = new string[5]
            {
                "Ural",
                "Pyrenees",
                "Tien Shan",
                "Appalachian",
                "All of above."
            };
            answers[1] = new string[5]
            {
                "Peak",
                "Valley",
                "Plateau",
                "Savanna",
                "All of above."
            };
            answers[2] = new string[5]
            {
                "Savanna",
                "Valley",
                "Snow Line",
                "Peak",
                "All of above."
            };
            answers[3] = new string[5]
            {
                "Block",
                "Fold",
                "Dome",
                "Summit",
                "All of above."
            };
            answers[4] = new string[5]
            {
                "Appalachian",
                "Atlas",
                "Aleutian",
                "Pyrenees",
                "All of above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 2;

            questions[0] = " [1] What mountain range separates Europe and Asia?";
            questions[1] = " [2] What word describes an area of high flat land";
            questions[2] = " [3] What is the highest part of a mountain?";
            questions[3] = " [4] Which of these is NOT a type of mountain?";
            questions[4] = " [5] Which of these mountain ranges is in Africa?";

            isMountainsPicked = true;
            WholeLogic();
        }
        public void Atmosphere()
        {
            answers[0] = new string[5]
            {
                "oxygen",
                "water vapor",
                "nitrogen",
                "ozone",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "oxygen",
                "water vapor",
                "ozone",
                "nitrogen",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "3 oxygen atoms",
                "1 oxygen atom",
                "3 nitrogen atoms",
                "2 oxygen atoms",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "thermosphere",
                "stratosphere",
                "mesosphere",
                "troposphere",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "stratosphere",
                "thermosphere",
                "troposphere",
                "exosphere",
                "Nothing from above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 4;
            correctAnswers[2] = 1;
            correctAnswers[3] = 2;
            correctAnswers[4] = 3;

            questions[0] = " [1] Which gas makes up 21% of the atmosphere?";
            questions[1] = " [2] Which gas makes up 78% of the atmosphere?";
            questions[2] = " [3] What is ozone?";
            questions[3] = " [4] Which layer of the atmosphere contains the ozone?";
            questions[4] = " [5] Which is the layer where weather occurs?";

            isAtmospherePicked = true;
            WholeLogic();
        }
        public void Oceans()
        {
            answers[0] = new string[5]
            {
                "70",
                "80",
                "71",
                "65",
                "21"
            };
            answers[1] = new string[5]
            {
                "Arctic",
                "Atlantic",
                "Indian",
                "Pacific ",
                "Southern"
            };
            answers[2] = new string[5]
            {
                "Atlantic",
                "Indian",
                "Arctic",
                "Pacific ",
                "Southern"
            };
            answers[3] = new string[5]
            {
                "Atlantic",
                "Indian",
                "Arctic",
                "Pacific ",
                "Southern"
            };
            answers[4] = new string[5]
            {
                "Atlantic",
                "Pacific ",
                "Indian",
                "Arctic",
                "Southern"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 4;
            correctAnswers[2] = 3;
            correctAnswers[3] = 5;
            correctAnswers[4] = 2;

            questions[0] = " [1] Oceans cover what percent of the Earth's surface?";
            questions[1] = " [2] Which is the largest ocean?";
            questions[2] = " [3] Which ocean lies between Europe and North America?";
            questions[3] = " [4] Which ocean is frozen for much of the year?";
            questions[4] = " [5] Which ocean is Hawaii in?";

            isOceansPicked = true;
            WholeLogic();
        }


        // AUTOMOBILES QUIZ CHAPTERS:
        public void Audi()
        {
            answers[0] = new string[5]
            {
                "Berlin",
                "Stuttgart",
                "Ingolstadt",
                "Wurzburg",
                "Wolfsburg"
            };
            answers[1] = new string[5]
            {
                "S6",
                "A8",
                "TTS",
                "Q8",
                "Q9"
            };
            answers[2] = new string[5]
            {
                "Toyota",
                "Ferrari",
                "BMW",
                "Mercedes",
                "VW"
            };
            answers[3] = new string[5]
            {
                "A6",
                "Q7",
                "Q8",
                "SQ5",
                "allroad"
            };
            answers[4] = new string[5]
            {
                "2008 Audi R8",
                "2013 Audi S8",
                "2013 Audi RS5 Convertible",
                "2019 Audi Q9",
                "2007 Audi S6"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 2;
            correctAnswers[2] = 5;
            correctAnswers[3] = 1;
            correctAnswers[4] = 2;

            questions[0] = " [1] In which German city is the Audi headquartered?";
            questions[1] = " [2] Which 2020 Audi model has the highest starting MSRP?";
            questions[2] = " [3] Since 1966, which company has owned the majority share of Audi?";
            questions[3] = " [4] Which Audi model does NOT have a rear hatch door?";
            questions[4] = " [5] Which Audi has the quickest 0-60 time?";

            isAudiPicked = true;
            WholeLogic();
        }
        public void BMW()
        {
            answers[0] = new string[5]
            {
                "Bavarian Motor Works",
                "Berlin Motor Works",
                "Brunswick Motor Works",
                "Borgholzhausen Motor Works",
                "Ben Motor Works"
            };
            answers[1] = new string[5]
            {
                "M8 Coupe",
                "Alpina B7 xDrive",
                "i8 Convertible",
                "x7 M50i",
                "Nothin from above."
            };
            answers[2] = new string[5]
            {
                "E46",
                "Z8",
                "1600",
                "2001C",
                "2800CS"
            };
            answers[3] = new string[5]
            {
                "Bentley",
                "Jaguar",
                "Ferrari",
                "Maserati",
                "Rolls-Royce"
            };
            answers[4] = new string[5]
            {
                "1981 BMW M1",
                "2013 BMW 335i xDrive",
                "2014 BMW X5 xDrive50i",
                "2000 BMW M5",
                "Nothin from above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 5;
            correctAnswers[4] = 3;

            questions[0] = " [1] What does BMW stand for?";
            questions[1] = " [2] Which 2020 BMW model has the highest starting MSRP?";
            questions[2] = " [3] Which is NOT a BMW model?";
            questions[3] = " [4] In 1998 BMW acquired which luxury car brand?";
            questions[4] = " [5] Which BMW model has the most horsepower?";

            isBMWPicked = true;
            WholeLogic();
        }
        public void Mercedes()
        {
            answers[0] = new string[5]
            {
                "SLK",
                "SLR",
                "None of these",
                "SLS",
                "G"
            };
            answers[1] = new string[5]
            {
                "GLK",
                "GLX",
                "GLS",
                "GLA",
                "GLE"
            };
            answers[2] = new string[5]
            {
                "Wagons",
                "Coupes",
                "SUVs",
                "Sedans",
                "Nothin from above."
            };
            answers[3] = new string[5]
            {
                "1926",
                "1905",
                "1900",
                "1889",
                "1903"
            };
            answers[4] = new string[5]
            {
                "2013",
                "2006",
                "1994",
                "2001",
                "1997"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 2;
            correctAnswers[2] = 3;
            correctAnswers[3] = 1;
            correctAnswers[4] = 5;

            questions[0] = " [1] Which model was created in partnership with McLaren Automotive?";
            questions[1] = " [2] Which is NOT a Class of Mercedes vehicles?";
            questions[2] = " [3] The Mercedes G-Class features which type of vehicles?";
            questions[3] = " [4] When was Mercedes-Benz founded?";
            questions[4] = " [5] What was the first production year for the Mercedes A-Class?";

            isMercedesPicked = true;
            WholeLogic();
        }
        public void Peugeot()
        {
            answers[0] = new string[5]
            {
                "1902",
                "1882",
                "1886",
                "1996",
                "1768"
            };
            answers[1] = new string[5]
            {
                "Poland",
                "England",
                "Germany",
                "France",
                "Bulgaria"
            };
            answers[2] = new string[5]
            {
                "Fiat",
                "Bugatti",
                "Citroen",
                "BMW",
                "Mercedes"
            };
            answers[3] = new string[5]
            {
                "206",
                "205",
                "302",
                "106",
                "400"
            };
            answers[4] = new string[5]
            {
                "2004",
                "2000",
                "2001",
                "2002",
                "2003"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 4;
            correctAnswers[2] = 3;
            correctAnswers[3] = 5;
            correctAnswers[4] = 1;

            questions[0] = " [1] When was Peugeot founded as a car manufacturer?";
            questions[1] = " [2] In what country is Peugeot headquartered?";
            questions[2] = " [3] In 1975, Peugeot aquired 100% of which company?";
            questions[3] = " [4] Which is NOT a Peugeot model?";
            questions[4] = " [5] In what year was the Peugeot 907 concept car revealed at the Paris Motor Show?";

            isPeugeotPicked = true;
            WholeLogic();
        }
        public void Citroen()
        {
            answers[0] = new string[5]
            {
                "Germany",
                "France",
                "Bulgaria",
                "England",
                "Spain"
            };
            answers[1] = new string[5]
            {
                "1919",
                "1925",
                "1914",
                "1954",
                "1922"
            };
            answers[2] = new string[5]
            {
                "Will",
                "Ouier",
                "Munier",
                "Andre",
                "Andrew"
            };
            answers[3] = new string[5]
            {
                "Audi",
                "Honda",
                "Mercedes",
                "VW",
                "PSA Group"
            };
            answers[4] = new string[5]
            {
                "lemon",
                "orange",
                "grapefruit",
                "tomato",
                "cucumber"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 3;
            correctAnswers[3] = 5;
            correctAnswers[4] = 1;

            questions[0] = " [1] In what country is Citroen headquartered?";
            questions[1] = " [2] Which is the year of founding Citroen?";
            questions[2] = " [3] What is the first name of Citroen's founder?";
            questions[3] = " [4] Who is Citroen owned by?";
            questions[4] = " [5] What does Citroen mean?";

            isCitroenPicked = true;
            WholeLogic();
        }
        public void Honda()
        {
            answers[0] = new string[5]
            {
                "HR-Z",
                "Del Sol",
                "Civic",
                "CR-Z",
                "S2000"
            };
            answers[1] = new string[5]
            {
                "2004",
                "1999",
                "2002",
                "2001",
                "2006"
            };
            answers[2] = new string[5]
            {
                "3 - Cylinder",
                "6 - Cylinder",
                "2 - Cylinder",
                "5 - Cylinder",
                "1 - Cylinder"
            };
            answers[3] = new string[5]
            {
                "2012 Honda CR-Z Mugen",
                "1997 Honda Prelude Type SH",
                "2013 Honda Accord Coupe EX-L",
                "2006 Honda Civic Si",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Honda",
                "Lexus",
                "Audi",
                "Acura",
                "Infiniti"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 5;
            correctAnswers[2] = 1;
            correctAnswers[3] = 3;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which car was the immediate successor to the Honda CR-X?";
            questions[1] = " [2] What was the first model year of the Honda Ridgeline?";
            questions[2] = " [3] The first generation Honda Insight had which gas-powered engine?";
            questions[3] = " [4] Which car has the fastest 0-60 time?";
            questions[4] = " [5] Which is the luxury division of Honda Motor Company?";

            isHondaPicked = true;
            WholeLogic();
        }
        public void VW()
        {
            answers[0] = new string[5]
            {
                "Passat",
                "Atlas",
                "Tiguan",
                "Arteon",
                "Phaeton"
            };
            answers[1] = new string[5]
            {
                "Phaeton",
                "Golf Mk2",
                "Scirocco",
                "Corrado",
                "Polo"
            };
            answers[2] = new string[5]
            {
                "Got Turbo Inside",
                "Grand Touring Induction",
                "Gas Turbo Instrument",
                "Gas Turbo Injection",
                "Grand Tourer Injection"
            };
            answers[3] = new string[5]
            {
                "Volvo Wagon",
                "People's Car",
                "National Wagon",
                "The Wagon",
                "Affordable Car"
            };
            answers[4] = new string[5]
            {
                "1930",
                "1946",
                "1947",
                "1948",
                "1941"
            };

            correctAnswers[0] = 4;
            correctAnswers[1] = 1;
            correctAnswers[2] = 5;
            correctAnswers[3] = 2;
            correctAnswers[4] = 1;

            questions[0] = " [1] Which 2020 Volkswagen model has the highest starting price?";
            questions[1] = " [2] Which VW model was NOT sold during the 1980's?";
            questions[2] = " [3] What does Volkswagen's \"GTi\" line stand for?";
            questions[3] = " [4] What does Volkswagen mean in German?";
            questions[4] = " [5] When was Volkswagen founded?";

            isVWPicked = true;
            WholeLogic();
        }
        public void Ferrari()
        {
            answers[0] = new string[5]
            {
                "Spyder",
                "Spider",
                "Spaeder",
                "Spoder",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "F30",
                "308 GTS",
                "F355 Spider",
                "612 Scaglietti",
                "F40"
            };
            answers[2] = new string[5]
            {
                "365 California",
                "Dino 206 GT",
                "F30",
                "550 Maranello",
                "500 Superfast"
            };
            answers[3] = new string[5]
            {
                "512 TR",
                "400i GT",
                "Mondial Quattrovalvole",
                "365 California",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "F430",
                "348 TB",
                "208 GTB",
                "246 GTS",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 5;
            correctAnswers[3] = 3;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which is the correct spelling that describes a convertible Ferrari?";
            questions[1] = " [2] Which of the following is NOT a Ferrari model?";
            questions[2] = " [3] Which Ferrari model is the oldest?";
            questions[3] = " [4] Which Ferrari does NOT feature V12 engine?";
            questions[4] = " [5] Which Ferrari has a V6 engine?";

            isFerrariPicked = true;
            WholeLogic();
        }
        public void Pagani()
        {
            answers[0] = new string[5]
            {
                "Zonda S",
                "Zonda roadster",
                "Zonda C21",
                "Zonda C12",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Lamborghini Countach",
                "Pagani f",
                "Alpine caravan",
                "Pagani 1",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "1979",
                "1975",
                "1969",
                "1977",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Pagani Huayra BC",
                "Pagani Huayra B.C",
                "Pagani tricolore",
                "Pagani zonda bc",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "78",
                "74",
                "77",
                "76",
                "Nothing from above."
            };

            correctAnswers[0] = 4;
            correctAnswers[1] = 3;
            correctAnswers[2] = 1;
            correctAnswers[3] = 2;
            correctAnswers[4] = 4;

            questions[0] = " [1] What was Paganis first car model";
            questions[1] = " [2] What was the first design of Horacio pagani";
            questions[2] = " [3] When it was created the f2?";
            questions[3] = " [4] Which is the newest model in pagani?";
            questions[4] = " [5] How old is Horacio pagani?";

            isPaganiPicked = true;
            WholeLogic();
        }
        public void Bugatti()
        {
            answers[0] = new string[5]
            {
                "Germany",
                "France",
                "Italy",
                "Spain",
                "USA"
            };
            answers[1] = new string[5]
            {
                "$2,250,000",
                "$1,000,000",
                "$1,500,000",
                "$2,500,000",
                "$2,300,000"
            };
            answers[2] = new string[5]
            {
                "Type 101",
                "Type 252",
                "Chiron",
                "Type 20000",
                "Type 18"
            };
            answers[3] = new string[5]
            {
                "211 mph",
                "225 mph",
                "258 mph",
                "261 mph",
                "283 mph"
            };
            answers[4] = new string[5]
            {
                "1002",
                "994",
                "1202",
                "976",
                "1001"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 5;

            questions[0] = " [1] In what country is Bugatti headquartered?";
            questions[1] = " [2] What is the approx. base price of a 2013 Bugatti Veyron 16.4 Grand Sport Vitesse?";
            questions[2] = " [3] Which is NOT a Bugatti model?";
            questions[3] = " [4] What is the top speed of a 2011 Bugatti Veyron Super Sport?";
            questions[4] = " [5] How much horsepower does a 2008 Bugatti Veyron 16.4 have?";

            isBugattiPicked = true;
            WholeLogic();
        }
        public void Lamborghini()
        {
            answers[0] = new string[5]
            {
                "Patrizio Lamborghini",
                "Alberto Lamborghini",
                "Ferruccio Lamborghini",
                "D'Angelo Lamborghini",
                "Patricius Lamborghini"
            };
            answers[1] = new string[5]
            {
                "1990",
                "1995",
                "1994",
                "2001",
                "1954"
            };
            answers[2] = new string[5]
            {
                "Huricane",
                "Ascari",
                "Islero",
                "Jalpa",
                "Urraco"
            };
            answers[3] = new string[5]
            {
                "Renault",
                "BMW",
                "Ford",
                "Mercedes",
                "Audi"
            };
            answers[4] = new string[5]
            {
                "8",
                "4",
                "5",
                "3",
                "1"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 1;
            correctAnswers[2] = 2;
            correctAnswers[3] = 5;
            correctAnswers[4] = 4;

            questions[0] = " [1] Who founded Lamborghini?";
            questions[1] = " [2] What was the last model year for the Lamborghini Countach?";
            questions[2] = " [3] Which of the following was NOT a Lamborghini model?";
            questions[3] = " [4] Which company acquired Lamborghini in 1998?";
            questions[4] = " [5] How many Lamborghini Veneno Roadsters were ever made?";

            isLamborghiniPicked = true;
            WholeLogic();
        }
        public void Porsche()
        {
            answers[0] = new string[5]
            {
                "360 Cisitalia",
                "912",
                "550 Spyder",
                "911",
                "Cayenne"
            };
            answers[1] = new string[5]
            {
                "1988-2001",
                "1985-1992",
                "1987-1988",
                "1986-1989",
                "1985-1990"
            };
            answers[2] = new string[5]
            {
                "Ferdinand Porsche",
                "Franz Porsche",
                "Kristof Porsche",
                "Leopold Porsche",
                "Hans Porsche"
            };
            answers[3] = new string[5]
            {
                "1925",
                "1933",
                "1940",
                "1945",
                "1930"
            };
            answers[4] = new string[5]
            {
                "Wolfsburg",
                "Wurzburg",
                "Ingolstadt",
                "Berlin",
                "Stuttgart"
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 4;
            correctAnswers[2] = 1;
            correctAnswers[3] = 5;
            correctAnswers[4] = 5;

            questions[0] = " [1] Which Porsche model did actor James Dean die in?";
            questions[1] = " [2] Which years was the Porsche 959 available for sale?";
            questions[2] = " [3] Who founded Porsche?";
            questions[3] = " [4] In which decade was Porsche founded?";
            questions[4] = " [5] In which German city is the Porsche headquartered?";

            isPorschePicked = true;
            WholeLogic();
        }
        public void Toyota()
        {
            answers[0] = new string[5]
            {
                "1966",
                "1930",
                "1920",
                "1935",
                "1956"
            };
            answers[1] = new string[5]
            {
                "2000-2004",
                "2005-2006",
                "1956-1967",
                "1999-2003",
                "1997-2001"
            };
            answers[2] = new string[5]
            {
                "32",
                "56",
                "79",
                "95",
                "102"
            };
            answers[3] = new string[5]
            {
                "Paseo",
                "Echo",
                "Previa",
                "Corolla",
                "Avensis"
            };
            answers[4] = new string[5]
            {
                "268",
                "275",
                "148",
                "199",
                "200"
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 4;
            correctAnswers[2] = 4;
            correctAnswers[3] = 2;
            correctAnswers[4] = 1;

            questions[0] = " [1] When was Toyota Motor Corporation founded?";
            questions[1] = " [2] In what years did the first generation Toyota Solara span?";
            questions[2] = " [3] How much more horsepower did the 1998 Toyota Supra Twin Turbo have over the base Supra model?";
            questions[3] = " [4] Which Toyota model was NOT sold during the 1990's?";
            questions[4] = " [5] How much horsepower does a 2014 Toyota Venza Limited have?";

            isToyotaPicked = true;
            WholeLogic();
        }
        public void Nissan()
        {
            answers[0] = new string[5]
            {
                "Lexus",
                "Infiniti",
                "Lincoln",
                "Acura",
                "Audi"
            };
            answers[1] = new string[5]
            {
                "SKLN",
                "NISSPORT",
                "NISMO",
                "NMCRT",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "SE",
                "GXE",
                "SV",
                "GLE",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "LEAF",
                "Kicks",
                "Rogue",
                "Altima",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "1991-1993",
                "1942-1957",
                "1902-1917",
                "1932-1957",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 3;
            correctAnswers[2] = 3;
            correctAnswers[3] = 2;
            correctAnswers[4] = 1;

            questions[0] = " [1] What is the luxury division of Nissan?";
            questions[1] = " [2] What is the motorsports and performance division of Nissan?";
            questions[2] = " [3] Which was NOT a a trim on the 2003 Nissan Maxima?";
            questions[3] = " [4] Which 2020 Nissan model has the lowest starting MSRP?";
            questions[4] = " [5] Which years was the Nissan NX available for sale?";

            isNissanPicked = true;
            WholeLogic();
        }
        public void Mazda()
        {
            answers[0] = new string[5]
            {
                "1956",
                "1920",
                "2944",
                "1902",
                "1900"
            };
            answers[1] = new string[5]
            {
                "BMW",
                "Audi",
                "Ford",
                "Mercedes",
                "Moskvic"
            };
            answers[2] = new string[5]
            {
                "1999-2000",
                "1956-1957",
                "1902-1904",
                "1990-1999",
                "1992-2003"
            };
            answers[3] = new string[5]
            {
                "263",
                "202",
                "257",
                "243",
                "266"
            };
            answers[4] = new string[5]
            {
                "Skytec",
                "EcoBoost",
                "SkyActiv",
                "Ecotec",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 3;
            correctAnswers[2] = 5;
            correctAnswers[3] = 1;
            correctAnswers[4] = 4;

            questions[0] = " [1] When was Mazda founded?";
            questions[1] = " [2] By 1996, which company had slowly acquired a 33.3% stake in Mazda?";
            questions[2] = " [3] In what years was the Mazda Millenia offered for sale?";
            questions[3] = " [4] How much horsepower does a 2013 MazdaSpeed3 have?";
            questions[4] = " [5] What is Mazdas name for its technologies that increase fuel efficiency and engine output?";

            isMazdaPicked = true;
            WholeLogic();
        }


        // GAMES QUIZ CHAPTERS:
        public void CounterStrike()
        {
            answers[0] = new string[5]
            {
                "2",
                "4",
                "5",
                "6",
                "7"
            };
            answers[1] = new string[5]
            {
                "200",
                "400",
                "500",
                "600",
                "100"
            };
            answers[2] = new string[5]
            {
                "3100",
                "2900",
                "3150",
                "3200",
                "1050"
            };
            answers[3] = new string[5]
            {
                "2",
                "1",
                "2",
                "5",
                "4"
            };
            answers[4] = new string[5]
            {
                "2",
                "1",
                "5",
                "6",
                "7"
            };

            correctAnswers[0] = 4;
            correctAnswers[1] = 1;
            correctAnswers[2] = 2;
            correctAnswers[3] = 5;
            correctAnswers[4] = 4;

            questions[0] = " [1] How many vehicles are there in de_dust2?";
            questions[1] = " [2] What's the cost of USP in the game?";
            questions[2] = " [3] What's the price of M4A1-S?";
            questions[3] = " [4] How many trains are there on the A site of de_train?";
            questions[4] = " [5] How many balloons are there in the Overpass party site?";

            isCounterStrikePicked = true;
            WholeLogic();
        }
        public void WorldOfWarcraft()
        {
            answers[0] = new string[5]
            {
                "Dragonmaw",
                "Warsong",
                "Bloodfang",
                "Frostwolf",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Desolace",
                "Silithus",
                "Uldum",
                "Tanaris",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Piccolo of the Flaming Fire",
                "Flute of the Ancients",
                "Sun-Lute of the Phoenix King",
                "Haunted War Drum",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Vaelastrasz",
                "Caelestrasz",
                "Afrasastrasz",
                "Tyranastrasz",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Achal hecta",
                "Dioniss aca",
                "Heckt corta",
                "Acheon kor",
                "Nothing from above."
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 4;
            correctAnswers[2] = 1;
            correctAnswers[3] = 4;
            correctAnswers[4] = 2;

            questions[0] = " [1] Which of the following is not an Orc clan?";
            questions[1] = " [2] What is the name of the desert that surrounds the Caverns of Time?";
            questions[2] = " [3] Which musical trinket could be used to invoke spontaneous dancing in others against their will?";
            questions[3] = " [4] What is the name of the red dragon whose skull is on display in the Hall of Explorers?";
            questions[4] = " [5] What phrase means 'Safe journey' in the language of the draenei?";

            isWorldOfWarcraftPicked = true;
            WholeLogic();
        }
        public void Minecraft()
        {
            answers[0] = new string[5]
            {
                "The End",
                "The Start",
                "Narnia",
                "Beanotown",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "You have to buy them",
                "You have to find a giant chest and then make it smaller",
                "Put 2 chests next to each other",
                "Put 3 chests next to each other",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "5",
                "2",
                "3",
                "1",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Spiders",
                "Cows",
                "Ocelots",
                "The dark",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "A turnip",
                "A pumpkin",
                "A cabbage",
                "A potato",
                "Nothing from above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 2;

            questions[0] = " [1] Which dimension do the Endermen come from?";
            questions[1] = " [2] How do you make a large chest?";
            questions[2] = " [3] How many blocks of iron ore does it take to make one iron ingot?";
            questions[3] = " [4] What are Creepers scared of?";
            questions[4] = " [5] What can you wear to stop an Enderman attacking you?";

            isMinecraftPicked = true;
            WholeLogic();
        }
        public void LeagueOfLegends()
        {
            answers[0] = new string[5]
            {
                "2010",
                "2011",
                "1012",
                "2008",
                "2009"
            };
            answers[1] = new string[5]
            {
                "Activision",
                "Capcom",
                "Riot Games",
                "BlueStack",
                "Origin"
            };
            answers[2] = new string[5]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };
            answers[3] = new string[5]
            {
                "poros",
                "pigs",
                "donkeys",
                "unicorns",
                "mermaids"
            };
            answers[4] = new string[5]
            {
                "Akali",
                "Braum",
                "Teemo",
                "Lissandra",
                "Corki"
            };

            correctAnswers[0] = 5;
            correctAnswers[1] = 3;
            correctAnswers[2] = 3;
            correctAnswers[3] = 1;
            correctAnswers[4] = 4;

            questions[0] = " [1] When was the online game \"League of Legends\" released?";
            questions[1] = " [2] Which video game company developed the game \"League of Legends ?\"";
            questions[2] = " [3] How many lanes are there in the Summoner's Rift map of the game \"League of Legends ?\"";
            questions[3] = " [4] What animals are seen in the Howling Abyss map of the game \"League of Legends ?\"";
            questions[4] = " [5] Who joins Serylda and Avarosa as the third sister in the \"League of Legends\" Three Sisters triad?";

            isLeagueOfLegendsPicked = true;
            WholeLogic();
        }
        public void Fortnite()
        {
            answers[0] = new string[5]
            {
                "$10",
                "$60",
                "$19",
                "$22",
                "free"
            };
            answers[1] = new string[5]
            {
                "Ninja",
                "Teemo",
                "Stampylongnose",
                "Oli",
                "Ali-A"
            };
            answers[2] = new string[5]
            {
                "Submarine",
                "Shopping cart",
                "Rocket",
                "F-35",
                "Baloon"
            };
            answers[3] = new string[5]
            {
                "Massive nuke hit",
                "World War 3",
                "USA Attack",
                "Meteor hit",
                "Zombie Apocalypse"
            };
            answers[4] = new string[5]
            {
                "For Resources",
                "For Food",
                "For Transport",
                "For Partner",
                "For Weapon"
            };

            correctAnswers[0] = 5;
            correctAnswers[1] = 3;
            correctAnswers[2] = 2;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] How much does Fortnite Battle Royale cost?";
            questions[1] = " [2] Which of the following professional gamers is not best known for his Fortnite prowess?";
            questions[2] = " [3] Which of the following is an available vehicle in Fortnite?";
            questions[3] = " [4] What happened to Dusty Depot in Season 4?";
            questions[4] = " [5] What’s the purpose of llamas within Fortnite?";

            isFortnitePicked = true;
            WholeLogic();
        }


        // MOVIES/SERIES CHAPTERS:
        public void Hobbit()
        {
            answers[0] = new string[5]
            {
                "Crookhollow Bend",
                "Bag End",
                "Brandywine End",
                "Lothlorien",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "They explode.",
                "Their strength is tripled.",
                "They turn to stone.",
                "They become invisible.",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Precious",
                "Darling",
                "Sting",
                "Goblinkiller",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Gandalf",
                "Thorin",
                "Bilbo",
                "Bard",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Elrond",
                "Smaug",
                "Gandalf",
                "Celeborn",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 3;
            correctAnswers[2] = 1;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] What is the name of Bilbo’s hillside home?";
            questions[1] = " [2] What happens to trolls when they are exposed to daylight?";
            questions[2] = " [3] What is Gollum’s name for his ring?";
            questions[3] = " [4] Who kills Smaug?";
            questions[4] = " [5] Who is the master of Rivendell?";

            isHobbitPicked = true;
            WholeLogic();
        }
        public void TheLordOfTheRings()
        {
            answers[0] = new string[5]
            {
                "100",
                "111",
                "115",
                "121",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Aragorn",
                "Boromir",
                "Saruman",
                "Gandalf",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Sam",
                "Aragorn",
                "Frodo",
                "Elrond",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "short sword",
                "horse",
                "ponny",
                "chain mail armor",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Saruman",
                "Sauron",
                "Gandalf",
                "Denethor",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 1;
            correctAnswers[2] = 3;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] Bilbo Baggins celebrates which bday?";
            questions[1] = " [2] The mysterious Strider is really?";
            questions[2] = " [3] At Rivendell, who suggests that Frodo take the Ring to Mordor?";
            questions[3] = " [4] Mithril was a gift to Frodo from Bilbo, what is it?";
            questions[4] = " [5] The Uruk-hai bear the white hand of?";

            isTheLordOfTheRingsPicked = true;
            WholeLogic();
        }
        public void HarryPotter()
        {
            answers[0] = new string[5]
            {
                "owl",
                "dog",
                "toad",
                "cat",
                "Nothin from above."
            };
            answers[1] = new string[5]
            {
                "Thomas",
                "Tremaine",
                "Trevor",
                "Terry",
                "Nothin from above."
            };
            answers[2] = new string[5]
            {
                "Hermione",
                "Ron",
                "Harry",
                "Luna",
                "Nothin from above."
            };
            answers[3] = new string[5]
            {
                "Molly Weasley",
                "Rubeus Hagrid",
                "Sirius Black",
                "Albus Dumbledore",
                "Nothin from above."
            };
            answers[4] = new string[5]
            {
                "Eagle",
                "Scops",
                "Barn",
                "Snowy",
                "Nothin from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 3;
            correctAnswers[2] = 1;
            correctAnswers[3] = 2;
            correctAnswers[4] = 4;

            questions[0] = " [1] Which one of these pets was not officially allowed at Hogwarts?";
            questions[1] = " [2] What was the name of Neville Longbottom’s toad?";
            questions[2] = " [3] Who helped Neville look for his toad on the Hogwarts Express in Philosopher’s Stone?";
            questions[3] = " [4] Who bought Harry’s owl, Hedwig for him?";
            questions[4] = " [5] What type of owl was Hedwig?";

            isHarryPotterPicked = true;
            WholeLogic();
        }
        public void The100()
        {
            answers[0] = new string[5]
            {
                "Two weeks",
                "Three months",
                "One month",
                "Six weeks",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Harper McIntyre",
                "Finn Collins",
                "John Murphy",
                "Jasper Jordan",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Marcus Kane",
                "Abigail Griffin",
                "Thelonius Jaha",
                "Charles Pike",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "62",
                "124",
                "300",
                "320",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Ten hours",
                "Eight hours",
                "Six hours",
                "Five hours",
                "Nothing from above."
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 3;
            correctAnswers[2] = 1;
            correctAnswers[3] = 4;
            correctAnswers[4] = 2;

            questions[0] = " [1] How much oxygen did sending the 100 to the ground provide the Ark in Season 1?";
            questions[1] = " [2] Which member of the 100’s father was floated for stealing medicine?";
            questions[2] = " [3] Who was the first Chancellor of Camp Jaha?";
            questions[3] = " [4] How many people died in the culling on the Ark?";
            questions[4] = " [5] How long is the walk between Camp Jaha and Mt. Weather?";

            isThe100Picked = true;
            WholeLogic();
        }
        public void TheWalkingDead()
        {
            answers[0] = new string[5]
            {
                "Baseball Bat",
                "Rock",
                "Gun",
                "Shovel",
                "Brick"
            };
            answers[1] = new string[5]
            {
                "Chester",
                "Milton",
                "Peter",
                "Joseph",
                "Henry"
            };
            answers[2] = new string[5]
            {
                "Germany",
                "Japan",
                "China",
                "England",
                "France"
            };
            answers[3] = new string[5]
            {
                "A walker",
                "A butterfly",
                "Rick",
                "A deer",
                "A bird"
            };
            answers[4] = new string[5]
            {
                "Penny",
                "Eloise",
                "Caroline",
                "Penelope",
                "Becca"
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 2;
            correctAnswers[2] = 5;
            correctAnswers[3] = 4;
            correctAnswers[4] = 1;

            questions[0] = " [1] What does Rick use to kill his first walker?";
            questions[1] = " [2] What’s the name of the scientist in Woodbury?";
            questions[2] = " [3] Which country did Edwin Jenner say had come close to finding a cure?";
            questions[3] = " [4] What is Carl looking at right before he gets shot?";
            questions[4] = " [5] What is the name of the Governor’s daughter?";

            isTheWalkingDeadPicked = true;
            WholeLogic();
        }
        public void VanHelsing()
        {
            answers[0] = new string[5]
            {
                "Nirvana",
                "Pearl Jam",
                "Radiohead",
                "The Rolling Stones",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Bob",
                "Balthazar",
                "Gustov",
                "Scab",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Seattle",
                "Portland",
                "Spokane",
                "Salem",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Toe",
                "Ear",
                "Teeth",
                "Finger",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Pineapple",
                "Pears",
                "Peaches",
                "Applesauce",
                "Nothing from above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 2;
            correctAnswers[2] = 2;
            correctAnswers[3] = 4;
            correctAnswers[4] = 3;

            questions[0] = " [1] Mohamad wears a T-shirt showcasing the name of what band?";
            questions[1] = " [2] What was the name of the vampire who killed Vanessa on the first day of The Rising?";
            questions[2] = " [3] When we first meet The Resistance, they're based out of what city?";
            questions[3] = " [4] What body part is removed from the victims of the mystery killer?";
            questions[4] = " [5] What canned fruit did Vanessa and Mohamad enjoy when they investigated her old apartment?";

            isVanHelsingPicked = true;
            WholeLogic();
        }


        // HISTORY CHAPTERS:
        public void AncientHistory()
        {
            answers[0] = new string[5]
            {
                "Memphis",
                "Thebes",
                "Alexandria",
                "Baltimore",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Nero",
                "Caligula",
                "Caesar Augustus",
                "Julius Caesar",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "Samos",
                "Crete",
                "Olympia",
                "Rhodes",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Yu",
                "Qi",
                "Tang",
                "Shun",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "5",
                "2",
                "1",
                "3",
                "Nothing from above."
            };

            correctAnswers[0] = 1;
            correctAnswers[1] = 4;
            correctAnswers[2] = 2;
            correctAnswers[3] = 1;
            correctAnswers[4] = 3;

            questions[0] = " [1] What was the first capital of ancient Egypt?";
            questions[1] = " [2] What Roman Emperor was once captured by pirates and held for a 12,000 gold-piece ransom?";
            questions[2] = " [3] On what island did ancient Greek civilization originate?";
            questions[3] = " [4] Who is considered the founder of the Xia Dynasty in ancient China?";
            questions[4] = " [5] How many of the Seven Wonders of the Ancient World still exist?";

            isAncientHistoryPicked = true;
            WholeLogic();
        }
        public void MedievalHistory()
        {
            answers[0] = new string[5]
            {
                "The Hundred Years’ War",
                "The First Crusade",
                "The Peace of God movement",
                "The Great Schism",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "Chretien de Troyes",
                "William of Newburgh",
                "Geoffrey of Monmouth",
                "Gildas",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "One fifth",
                "Three quarters",
                "One tenth",
                "One third",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Naples",
                "Paris",
                "Avignon",
                "Rome",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Henry III",
                "Edward the Confessor",
                "John",
                "Edward I",
                "Nothing from above."
            };

            correctAnswers[0] = 2;
            correctAnswers[1] = 3;
            correctAnswers[2] = 4;
            correctAnswers[3] = 3;
            correctAnswers[4] = 1;

            questions[0] = " [1] Which international event was started by Pope Urban II’s sermon at Clermont in 1095?";
            questions[1] = " [2] Which 12th-century historian wrote the first detailed account of King Arthur?";
            questions[2] = " [3] What proportion of the English population is estimated to have been killed by the Black Death in 1348-9?";
            questions[3] = " [4] Where did the popes spend much of the 14th century?";
            questions[4] = " [5] Which English king rebuilt Westminster Abbey in the 13th century?";

            isMedievalHistoryPicked = true;
            WholeLogic();
        }
        public void ModernHistory()
        {
            answers[0] = new string[5]
            {
                "Korean War",
                "Yalta Conference",
                "Cuban Missile Crisis",
                "Serbian Standoff",
                "Nothing from above."
            };
            answers[1] = new string[5]
            {
                "1920",
                "1954",
                "1925",
                "1900",
                "Nothing from above."
            };
            answers[2] = new string[5]
            {
                "1965",
                "1969",
                "1986",
                "1911",
                "Nothing from above."
            };
            answers[3] = new string[5]
            {
                "Israel",
                "Russia",
                "Pakistan",
                "India",
                "Nothing from above."
            };
            answers[4] = new string[5]
            {
                "Bank Robber",
                "Soldier",
                "Doctor",
                "Preacher",
                "Nothing from above."
            };

            correctAnswers[0] = 3;
            correctAnswers[1] = 1;
            correctAnswers[2] = 2;
            correctAnswers[3] = 4;
            correctAnswers[4] = 3;

            questions[0] = " [1] What incident in 1962 nearly led to a nuclear confrontation between the U.S. and Russia?";
            questions[1] = " [2] What year did women receive the right to vote in the United States?";
            questions[2] = " [3] What year did the first man walk on the Moon?";
            questions[3] = " [4] What nation exploded its first nuclear bomb in the Rajasthan Desert in 1974?";
            questions[4] = " [5] In 1849, Elizabeth Blackwell became the first female _______?";

            isModernHistoryPicked = true;
            WholeLogic();
        }


        public void WholeLogic()
        {
            wrongAnswers = 0;
            Console.WriteLine();
            Console.WriteLine($"{questions[0]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");
            chaptersMenu.ChaptersOptionsMenu();
            flag = true;

            while (ProgrammingQuizMainScreen.selected != correctAnswers[0]) // first answer
            {
                conditions.WrongAnswer();
                wrongAnswers++;
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"{questions[0]} {Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");

                if (wrongAnswers > 2)
                {
                    TooManyWrongAnswers();
                    break;
                }

                chaptersMenu.ChaptersOptionsMenu();
            }

            if (flag)
            {
                QuizAnswersMenu.counter++;
                conditions.CorrectAnswer();
                Thread.Sleep(2000);
                Console.Clear();

                wrongAnswers = 0;
                Console.WriteLine();
                Console.WriteLine($"{questions[1]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");
                chaptersMenu.ChaptersOptionsMenu();

                while (ProgrammingQuizMainScreen.selected != correctAnswers[1]) // second answer
                {
                    conditions.WrongAnswer();
                    wrongAnswers++;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{questions[1]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");

                    if (wrongAnswers > 2)
                    {
                        TooManyWrongAnswers();
                        break;
                    }

                    chaptersMenu.ChaptersOptionsMenu();
                }

                if (flag)
                {
                    QuizAnswersMenu.counter++;

                    conditions.CorrectAnswer();
                    Thread.Sleep(2000);
                    Console.Clear();

                    wrongAnswers = 0;
                    Console.WriteLine();
                    Console.WriteLine($"{questions[2]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");
                    chaptersMenu.ChaptersOptionsMenu();

                    while (ProgrammingQuizMainScreen.selected != correctAnswers[2]) // third answer
                    {
                        conditions.WrongAnswer();
                        wrongAnswers++;
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine($"{questions[2]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");

                        if (wrongAnswers > 2)
                        {
                            TooManyWrongAnswers();
                            break;
                        }

                        chaptersMenu.ChaptersOptionsMenu();
                    }

                    if (flag)
                    {
                        QuizAnswersMenu.counter++;

                        conditions.CorrectAnswer();
                        Thread.Sleep(2000);
                        Console.Clear();

                        wrongAnswers = 0;
                        Console.WriteLine();
                        Console.WriteLine($"{questions[3]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");
                        chaptersMenu.ChaptersOptionsMenu();

                        while (ProgrammingQuizMainScreen.selected != correctAnswers[3]) // forth answer
                        {
                            conditions.WrongAnswer();
                            wrongAnswers++;
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine($"{questions[3]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");

                            if (wrongAnswers > 2)
                            {
                                TooManyWrongAnswers();
                                break;
                            }

                            chaptersMenu.ChaptersOptionsMenu();
                        }

                        if (flag)
                        {
                            QuizAnswersMenu.counter++;

                            conditions.CorrectAnswer();
                            Thread.Sleep(2000);
                            Console.Clear();

                            wrongAnswers = 0;
                            Console.WriteLine();
                            Console.WriteLine($"{questions[4]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");
                            chaptersMenu.ChaptersOptionsMenu();

                            while (ProgrammingQuizMainScreen.selected != correctAnswers[4]) // fifth answer
                            {
                                conditions.WrongAnswer();
                                wrongAnswers++;
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine($"{questions[4]}{Environment.NewLine} [{wrongAnswers}/2] Wrong Answers!");

                                if (wrongAnswers > 2)
                                {
                                    TooManyWrongAnswers();
                                    break;
                                }

                                chaptersMenu.ChaptersOptionsMenu();
                            }

                            if (flag)
                            {
                                conditions.CorrectAnswer();
                                Thread.Sleep(2000);
                                Console.Clear();
                                ProgrammingQuizMainScreen.selected = 1;

                                if (isCSharpPicked)
                                {
                                    ProgrammingQuizMainScreen.isCSharpCompleted = true;
                                }
                                if (isJavaPicked)
                                {
                                    ProgrammingQuizMainScreen.isJavaCompleted = true;
                                }
                                if (isJavaScriptPicked)
                                {
                                    ProgrammingQuizMainScreen.isJavaScriptCompleted = true;
                                }
                                if (isPythonPicked)
                                {
                                    ProgrammingQuizMainScreen.isPythonCompleted = true;
                                }
                                if (isHtml_CssPicked)
                                {
                                    ProgrammingQuizMainScreen.isHTML_CSSCompleted = true;
                                }
                                if (isPhpPicked)
                                {
                                    ProgrammingQuizMainScreen.isPHPCompleted = true;
                                }
                                if (isCPlusPlusPicked)
                                {
                                    ProgrammingQuizMainScreen.isCPlusPlusCompleted = true;
                                }
                                if (isSqlPicked)
                                {
                                    ProgrammingQuizMainScreen.isSqlCompleted = true;
                                }
                                if (isCPicked)
                                {
                                    ProgrammingQuizMainScreen.isC_Completed = true;
                                }
                                if (isSwiftPicked)
                                {
                                    ProgrammingQuizMainScreen.isSwiftCompleted = true;
                                }


                                if (isFootballPicked)
                                {
                                    ProgrammingQuizMainScreen.isFootballCompleted = true;
                                }
                                if (isBasketballPicked)
                                {
                                    ProgrammingQuizMainScreen.isBasketballCompleted = true;
                                }
                                if (isTennisPicked)
                                {
                                    ProgrammingQuizMainScreen.isTennisCompleted = true;
                                }
                                if (isVolleyballPicked)
                                {
                                    ProgrammingQuizMainScreen.isVolleyballCompleted = true;
                                }


                                if (isContinentsPicked)
                                {
                                    ProgrammingQuizMainScreen.isContinentsCompleted = true;
                                }
                                if (isPlantsPicked)
                                {
                                    ProgrammingQuizMainScreen.isPlantsCompleted = true;
                                }
                                if (isCitiesPicked)
                                {
                                    ProgrammingQuizMainScreen.isCitiesCompleted = true;
                                }
                                if (isCapitalsPicked)
                                {
                                    ProgrammingQuizMainScreen.isCapitalsCompleted = true;
                                }
                                if (isCapitalsSecondPicked)
                                {
                                    ProgrammingQuizMainScreen.isCapitalsSecondCompleted = true;
                                }
                                if (isCapitalsThirdPicked)
                                {
                                    ProgrammingQuizMainScreen.isCapitalsThirdCompleted = true;
                                }
                                if (isCapitalsForthPicked)
                                {
                                    ProgrammingQuizMainScreen.isCapitalsForthCompleted = true;
                                }
                                if (isCapitalsFifthPicked)
                                {
                                    ProgrammingQuizMainScreen.isCapitalsFifthCompleted = true;
                                }
                                if (isDesertsPicked)
                                {
                                    ProgrammingQuizMainScreen.isDesertsCompleted = true;
                                }
                                if (isMountainsPicked)
                                {
                                    ProgrammingQuizMainScreen.isMountainsCompleted = true;
                                }
                                if (isAtmospherePicked)
                                {
                                    ProgrammingQuizMainScreen.isAtmosphereCompleted = true;
                                }
                                if (isOceansPicked)
                                {
                                    ProgrammingQuizMainScreen.isOceansCompleted = true;
                                }


                                if (isAudiPicked)
                                {
                                    ProgrammingQuizMainScreen.isAudiCompleted = true;
                                }
                                if (isBMWPicked)
                                {
                                    ProgrammingQuizMainScreen.isBMWCompleted = true;
                                }
                                if (isMercedesPicked)
                                {
                                    ProgrammingQuizMainScreen.isMercedesCompleted = true;
                                }
                                if (isPeugeotPicked)
                                {
                                    ProgrammingQuizMainScreen.isPeugeotCompleted = true;
                                }
                                if (isCitroenPicked)
                                {
                                    ProgrammingQuizMainScreen.isCitroenCompleted = true;
                                }
                                if (isHondaPicked)
                                {
                                    ProgrammingQuizMainScreen.isHondaCompleted = true;
                                }
                                if (isVWPicked)
                                {
                                    ProgrammingQuizMainScreen.isVWCompleted = true;
                                }
                                if (isFerrariPicked)
                                {
                                    ProgrammingQuizMainScreen.isFerrariCompleted = true;
                                }
                                if (isPaganiPicked)
                                {
                                    ProgrammingQuizMainScreen.isPaganiCompleted = true;
                                }
                                if (isBugattiPicked)
                                {
                                    ProgrammingQuizMainScreen.isBugattiCompleted = true;
                                }
                                if (isLamborghiniPicked)
                                {
                                    ProgrammingQuizMainScreen.isLamborghiniCompleted = true;
                                }
                                if (isPorschePicked)
                                {
                                    ProgrammingQuizMainScreen.isPorscheCompleted = true;
                                }
                                if (isToyotaPicked)
                                {
                                    ProgrammingQuizMainScreen.isToyotaPCompleted = true;
                                }
                                if (isNissanPicked)
                                {
                                    ProgrammingQuizMainScreen.isNissanCompleted = true;
                                }
                                if (isMazdaPicked)
                                {
                                    ProgrammingQuizMainScreen.isMazdaCompleted = true;
                                }


                                if (isCounterStrikePicked)
                                {
                                    ProgrammingQuizMainScreen.isCounterStrikePCompleted = true;
                                }
                                if (isWorldOfWarcraftPicked)
                                {
                                    ProgrammingQuizMainScreen.isWorldOfWarcraftCompleted = true;
                                }
                                if (isMinecraftPicked)
                                {
                                    ProgrammingQuizMainScreen.isMinecraftCompleted = true;
                                }
                                if (isLeagueOfLegendsPicked)
                                {
                                    ProgrammingQuizMainScreen.isLeagueOfLegendsCompleted = true;
                                }
                                if (isFortnitePicked)
                                {
                                    ProgrammingQuizMainScreen.isFortniteCompleted = true;
                                }


                                if (isHobbitPicked)
                                {
                                    ProgrammingQuizMainScreen.isHobbitCompleted = true;
                                }
                                if (isTheLordOfTheRingsPicked)
                                {
                                    ProgrammingQuizMainScreen.isTheLordOfTheRingsCompleted = true;
                                }
                                if (isHarryPotterPicked)
                                {
                                    ProgrammingQuizMainScreen.isHarryPotterCompleted = true;
                                }
                                if (isThe100Picked)
                                {
                                    ProgrammingQuizMainScreen.isThe100Completed = true;
                                }
                                if (isTheWalkingDeadPicked)
                                {
                                    ProgrammingQuizMainScreen.isTheWalkingDeadCompleted = true;
                                }
                                if (isVanHelsingPicked)
                                {
                                    ProgrammingQuizMainScreen.isVanHelsingCompleted = true;
                                }


                                if (isAncientHistoryPicked)
                                {
                                    ProgrammingQuizMainScreen.isAncientHistoryCompleted = true;
                                }
                                if (isMedievalHistoryPicked)
                                {
                                    ProgrammingQuizMainScreen.isMedievalHistoryCompleted = true;
                                }
                                if (isModernHistoryPicked)
                                {
                                    ProgrammingQuizMainScreen.isModernHistoryCompleted = true;
                                }

                                QuizAnswersMenu.counter = 1;

                                if (ProgrammingQuizMainScreen.isProgrammingQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.programmingQuizCompletedChapters++;
                                    bgn.ProgrammingQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isSportsQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.sportsQuizCompletedChapters++;
                                    bgn.SportsQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isGeographyQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.geographyQuizCompletedChapters++;
                                    bgn.GeographyQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isAutomobilesQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.automobilesQuizCompletedChapters++;
                                    bgn.AutomobilesQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isGamesQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.gamesQuizCompletedChapters++;
                                    bgn.GamesQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isMoviesQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.moviesQuizCompletedChapters++;
                                    bgn.MoviesQuizStartingScreen();
                                }
                                if (ProgrammingQuizMainScreen.isHistoryQuizPicked)
                                {
                                    ProgrammingQuizMainScreen.historyQuizCompletedChapters++;
                                    bgn.HistoryQuizStartingScreen();
                                }
                            }
                        }
                    }
                }
            }
        }
        public void TooManyWrongAnswers()
        {
            Console.Clear();
            Console.WriteLine("Too many wrong answers!");
            Thread.Sleep(2500);
            Console.Clear();
            flag = false;
            ProgrammingQuizMainScreen.selected = 1;
            QuizAnswersMenu.counter = 1;

            if (ProgrammingQuizMainScreen.isProgrammingQuizPicked)
            {
                bgn.ProgrammingQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isSportsQuizPicked)
            {
                bgn.SportsQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isGeographyQuizPicked)
            {
                bgn.GeographyQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isAutomobilesQuizPicked)
            {
                bgn.AutomobilesQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isGamesQuizPicked)
            {
                bgn.GamesQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isMoviesQuizPicked)
            {
                bgn.MoviesQuizStartingScreen();
            }
            if (ProgrammingQuizMainScreen.isHistoryQuizPicked)
            {
                bgn.HistoryQuizStartingScreen();
            }
        }
    }
}
