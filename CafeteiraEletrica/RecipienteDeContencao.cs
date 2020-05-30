namespace CafeteiraEletrica
{
    public abstract class RecipienteDeContencao
    {
        private FonteDeAguaQuente _fonteDeAguaQuente;
        private InterfaceDoUsuario _interfaceDoUsuario;

        protected bool EstaPreparando;

        public void Inicio(InterfaceDoUsuario interfaceDoUsuario, FonteDeAguaQuente fonteDeAguaQuente)
        {
            _interfaceDoUsuario = interfaceDoUsuario;
            _fonteDeAguaQuente = fonteDeAguaQuente;
        }


        protected internal abstract bool EstaPronto { get; }

        internal abstract void Prepare();

        private protected abstract void RecipienteDeContencaoRemovido();

        public abstract void FinalizePreparo();

        private protected void InterrompaProducao()
        {
            _fonteDeAguaQuente.InterrompaProducao();
        }
    }
}
