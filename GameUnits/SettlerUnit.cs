using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost { get; }

        public SettlerUnit()
            : base(1, 2)
        {
            Cost = 5;
        }
    }
}
Nesta versão modificada, adicionei um construtor na classe SettlerUnit que inicializa a classe base Unit com `movement =



