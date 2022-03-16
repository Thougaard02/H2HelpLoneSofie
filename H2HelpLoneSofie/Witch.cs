using H2HelpLoneSofie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2HelpLoneSofie
{
    public class Witch : IWitch
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }
        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }
        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }
        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }
    }
}
