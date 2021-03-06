using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace farm_company_v1
{
    class Empresa
    {

        public Farmer farmers = new Farmer();
        
       
        public List<Product> Products = new List<Product>();

        

        public Product productfarmer(string nombre, double extencion)
        {
            Product p1 = new Product();
            if (nombre.Equals("moras") || nombre.Equals("Moras"))
            {
                //Product p1 = new Product();
                p1.Name = "Moras";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }

            
            if (nombre.Equals("Piñas") || nombre.Equals("piñas"))
            {
                //Product p1 = new Product();
                p1.Name = "Piñas";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }


            if (nombre.Equals("Guayabas") || nombre.Equals("guayabas"))
            {
                //Product p1 = new Product();
                p1.Name = "Guayabas";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }
            if (nombre.Equals("Mangos") || nombre.Equals("mangos"))
            {
                //Product p1 = new Product();
                p1.Name = "Mangos";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }
            if (nombre.Equals("Limones") || nombre.Equals("limones"))
            {
                //Product p1 = new Product();
                p1.Name = "Limones";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }
            if (nombre.Equals("Papas") || nombre.Equals("papas"))
            {
                //Product p1 = new Product();
                p1.Name = "Papas";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }
            if (nombre.Equals("Bananos") || nombre.Equals("bananos"))
            {
                //Product p1 = new Product();
                p1.Name = "Bananos";
                p1.UnitPrice = 300;
                p1.UnitPerKilometer = 15;
                p1.CropExtensionKms = 15;
                p1.TaxPerUnitPercentage = 15;
                p1.Crop.Extension = extencion;

                
            }
            else
            {
                Console.WriteLine("La información ingresada no coincide con los valores validos, por favor ingrese un valor valido");

            }


            return p1 ;


        }
        
           
        
    }
}
