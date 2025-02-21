using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace Presentation.Helpers
{
    public static class Messages
    {
        public static void ShowSnackbarNotification(string message)
        {
            var snackbar = new MaterialSnackBar(message, "OK", true)
            {
                Font = new Font("Arial", 14, FontStyle.Bold),
                Width = Form.ActiveForm.Width / 2, 
                Height = 200
            };
            snackbar.Left = (Form.ActiveForm.Width - snackbar.Width) / 2;
            snackbar.Top = (Form.ActiveForm.ClientSize.Height - snackbar.Height) / 2;

            snackbar.Show(Form.ActiveForm);
        }

        public static void ShowSnackbarError(string message)
        {
            var snackbar = new MaterialSnackBar(message, "Error", true)
            {
                Font = new Font("Arial", 14, FontStyle.Bold),
                Width = Form.ActiveForm.Width / 2,
                Height = 200
            };
            snackbar.Left = (Form.ActiveForm.Width - snackbar.Width) / 2;
            snackbar.Top = (Form.ActiveForm.ClientSize.Height - snackbar.Height) / 2;

            snackbar.Show(Form.ActiveForm);
        }

    }
}
