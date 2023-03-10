//WinForm中跨线程更新UI控件的方法
//
//1.
//通过设置窗体属性，取消非法跨线程调用检查来避免"线程间操作无效异常"
//设置CheckForIllegalCrossThreadCalls属性为false
//非线程安全，建议不使用
//
//2.
//调用this.Invoke();
//Invoke()的作用：在应用程序的主线程上执行指定的委托。

using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                int i = 0;
                string str;
                while (true)
                {
                    Thread.Sleep(200);
                    str = $"{i++}{Environment.NewLine}";
                    //result.AppendText(str);
                    //this.Invoke(() => result.AppendText(str));
                    this.BeginInvoke(() => result.AppendText(str));
                }
            });
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            result.AppendText($"{1}{Environment.NewLine}");
            result.AppendText($"{2}{Environment.NewLine}");
            Invoke(() => result.AppendText($"{3}{Environment.NewLine}"));
            var ir = BeginInvoke(() => result.AppendText($"{4}{Environment.NewLine}"));
            EndInvoke(ir);
            result.AppendText($"{5}{Environment.NewLine}");
        }
    }
}