using System;
using System.Collections.Generic;
using System.Text;

namespace H2HelpLoneSofie.Interfaces
{
    public interface IWizard : ICharacter, ISorcerer
    {
        void ThrowFrostNova();
        void ThrowMagicMisile();
    }
}
