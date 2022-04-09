using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW
{
    static class Program
    {

        static DialogResult ShowMessageBoxes1()
        {
            //1
            string message = "Текст сообщения";
            string caption = "Заголовок сообщения";
            MessageBox.Show(message, caption);
            //2
            DialogResult result = MessageBox.Show(message, caption,
               MessageBoxButtons.YesNo);
            //3
            result = MessageBox.Show(message);
            return result;
        }
        static DialogResult ShowMessageBoxes2()
        {
            string message = "Сообщение от програмиста";
            MessageBox.Show(message);
            string caption = "Это заглавие";
            MessageBox.Show(message,caption);
            //2
            caption = "Выбор";
            DialogResult result = MessageBox.Show(message, caption,
               MessageBoxButtons.YesNoCancel);
            string _button = result.ToString();
            result = MessageBox.Show("Вы выбрали " + _button,
            _button, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return result;

        }
       
        static void Main()
        {
            
                    DialogResult res;
                    do
                    {
                        res = ShowMessageBoxes1();
                    } while (res == DialogResult.Retry);
                   
                    DialogResult res2;
                    do
                    {
                        res2 = ShowMessageBoxes2();
                    } while (res2 == DialogResult.Retry);
                  
        
            
        }
    }
}
