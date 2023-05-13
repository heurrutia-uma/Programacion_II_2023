using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador
{
    public class FormController
    {
        public static void AbrirFormulario(Form formularioPadre, Form formularioHijo)
        { 
            formularioHijo.MdiParent = formularioPadre;
            formularioHijo.Show();
        }
    }
}
