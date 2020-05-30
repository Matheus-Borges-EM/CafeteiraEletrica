﻿
using System;

namespace CafeteiraEletrica
{
    public abstract class InterfaceDoUsuario
    {
        private FonteDeAguaQuente _fonteDeAguaQuente;
        private RecipienteDeContencao _recipienteDeContencao;

        internal abstract void FinalizePreparo();

        public void Inicio(FonteDeAguaQuente fonteDeAguaQuente, RecipienteDeContencao recipienteDeContencao)
        {
            _fonteDeAguaQuente = fonteDeAguaQuente;
            _recipienteDeContencao = recipienteDeContencao;
        }

        protected void Iniciar()
        {
            if (_fonteDeAguaQuente.PodeInicarPreparo && _recipienteDeContencao.PodeIniciarPreparo)
            {
                _fonteDeAguaQuente.Prepare();
                _recipienteDeContencao.Prepare();
            }
        }

        internal abstract void FinalizeCicloDePreparo();

    }
}
