using System;

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

        protected internal abstract bool PodeInicarPreparo { get; }

        internal abstract void Prepare();

        private protected void FinalizePreparo()
        {
            _interfaceDoUsuario.FinalizePreparo();
            _recipienteDeContencao.FinalizePreparo();
        }

        internal abstract void InterrompaProducao();

        internal abstract void FinalizeCicloDePreparo();
    }
}
