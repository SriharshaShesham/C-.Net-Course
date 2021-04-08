using System;

namespace _5._3._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Rama="Rama";
            const string Hanuma="Hanuma";
            const string ravana="Ravana";

            System.Console.WriteLine("Ramayanam - The Great Epic");
            System.Console.WriteLine("---------------------------");
            InsertLineBreaks();
            System.Console.WriteLine("Sundarakanda");
            System.Console.WriteLine("-------------");
            InsertLineBreaks();
            Ashokavanam(ravana);
            Ashokavanam(Hanuma);

            InsertLineBreaks();
            System.Console.WriteLine("Yuddhakanda");
            System.Console.WriteLine("-------------");
            InsertLineBreaks();
            Ashokavanam(Rama);
        }

        static void Ashokavanam(string person)
        {
            bool result=false;

            System.Console.WriteLine(person+" entered Ashokavanam");
            System.Console.WriteLine("------------------------------------------");

            if(person=="Rama")
            {
                Yudhakanda();
                result=SitaRamaHappy();
                SitaDecision(result);
                
            }

            if(person=="Hanuma")
            {
                result=SitaToHanuma();
                SitaDecision(result);
                HanumaLankaTour();

            }

            if(person=="Ravana")
            {
                result=SitaIrritatesWithRaavana();
                SitaDecision(result);
            }


            

            InsertLineBreaks();
        }

        static void SitaDecision(bool result)
        {
            if(result)
            {
                System.Console.WriteLine("Sita leaves Ashokavanam");
            }
            else
            {
                System.Console.WriteLine("Sita wouldn't leave Ashokavanam");
            }
        }

        static void Yudhakanda()
        {
            System.Console.WriteLine("Upon knowing that Sita is in Ashokavanam Rama hugs Hunama to convey his gratitude.");
            System.Console.WriteLine("Sugriva suggests to build a bridge to Lanka");
            System.Console.WriteLine("Rama sincerely requests Samudra to give him path. Upon no response from Samudra Rama thought of pushing Samudra for his negligence.");
            System.Console.WriteLine("Samudra who is scared of Rama banam(arrow) takes a shape of a human and requests Rama to not to punish him. He says that he cannot give a path but he suggests to build a bridge like Sugriva suggested. Samudra said that he would make that bridge float");
            System.Console.WriteLine("Rama gives order to build the bridge and Nala builds it");
            System.Console.WriteLine("Rama along with Lakshmana, Sugriva, Hanuma, Jambavanta and other mighty monkey warriors goes to Lanka and defeats Ravanas entire Kingdom");
            System.Console.WriteLine("Rama finally killed Ravana and gives the throne of Lanka to Vibhishana who is a great follower of Rama(Dharma)");
            System.Console.WriteLine("Upon death of Ravana, Mandodari who is a wife of Ravana approaches Ravan's dead body and says that 'It is not Rama who killed you, it is your own self who brought this upon Lanka'");

            System.Console.WriteLine("Rama! who has been eagerly waiting to see Sita for a very long time enters Ashokavanam");
            InsertLineBreaks();
        }

        static bool SitaRamaHappy()
        {
            System.Console.WriteLine("Sita! who has been waiting for Rama was very happy when Rama entered Ashokavanam");
            System.Console.WriteLine("Sita happy that Rama killed Raavana");
            return true;
        }

        static bool SitaToHanuma()
        {
            System.Console.WriteLine("Sita doubts if Hanuma is a magic of Raavana");
            System.Console.WriteLine("Hanuma proves that he is a messenger of Rama");
            System.Console.WriteLine("Sita happy to see Hanuma");
            return false;
        }

        static void HanumaLankaTour()
        {
            System.Console.WriteLine("Hanuma after talking to Sitha, destorys the Ashokavanam");
            System.Console.WriteLine("Hanuma kills tens of thousands of Raavana's Rakshasas");
            System.Console.WriteLine("Hanuma lets himself captured by Indrajit to pay Ravana a visit");
            System.Console.WriteLine("Hanuma tries to make Raavana change his mind to handover Sita to Rama");
            System.Console.WriteLine("The foolish and dushta Rakshasa Ravan wouldn't listen, and orders his servents to put fire to Hanuma's tale and to tie him and to walk him throughout Lanka");
            System.Console.WriteLine("Hanuma who is looking for an oppertunity goes along with Raavana plan and gets a tour of the Lanaka.");
            System.Console.WriteLine("Now that Hanuma got a clear picture of the map of Lanaka, he breaks the rope and torch the whole Lanka with his burning tail except Ashoka vanam");
            System.Console.WriteLine("Hanuma dips his tale in the ocean and fly away to Dakshina Smudra where all the vanaras are waiting");
            System.Console.WriteLine("Hanuma lets Rama know that Sita is safe and that she is in Ashokavanam.");
            InsertLineBreaks();
        }

        static bool SitaIrritatesWithRaavana()
        {
            System.Console.WriteLine("Sita is irritated as she sees Raavana entering Ashoka vanam");
            System.Console.WriteLine("Sita tries to plead him to leave her so that Rama would spare him");
            return false;
        }

        static void InsertLineBreaks()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}
