using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Adapost : IAdapost
    {
        
         
        int IAdapost.Capacitate { get => numarCapacitate; set => numarCapacitate = value; }
        int IAdapost.NumardeAnimale { get => count; set => count = value; }

        private int numarCapacitate = 4;

        int count = 0;
        
        
       

       public  void AdaugaAnimalInAdapost()
        {
            if (count < numarCapacitate)
            {
                count += 1; 
            }
            
               
                
            
           
            
           
        }
        public void Afisare()
        {
            
            Console.WriteLine(count); 
            
            
            
            
           
        }
    }
}
