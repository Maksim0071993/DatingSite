using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DatingApp.Presentation.Interfaces
{
    public interface IFormOpener
    {
        void ShowModelessForm<TForm>() where TForm : Form;
        void ShowModelessForm<TForm>(int userId) where TForm : Form;
        
        DialogResult ShowModalForm<TForm>() where TForm : Form;
    }
}
