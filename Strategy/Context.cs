using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private ICorrer _strategy;
        public Context(ICorrer strategy)
        {
            _strategy = strategy;
        }

        public string EjecutarStrategy()
        {
            return this._strategy.Correr();
        }

        public void SetStrategy(ICorrer strategy)
        {
            this._strategy = strategy;
        }
    }
}
