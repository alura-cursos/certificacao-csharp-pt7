using System;

namespace _01_01
{
    /// <image url="$(ProjectDir)/img1.png"/>
    class Program
    {
        static void Main(string[] args)
        {
            Campainha campainha = new Campainha();
            campainha.OnCampainhaTocou += CampainhaTocou1;
            campainha.OnCampainhaTocou += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();

        }

        static void CampainhaTocou1()
        {
            Console.WriteLine("A campainha tocou.(1)");
        }
        static void CampainhaTocou2()
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }

    class Campainha
    {
        public Action OnCampainhaTocou { get; set; }

        public void Tocar()
        {
            if (OnCampainhaTocou != null)
            {
                OnCampainhaTocou();
            }
            
        }
    }
}


