namespace ReverseTicTacToe.UI
{
    using System.Windows.Forms;
    internal class ReverseTicTacToeRunGame
    {
        public static void StartGame()
        {
            FormLogin formLogin = new FormLogin();

            formLogin.ShowDialog();

            if(formLogin.DialogResult == DialogResult.OK)
            {
                formLogin.FormGameBoard.ShowDialog();
            }
        }
    }
}
