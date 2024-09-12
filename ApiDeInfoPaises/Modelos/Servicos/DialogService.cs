using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDeInfoPaises.Modelos.Servicos
{
    public class DialogService
    {
        public void ShowMessage(string title, string nessage)
        {
            MessageBox.Show(nessage, title);
        }



        public void ShowDialog(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
