using MyLinkedLists;

namespace LinkedLists
{
    class Program
    {
        //Control console display
        static bool blnContinue = true;
        static LinkedList<Page> pageList;
        static LinkedList<Page> rp;

        static void Main(string[] args)
        {
            Book newBook = new Book("The Legendary Book of Super Cool Developers!", "Thabang Mosiea", 2022);
            Page[] bookPages = new Page[]{ new Page(C_SHARP_DATA),new Page(JAVA_DATA), new Page(PYTHON_DATA), new Page(JAVASCRIPT_DATA)};
            pageList = new LinkedList<Page>();

            foreach (Page p in bookPages)
            {
                pageList.AddLast(p);

            }
            
            newBook.addPages(bookPages);

            //Menu display
            do
                {
                Console.Clear();
                newBook.DisplayBook();
                Console.WriteLine();
                Console.Write("-------MENU PAGE-------");
                Console.Write("What language are you keen on reading up on today?\n");
                Console.Write("[Page 1] - C# (My Favourite!)\n");
                Console.Write("[Page 2] - Java\n");
                Console.Write("[Page 3] - Python\n");
                Console.WriteLine("[Page 4] - JavaScript\n");

                                                        Console.Write("[Click 'N'] - Next Page\n");
                Console.Write("[Click 'P'] - Previous Page\n");

                Console.Write("[Click 'X'] - Exit program\n");

                Console.WriteLine();

                char input = Console.ReadLine().ElementAt(0);


                switch (input)
                {


                    case 'P' or 'p':
                        {
                            newBook.selectDir(input,pageList.First);
                            //= newBook.selectDir(input);
                        }
                        break;

                    case 'N' or 'N':
                        {
                                newBook.selectDir(input,pageList.First);
                        }
                        break;

                    case 'X' or 'x':
                        {
                            System.Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please choose from the provided options");
                        break;
                }
            } while (blnContinue);

        }



        public static string C_SHARP_DATA = "C# (/si ʃɑːrp/ see sharp)[b] is a general-purpose, multi-paradigm programming language." +
            " C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented " +
            "(class-based), and component-oriented programming disciplines.[16]The C# programming language was designed by Anders Hejlsberg" +
            " from Microsoft in 2000 and was later approved as an international standard by Ecma (ECMA-334) in 2002 and ISO/IEC (ISO/IEC 23270)" +
            " in 2003. Microsoft introduced C# along with .NET Framework and Visual Studio, both of which were closed-source. At the time, Microsoft" +
            " had no open-source products. Four years later, in 2004, a free and open-source project called Mono began, providing a cross-platform" +
            " compiler and runtime environment for the C# programming language. A decade later, Microsoft released Visual Studio Code (code editor)," +
            " Roslyn (compiler), and the unified .NET platform (software framework), all of which support C# and are free, open-source, and cross-platform." +
            " Mono also joined Microsoft but was not merged into .NET.";




        private static string JAVA_DATA = "Java is a high-level, class-based, object-oriented programming language that is designed" +
            " to have as few implementation dependencies as possible. It is a general-purpose programming language intended to let " +
            "programmers write once, run anywhere (WORA),[17] meaning that compiled Java code can run on all platforms that support" +
            " Java without the need to recompile.[18] Java applications are typically compiled to bytecode that can run on any Java " +
            "virtual machine (JVM) regardless of the underlying computer architecture. The syntax of Java is similar to C and C++, but" +
            " has fewer low-level facilities than either of them. The Java runtime provides dynamic capabilities (such as reflection " +
            "and runtime code modification) that are typically not available in traditional compiled languages. As of 2019, Java was " +
            "one of the most popular programming languages in use according to GitHub,[19][20] particularly for client–server web" +
            "applications, with a reported 9 million developers.[21]Java was originally developed by James Gosling at Sun Microsystems" +
            " and released in May 1995 as a core component of Sun Microsystems' Java platform. The original and reference implementation " +
            "Java compilers, virtual machines, and class libraries were originally released by Sun under proprietary licenses. As of May 2007," +
            " in compliance with the specifications of the Java Community Process, Sun had relicensed most of its Java technologies under the" +
            " GPL-2.0-only license. Oracle offers its own HotSpot Java Virtual Machine, however the official reference implementation is the" +
            " OpenJDK JVM which is free open-source software and used by most developers and is the default JVM for almost all Linux distributions";


        private static string PYTHON_DATA = "Python is a high-level, interpreted, general-purpose programming language. " +
            "Its design philosophy emphasizes code readability with the use of significant indentation.Python is dynamically-typed" +
            "and garbage-collected.It supports multiple programming paradigms, including structured(particularly procedural), " +
            "object-oriented and functional programming.It is often described as a ''batteries included'' language due to its " +
            "comprehensive standard library.Guido van Rossum began working on Python in the late 1980s as a successor to the ABC" +
            " programming language and first released it in 1991 as Python 0.9.0.[35] Python 2.0 was released in 2000 and introduced " +
            "new features such as list comprehensions, cycle-detecting garbage collection, reference counting, and Unicode support." +
            "Python 3.0, released in 2008, was a major revision that is not completely backward-compatible with earlier versions. " +
            "Python 2 was discontinued with version 2.7.18 in 2020.Python consistently ranks as one of the most popular programming languages.";



        private static string JAVASCRIPT_DATA = "JavaScript (/ˈdʒɑːvəskrɪpt/),[10] often abbreviated JS, is a programming language that is one of " +
            "the core technologies of the World Wide Web, alongside HTML and CSS.[11] As of 2022, 98% of websites use JavaScript on the client side" +
            " for web page behavior,[12] often incorporating third-party libraries.[13] All major web browsers have a dedicated JavaScript engine to" +
            " execute the code on users' devices. JavaScript is a high-level, often just-in-time compiled language that conforms to the ECMAScript standard." +
            "[14] It has dynamic typing, prototype-based object-orientation, and first-class functions. It is multi-paradigm, supporting event-driven,functional," +
            " and imperative programming styles. It has application programming interfaces (APIs) for working with text, dates, regular expressions, standard data " +
            "structures, and the Document Object Model(DOM).";

    }
}


