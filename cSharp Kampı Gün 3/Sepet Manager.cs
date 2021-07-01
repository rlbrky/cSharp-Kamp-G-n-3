using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_Kampı_Gün_3
{
    class Sepet_Manager
    {
        //Naming convention ilk harfi büyük olacak

        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklediniz.." + product.Adi);
        }
    }
}
