using H2HelpLoneSofie.Interfaces;
using System;
using System.Collections.Generic;

namespace H2HelpLoneSofie
{
    class Program
    {
        static void Main(string[] args)
        {
            IKnight knight = new Knight();
            IBabarian babarian = new Babarian();
            IWitch witch = new Witch();
            IWizard wizard = new Wizard();

            knight.RaiseShield();
            babarian.Cleave();
            wizard.Teleport(10, 20);
            witch.ShieldGlare();
        }
    }
}
