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

        public override void FinalizePreparo()
        {
            
        }
    }
}
