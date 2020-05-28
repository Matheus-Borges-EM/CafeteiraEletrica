using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMakerApi;

namespace CafeteiraEletrica
{
    public class M4InterfaceDoUsuario : InterfaceDoUsuario, IPrepararCafe
    {
        
        private ICoffeeMakerApi _api;

        private M4FonteDeAguaQuente _fonteDeAguaQuente;
        private M4RecipienteDeContencao _recipienteDeContencao;

        public M4InterfaceDoUsuario(ICoffeeMakerApi api)
        {
            _api = api;            
        }

        public void Preparando()
        {
            if (_api.GetBrewButtonStatus() == BrewButtonStatus.PUSHED)
            {
                Iniciar();
            }
        }

        public override void AlteraStatusIndicador()
        {
            _api.SetIndicatorState(IndicatorState.OFF);
        }        
    }
}
