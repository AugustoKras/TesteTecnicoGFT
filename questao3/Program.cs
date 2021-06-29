using System;

    interface Imposto
    {
    double calculaImposto(double valor);
    }

    public class ICMS:Imposto
    {
    public double calculaImposto(double valor){
        return valor * 0.3;
        }
    }

    public class IPI:Imposto
    {
    public double calculaImposto(double valor){
        if(valor < 25000){
        return valor * 0.05;
        }else{
        return valor * 0.1;
        }
        }
    }

    public class COFINS:Imposto
    {
    public double calculaImposto(double valor){
        if(valor > 17000){
        return valor * 0.08;
        }else{
        return 0;
        }
        }
    }

    public class Program
    {
    public static void Main()
    {
        System.Console.WriteLine("Insira um valor: ");
        string input = Console.ReadLine();
        double numero = Double.Parse(input);

        ICMS icms_class = new ICMS();
        IPI ipi_class = new IPI();
        COFINS cofins_class = new COFINS();

        double icms = icms_class.calculaImposto(numero);
        double ipi = ipi_class.calculaImposto(numero);
        double cofins = cofins_class.calculaImposto(numero);
        double total_imposto = icms+ipi+cofins;

        Console.WriteLine("ICMS: {0}", icms);
        Console.WriteLine("IPI: {0}", ipi);
        Console.WriteLine("COFINS: {0}", cofins);
        Console.WriteLine("Total de imposto: {0}", total_imposto);
    }
}