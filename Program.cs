﻿namespace TP_02_Extra___Boxeadores;
class Program
{
    static void Main(string[] args)
    {
        int num,peso, pG, vP, random;
        double skill1=0,skill2=0;
        string nom, pais; 
        Boxeador a=null;
        Boxeador b=null;
        do
        {
            Menu();
            num=IngresarEnteroPositivo("Opcion:");
            switch (num)
            {
                case 1:

                    nom=IngresarCadena("Ingrese nombre de BOXEADOR 1: ");
                    pais= IngresarCadena("¿Donde vive su BOXEADOR?: ");
                    peso= IngresarEnteroPositivo("Peso (num en Kg):");
                
                    pG=IngresarEnteroPositivo("Potencia del GOLPE: ");
                    while(pG<=0 || pG>100)
                    {
                        pG=IngresarEnteroPositivo("ERROR-valor fuera de rango (1-100)\nPotencia del GOLPE: ");
                    }
                
                    vP=IngresarEnteroPositivo("VELOCIDAD de piernas:");
                    while(vP<=0 || vP>100)
                    {
                        vP=IngresarEnteroPositivo("ERROR-valor fuera de rango (1-100)\nVELOCIDAD de piernas:");
                    }
                
                    a= new Boxeador(nom,pais,peso,pG,vP);
                    Console.WriteLine("CREADOR BOXEADOR 1");
                    random= RandomNum(1,10);
                    skill1= a.ObtenerSkill(a.PotenciaGolpes,a.VelocidadPiernas,random);


                break;
                
                case 2:

                    nom=IngresarCadena("Ingrese nombre de BOXEADOR 2: ");
                    pais= IngresarCadena("¿Donde vive su BOXEADOR?: ");
                    peso= IngresarEnteroPositivo("Peso (num en Kg):");
                
                    pG=IngresarEnteroPositivo("Potencia del GOLPE: ");
                    while(pG<=0 || pG>100)
                    {
                        pG=IngresarEnteroPositivo("ERROR-valor fuera de rango (1-100)\nPotencia del GOLPE: ");
                    }
                
                    vP=IngresarEnteroPositivo("VELOCIDAD de piernas:");
                    while(vP<=0 || vP>100)
                    {
                        vP=IngresarEnteroPositivo("ERROR-valor fuera de rango (1-100)\nVELOCIDAD de piernas:");
                    }
                
                    b= new Boxeador(nom,pais,peso,pG,vP);
                    Console.WriteLine("CREADOR BOXEADOR 2");
                    random= RandomNum(1,10);
                    skill2= b.ObtenerSkill(b.PotenciaGolpes,b.VelocidadPiernas,random);

                break;
                
                case 3:
                
                    if(a!=null && b!=null)
                    {
                        if(skill1>skill2 && skill1-skill2>=30)
                        {
                            Console.WriteLine("Ganó "+ a.Nombre + " por KO");
                        }
                        else if( skill2>skill1 && skill2-skill1>=30)
                        {
                            Console.WriteLine("Ganó "+ b.Nombre + " por KO");
                        }
                        else if(skill1>skill2 && skill1-skill2>=10 && skill1-skill2<30)
                        {
                            Console.WriteLine("Ganó " + a.Nombre +" por puntos en fallo unánime");
                        }
                        else if(skill2>skill1 && skill2-skill1>=10 && skill2-skill1<30)
                        {
                            Console.WriteLine("Ganó " + b.Nombre +" por puntos en fallo unánime");
                        }
                        else if(skill1>skill2 && skill1-skill2<10)
                        {
                            Console.WriteLine("Ganó " + a.Nombre +" por puntos en fallo dividido");
                        }
                        else
                        {
                        Console.WriteLine("Ganó " + b.Nombre +" por puntos en fallo dividido");
                        }
                    }

                break;
                
                case 4:

                    Console.WriteLine("Chau!");

                break;
                
                Console.ReadKey();
                Console.Clear();
            }
        
        }while(num!=4);

    }
    static void Menu()
    {
        Console.WriteLine("1.Cargar Datos Boxeador 1\n2.Cargar Datos Boxeador 2\n3.Pelear!\n4.Salir");
    }
    static int IngresarEnteroPositivo(string mensaje)
    {
        Console.Write(mensaje);
        int num = int.Parse(Console.ReadLine());
        while (num <= 0)
        {
            Console.Write("ERROR!NUMERO NEGATIVO.Vuelva a ingresar:");
            num = int.Parse(Console.ReadLine());
        }
        return num;
    }
    static string IngresarCadena(string mensaje)
    {
        Console.Write(mensaje);
        string cadena = Console.ReadLine();
        return cadena;
    }
    static int RandomNum(int desde, int hasta)
    {
        int random;
        Random rd = new Random();
        random = rd.Next(desde, hasta);
        return random;
    }
}
