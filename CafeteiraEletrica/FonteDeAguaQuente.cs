
namespace CafeteiraEletrica
{
    public abstract class FonteDeAguaQuente
    {
        private RecipienteDeContencao _recipienteDeContencao;
        private InterfaceDoUsuario _interfaceDoUsuario;

        protected bool EstaPreparando;

        protected internal abstract bool EstaPronto { get; }

        internal abstract void Prepare();

        public abstract void FinalizePreparo();

        internal abstract void InterrompaProducao();
    }
}
