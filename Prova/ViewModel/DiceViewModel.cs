using CommunityToolkit.Mvvm.ComponentModel;
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prova.ViewModel
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _resultado;

        [ObservableProperty]
        private int _numeroSelec;

        public ICommand RollCommand { get; }

        public void Roll()
        {
            Dado dice = new Dado(NumeroSelec);
            dice.RolarDado();
            Resultado = dice.NumSort;
        }

        public DiceViewModel()
        {
            RollCommand = new Command(Roll);
        }
    }
}
