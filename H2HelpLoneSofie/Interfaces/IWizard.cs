using System;
using System.Collections.Generic;
using System.Text;

namespace H2HelpLoneSofie.Interfaces
{
    public interface IWizard : ICharacter, ITeleport
    {
        void ThrowFrostNova();
        void ThrowMagicMisile();
    }
}
