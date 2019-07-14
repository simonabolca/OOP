using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Program
    {
       public static void Main(string[] args)
        {
            //Intr-o ferma se afla 3 vaci, 2 oi si 5 gaini. Defineste clasele corespunzatoare
            //folosind clasele si interfetele predefinite fara a le modifica in vreun fel si 
            // afiseaza raspunsurile la cele 4 intrebari de mai jos.

            //adauga animalele in lista predefinita
              var animale = new Animal[12];
                       

            var vaca = new Vaca();
            var vaca2 = new Vaca();
            var vaca3 = new Vaca();
            var oaie = new Oaie();
            var oaie2 = new Oaie();
            var gaina = new Gaina();
            var gaina2 = new Gaina();
            var gaina3 = new Gaina();
            var gaina4 = new Gaina();
            var gaina5 = new Gaina();
            var capra = new Capra();
            var caprioara = new Caprioara();

            animale[0] = vaca;
            animale[1] = vaca2;
            animale[2] = vaca3;
            animale[3] = oaie;
            animale[4] = oaie2;
            animale[5] = gaina;
            animale[6] = gaina2;
            animale[7] = gaina3;
            animale[8] = gaina4;
            animale[9] = gaina5;
            animale[10] = capra;
            animale[11] = caprioara;

            int countGaini = 0;

            foreach (var item in animale)
            {
                if (item.Rasa == "gaina")   // count
                {
                    countGaini++;
                }
            }

            Console.WriteLine($"Numarul de gaini este: { countGaini}");

            foreach (var animal in animale)
            {
                animal.Mananca(animal.HranaPreferata[0]);
                
            }

            int numarResurseVaca = 0;
            int numarResurseOaie = 0;
            int numarResurseGaina = 0;
            int numarResurseCaprioara = 0;
            int numarResurseCapra = 0;

            

            foreach (var animal in animale)
            {                
                var resursa = animal.ColecteazaResurse();
                if(animal.Rasa == "vaca")
                {
                    numarResurseVaca += resursa.Cantitate ;
                }

                if(animal.Rasa == "oaie")
                {
                    numarResurseOaie += resursa.Cantitate;
                }

                if(animal.Rasa == "gaina")
                {
                    numarResurseGaina += resursa.Cantitate;
                }

                if(animal.Rasa == "caprioara")
                {
                    numarResurseCaprioara += resursa.Cantitate;
                }

                if(animal.Rasa == "capra")
                {
                    numarResurseCapra += resursa.Cantitate;
                }
            }
            Console.WriteLine($"Numarul de resurse pentru vaci este de {numarResurseVaca} litri");
            Console.WriteLine($"Numarul de resurse pentru oi este de {numarResurseOaie} litri");
            Console.WriteLine($"Numarul de resurse pentru gaini este de {numarResurseGaina} oua");
            Console.WriteLine($"Numarul de resurse pentru caprioara este de {numarResurseCaprioara} kg");
            Console.WriteLine($"Numarul de resurse pentru capre este de {numarResurseCapra} litri");


            foreach (var animal in animale)
            {

                if (animal.AnimalHranit)
                {
                    animal.Doarme();
                }

            }

            int numarAnimaleAdormite = 0;
            



            foreach (var animal in animale)
            {
                

                if (animal.AnimalAdormit)
                {
                    numarAnimaleAdormite += 1;
                }
            }

            if (numarAnimaleAdormite <= 10)
            {
                Console.WriteLine($"Numarul de animale adormite este {numarAnimaleAdormite}");
            }




            Adapost adapostDeVaci = new Adapost();
            Adapost adapost2 = new Adapost();
            Adapost adapost3 = new Adapost();
            Adapost adapost4 = new Adapost();
            Adapost adapost5 = new Adapost();
            Adapost adapostAnimaleRamase = new Adapost();

            foreach (var animal in animale)
            {
                animal.IntraInAdapost();
                
                
                    if(animal.Rasa== "vaca" )
                    {
                        adapostDeVaci.AdaugaAnimalInAdapost();
                    }
                    if(animal.Rasa == "gaina" )
                    {
                        adapost2.AdaugaAnimalInAdapost();   
                    }
                    if(animal.Rasa == "oaie")
                    {
                        adapost3.AdaugaAnimalInAdapost();
                    }
                    if(animal.Rasa == "capra")
                    {
                        adapost4.AdaugaAnimalInAdapost();
                    }
                    if(animal.Rasa == "caprioara")
                    {
                        adapost5.AdaugaAnimalInAdapost();
                    }
                }
                adapostDeVaci.Afisare();
                adapost2.Afisare();
                adapost3.Afisare();
                adapost4.Afisare();
                adapost5.Afisare();
            Console.ReadLine();

        }


            

            






            //1. Tipareste numarul de gaini calculandul programatic


            //2. Hraneste animalele cu tipul de hrana adecvat. Tipurile de hrana vor fi definite
            // folosind IHRana si create in folderul Hrana


            //3. Colecteaza toate resursele produse de animale (oua, lapte) si afisati totalul cantitatii
            //   colectate pentru fiecare din ele.
            //   Tipurile de resurse vor fi definite folosind IResursa si vor fi puse in folderul
            //   Resurse


            //4. Pune animalele la somn. Pentru a ne asigura ca animalele sunt la somn se va 
            // verifica ca fiecare Animal este "AnimalAdormit"- proprietate disponibila pe clasa 
            // animal. 

            //5. De adaugat 2 animale noi, ex: iepuri + capre
            //6. De adaugat o proprietate obligatorie la toate animalele: Numarul de picioare
            //7. De adaugat un tip nou de hrana, morcovi pentru iepuri
            //8.Unul dintre animale poate manca 2 sau mai multe feluri de hrana
            //9.De introdus conceptul de adapost in care pot locui mai multe animale.
            //Fiecare adapost poate avea un numar limitat de animale pe care le poate tine. Sa se afiseze numarul de animale din adapost.

            
        }
    }

