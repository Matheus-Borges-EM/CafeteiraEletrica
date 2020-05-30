using CoffeeMakerApi;

namespace CafeteiraEletrica
{
    public class M4RecipienteDeContencao : RecipienteDeContencao, IPrepararCafe
    {
        private ICoffeeMakerApi _api;

        public M4RecipienteDeContencao(ICoffeeMakerApi api)
        {
            _api = api;
        }

        protected internal override bool EstaPronto
        {
            get
            {
                return _api.GetWarmerPlateStatus() == WarmerPlateStatus.POT_EMPTY;
            }
        }

        internal override void Prepare()
        {
            EstaPreparando = true;
            _api.SetWarmerState(WarmerState.ON);
        }

        private protected override void RecipienteDeContencaoRemovido()
        {           
            _api.SetWarmerState(WarmerState.OFF);
            InterrompaProducao();
        }

        public void Preparando()
        {
            if (EstaPreparando && _api.GetWarmerPlateStatus() != WarmerPlateStatus.WARMER_EMPTY) return;
            RecipienteDeContencaoRemovido();
        }

        public override void FinalizePreparo()
        {
            _api.SetWarmerState(WarmerState.ON);                        
        }
    }
}
