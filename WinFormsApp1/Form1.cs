//WinForm�п��̸߳���UI�ؼ��ķ���
//
//1.
//ͨ�����ô������ԣ�ȡ���Ƿ����̵߳��ü��������"�̼߳������Ч�쳣"
//����CheckForIllegalCrossThreadCalls����Ϊfalse
//���̰߳�ȫ�����鲻ʹ��
//
//2.
//����this.Invoke();
//Invoke()�����ã���Ӧ�ó�������߳���ִ��ָ����ί�С�

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