using System.Windows.Forms;

namespace MVP
{
    public class ViewAuthResultForm : IViewAuthResult
    {
        public ViewAuthResultForm()
        {
        }

        public void ShowLogAndPassResult(bool success)
        {
            if (success)
                MessageBox.Show("Пинкод отправлен на вашу почту.");
            else
                MessageBox.Show("Пользователя с таким логином и паролем не существует.");
        }
        public void ShowPincodeResult(bool success)
        {
            if (success)
                MessageBox.Show("Вы успешно авторизованы.");
            else
                MessageBox.Show("Пинкод неверный.");
        }
    }
}
