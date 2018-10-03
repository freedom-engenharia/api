using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Repositorios;
using System;

namespace AutomacaoFreedomApi.Repositorio
{
    public sealed class AutomacaoFreedomUnitOfWork : IAutomacaoFreedomUnitOfWork
    {
        private AutomacaoFreedomContexto _contexto;

        public AutomacaoFreedomUnitOfWork(AutomacaoFreedomContexto contexto) { _contexto = contexto; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool Save()
        {
            return (_contexto.SaveChanges() >= 0);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_contexto != null)
                {
                    _contexto.Dispose();
                    _contexto = null;
                }
            }
        }
    }
}

