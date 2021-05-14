using System;
using System.Collections.Generic;
using ValorantAPIWrapper;

namespace ValorantCSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ValorantClient vClient = new ValorantClient();
            List<Agents> allAgents = vClient.GetAgents();

            foreach (Agents a in allAgents)
            {
                Console.WriteLine("================ | " + a.DisplayName + " | ================");
                Console.WriteLine("Agent Name : " + a.DisplayName);
                Console.WriteLine("Description : " + a.Description);
                if(a.Role !=null)
                {
                    Console.WriteLine("Role : " + a.Role.DisplayName); 
                }else
                {   Console.WriteLine("Role : N.A" );  }
                
                Console.WriteLine();
            }
           
        }
    }
}
