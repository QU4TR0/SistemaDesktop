<<<<<<< HEAD
﻿using System.Windows.Forms;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> cf1084e6e38ac073a206ad4280108ea9a981c9d8

namespace SistemaDesktop.Modelo
{
    public class Limpar
    {
        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox
                }
            }
        }
    }
}
