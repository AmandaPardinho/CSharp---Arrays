﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.Funcionarios
{
    public class Designer: Funcionario
    {
        public Designer(string cpf): base(3000, cpf)
        {            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.17;
        }
    }
}
