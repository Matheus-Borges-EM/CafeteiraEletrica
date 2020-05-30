using CoffeeMakerApi;

namespace CafeteiraEletrica
{
    public class M4InterfaceDoUsuario : InterfaceDoUsuario, IPrepararCafe
    {
        private ICoffeeMakerApi _api;

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

        internal override void FinalizeCicloDePreparo()
        {
            _api.SetIndicatorState(IndicatorState.OFF);
            _api.GetBrewButtonStatus();
        }

        internal override void FinalizePreparo()
        {
            _api.SetIndicatorState(IndicatorState.ON);            
        }
    }
}
