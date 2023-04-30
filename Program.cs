

Console.WriteLine("--- Diabetes ---\n");

Console.Write("digite a nivel de glicemia (mg/dL): ");
double glicemia = Convert.ToDouble(Console.ReadLine());

if ( glicemia <= 92) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\nreavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else if (glicemia >= 92 && glicemia < 126 ) { 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine ("\nCompatível com Diabetes Gestacional");
}
else {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nDiabetes Mellitus na Gravidez");
}
Console.ResetColor();