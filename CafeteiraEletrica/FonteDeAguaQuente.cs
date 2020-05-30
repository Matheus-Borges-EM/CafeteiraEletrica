
namespace CafeteiraEletrica
{
    public abstract class FonteDeAguaQuente
    {
        private RecipienteDeContencao _recipienteDeContencao;
        private InterfaceDoUsuario _interfaceDoUsuario;

        protected bool EstaPreparando;

        public void Inicio(InterfaceDoUsuario interfaceDoUsuario, RecipienteDeContencao recipienteDeContencao)
        {
            _interfaceDoUsuario = interfaceDoUsuario;
            _recipienteDeContencao = recipienteDeContencao;
        }

        protected internal abstract bool EstaPronto { get; }

        internal abstract void Prepare();

        internal abstract void InterrompaProducao();
    }
}
