namespace Ejercicios_Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            // EJERCICIOS 1

            //string firstname = "Gabriel";
            //string lastname = "Rodriguez";
            //   Console.WriteLine(firstname);
            //   Console.WriteLine(lastname);

            //Console.WriteLine("Como te llamas?");
            //string x = Console.ReadLine();
            //Console.WriteLine("Encantado de conocerte " + x);
            //TODO


            // EJERCICIOS 2

            //int val1 = 12;
            //int val2 = 3;
            //int suma = val1 + val2;
            //int resta = val1 - val2;
            //int producto = val1 * val2;
            //float cociente = val1 / val2;
            //int modulo = val1 % val2;
            //Console.WriteLine("suma: {0}, resta: {1}, producto: {2}, cociente: {3}, modulo: {4}", suma, resta, producto, cociente, modulo);


            //float temperaturaC = (float)Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("temperatura en Kelvin: {0}", temperaturaC + 273);
            //Console.WriteLine("temperatura en F°: {0}", temperaturaC * 18 / 10 + 32);


        }
    }
}

//public class Operaciones
//{
//    private int _val1; 
//    private int? _val2;

//    public struct resultados
//    {
//        public float rsuma { get; set; }
//        public float rresta { get; set; }
//        public float rmultiplicacion { get; set; }
//        public float rdivision { get; set; }
//    }
//    public Operaciones(int val1, int? val2)
//    {
//        _val1 = val1;
//        _val2 = val2;

//    }
//    public bool dimensionesEsfera()
//    {
//        float superficie = 0;
//        float volumen = 0;
//        float pi = 3.1415926535f;
//        superficie = 4 * pi * (_val1 * _val1);
//        volumen = 4 / 3 * pi * (_val1 * _val1 * _val1);
//        Console.WriteLine("la superficie es: " + superficie);
//        Console.WriteLine("el volumen es: " + volumen);
//        return true;
//    }
//    public resultados basicas()
//    {

//        resultados MisResultados = new resultados()
//        {
//            rsuma = (float)(_val1 + _val2),
//            rresta = (float)(_val1 - _val2),
//            rmultiplicacion = (float)(_val1 * _val2),
//            rdivision = (float)(_val1 / _val2)
//        };
//        return MisResultados;
        
//    }
//}