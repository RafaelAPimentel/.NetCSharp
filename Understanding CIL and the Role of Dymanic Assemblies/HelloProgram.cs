 using System;

class Program {
    //This class gets compiled to create exe file in ildasm using 
    //csc HeloProgram.cs in directory path
    
    static void Main(string[] args) {
        Console.WriteLine("Hello CIL code!");
        Console.Read();
    }

    //Dump file  ildasm to create il file
    //make changes to il file and re-compile to new assembly using 
    // ilasm /exe HelloProgram.il /output=NewAssembly.exe
    //call new assembly executable
}