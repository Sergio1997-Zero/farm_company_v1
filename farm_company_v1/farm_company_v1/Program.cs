using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farm_company_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Empresa> Compras = new List<Empresa>();
            Console.WriteLine("Ingrese el numero de granjeros :  ");
            int Num1 = int.Parse(Console.ReadLine());
            int  Num2 = 0;
           
            
            for (int i = 0; i < Num1; i++)
            {
                
                Empresa empresa = new Empresa();
                Console.WriteLine("ingrese el nombre : ");
                empresa.farmers.Name = Console.ReadLine();
                Console.WriteLine("ingrese el estrato: ");
                empresa.farmers.Stratum = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el genero");
                empresa.farmers.Gender = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de produtos :  ");
                Num2 = int.Parse(Console.ReadLine());
                for (int n = 0; n < Num2; n++)
                {
                    
                    Product nuevoPRoducto = new Product();
                    Console.WriteLine("Ingrese el producto que tenga :");
                    Console.WriteLine("1. Moras");
                    Console.WriteLine("2. Piñas");
                    Console.WriteLine("3. Guayabas");
                    Console.WriteLine("4. Mangos");
                    Console.WriteLine("5. Limones");
                    Console.WriteLine("6. Papas");
                    Console.WriteLine("7. Bananos");

                    Console.WriteLine("Ingrese el nombre del producto que tiene : ");
                    string nombreproducto = Console.ReadLine();
                    Console.WriteLine("Ingrese la extencion del producto :  ");
                    float extencion = float.Parse(Console.ReadLine());
                    nuevoPRoducto = empresa.productfarmer(nombreproducto, extencion);
                    empresa.Products.Add(nuevoPRoducto);

                }


            if (empresa.farmers != null)
                {
                    Compras.Add(empresa);
                }
                Console.WriteLine("el nombre es {0} el estrato es {1} el genero es {2}", empresa.farmers.Name);

            }

            
            foreach (Empresa far in Compras)
            {
                if (far.farmers.Gender == 0)
                { 
                    
                    foreach(Product pro in far.Products)
                    {
                        
                        double PrecioUnitario  = pro.UnitPrice - (pro.UnitPrice * (pro.TaxPerUnitPercentage / 100));
                        double descuento = PrecioUnitario * (50 / 100);
                        double TotalProductos = pro.UnitPerKilometer * pro.Crop.Extension;

                        Console.WriteLine("El total a pagar es :  {0} Al granjero : {1}", TotalProductos, far.farmers.Name);
                    }

                }




                if (far.farmers.Gender == 1)
                {

                    foreach (Product pro in far.Products)
                    {

                        double preciofinal = pro.UnitPrice - (pro.UnitPrice * (pro.TaxPerUnitPercentage / 100));
                        double TotalProductos = pro.UnitPerKilometer * pro.Crop.Extension;
                        Console.WriteLine("El total a pagar es :  {0} Al granjero : {1}", TotalProductos, far.farmers.Name);
                    }

                }

                //Console.WriteLine(far.Farmers.Name ) ; 
            }
            Console.WriteLine(Compras.Count());
            
            


            //Console.WriteLine(F1.Name);
            Console.ReadKey();
        }
    }
}
