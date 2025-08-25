using AntdUI;
using Peak.Can.Basic;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Channels;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAN
{
    public partial class Main : AntdUI.Window
    {
        public Can_TL CAN_TL;
        public AntdUI.FormFloatButton? FloatButton1;
        public FloatButton.Config? config;
        public System.Windows.Forms.Timer dataReceiveTimer;

        public Main()
        {

            InitializeComponent();
            inputNumber_send1.Maximum = 256; // �������ֵΪ256
            inputNumber_send1.Minimum = 0; // ������СֵΪ0
            inputNumber_send2.Maximum = 256; // �������ֵΪ256
            inputNumber_send2.Minimum = 0; // ������СֵΪ0
            inputNumber_send3.Maximum = 256; // �������ֵΪ256
            inputNumber_send3.Minimum = 0; // ������СֵΪ0
            inputNumber_send4.Maximum = 256; // �������ֵΪ256
            inputNumber_send4.Minimum = 0; // ������СֵΪ0
            inputNumber_send5.Maximum = 256; // �������ֵΪ256
            inputNumber_send5.Minimum = 0; // ������СֵΪ0
            inputNumber_send6.Maximum = 256; // �������ֵΪ256
            inputNumber_send6.Minimum = 0; // ������СֵΪ0
            inputNumber_send7.Maximum = 256; // �������ֵΪ256
            inputNumber_send8.Maximum = 256; // �������ֵΪ256
            inputNumber_send8.Minimum = 0; // ������СֵΪ0

            inputNumber_CAN_ID.Minimum = 0; // ������СֵΪ0
            inputNumber_CAN_ID.Maximum = 0x0FFFFFFF; // �������ֵΪ29λCAN ID�����ֵ

            CAN_TL = new();
            //  CAN_TL.channelsInformation
            //  select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.DeviceID}").ToArray());
            button_FreshChannel_Click(this, EventArgs.Empty);
            // �����������Ƶ� Load �¼���
            Load += Main_Load;



        }
        private void Main_Load(object? sender, EventArgs e)
        {
            // ����������ť����
            config = new FloatButton.Config(this, new FloatButton.ConfigBtn[] {
                new FloatButton.ConfigBtn("����1", "ͼ��1", false)
                {
                     Tooltip = " ",
                     Type= AntdUI.TTypeMini.Primary,

                }
            }, btn =>
            {
                //  btn.Loading = true;
                // MessageBox.Show($"�����: {btn.Name}");
            });

            config.MarginX = 20;
            config.MarginY = 20;

            FloatButton1 = AntdUI.FloatButton.open(config);


            if (FloatButton1 == null)
            {
                MessageBox.Show("�޷�����������ť");
            }
            // ��ʼ����ʱ��
            dataReceiveTimer = new System.Windows.Forms.Timer();
            dataReceiveTimer.Interval = 100; // ���ö�ʱ���������λΪ����
            dataReceiveTimer.Tick += new EventHandler(DataReceiveTimer_Tick);


        }
        private void button_FreshChannel_Click(object sender, EventArgs e)
        {
            // Refresh channel logic here
            select_AvailableDevice.Items.Clear();
            select_AvailableDevice.SelectedIndex = -1;
            CAN_TL.GetCANDevice();
            if (CAN_TL.CAN_DeviceCount > 0)
            {

                select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.ChannelHandle}").ToArray());
                select_AvailableDevice.SelectedIndex = 0;
            }
            else
            {
                select_AvailableDevice.Text = "No device";
                select_AvailableDevice.SelectedIndex = -1;
            }



            //MessageBox.Show("Channel refreshed!");
        }
        private void pageHeader_Top_Click(object sender, EventArgs e)
        {

        }

        private void select_AvailableDevice_SelectedIndexChanged(object sender, IntEventArgs e)
        {

        }

        private void button_OpenDevice_Click(object sender, EventArgs e)
        {
            if (select_AvailableDevice.Items.Count > 0)
            {


                label_OpenedDevice.Text = " ";


                if (CAN_TL.IsOpen == true)
                {
                    CAN_TL.Close(CAN_TL.PCAN_channel);
                }

                CAN_TL.PCAN_channel = CAN_TL.channelsInformation[select_AvailableDevice.SelectedIndex].ChannelHandle;

                //�����豸
                if (CAN_TL.Open(CAN_TL.PCAN_channel, CAN_TL.CANBaudrate))
                {
                    label_OpenedDevice.Text = $"{select_AvailableDevice.Text}";
                }
            }
            else
            {
                CAN_TL.IsOpen = false;
                MessageBox.Show("Please select a CAN device to open.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CloseDevice_Click(object sender, EventArgs e)
        {
            if (CAN_TL.Close(CAN_TL.PCAN_channel))
            {
                label_OpenedDevice.Text = " ";
            }
        }

        private void button_Tip_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void button_Transmit_Click(object sender, EventArgs e)
        {
            //for(uint i = 0; i < 8; i++)
            //{
            //    CAN_TL.bytes_send[i] = (byte)inputNumber_send8.Value; // ��������ֽ�����
            //}
            CAN_TL.bytes_send[0] = (byte)inputNumber_send1.Value;
            CAN_TL.bytes_send[1] = (byte)inputNumber_send2.Value;
            CAN_TL.bytes_send[2] = (byte)inputNumber_send3.Value;
            CAN_TL.bytes_send[3] = (byte)inputNumber_send4.Value;
            CAN_TL.bytes_send[4] = (byte)inputNumber_send5.Value;
            CAN_TL.bytes_send[5] = (byte)inputNumber_send6.Value;
            CAN_TL.bytes_send[6] = (byte)inputNumber_send7.Value;
            CAN_TL.bytes_send[7] = (byte)inputNumber_send8.Value; // ��������ֽ�����

            CAN_TL.CAN_ID = (uint)inputNumber_CAN_ID.Value; // ��ȡCAN ID
            // ��������
            CAN_TL.SendData(CAN_TL.CAN_ID, CAN_TL.bytes_send, 8);
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
            if (dataReceiveTimer.Enabled)
            {
                StopReceiving();
                button_Receive.Text = "��ʼ����";
            }
            else
            {
                StartReceiving();
                button_Receive.Text = "ֹͣ����";
            }
            //uint ret = 0;
            //ret = CAN_TL.ReadData(out string? str);
            //if (ret != 0)
            //{

            //    textBox_CAN_Data.AppendText(str);
            //    textBox_CAN_Data.ScrollToCaret();
            //    // �������1000��
            //    if (textBox_CAN_Data.Lines.Length > 1000)
            //    {
            //        textBox_CAN_Data.Text = string.Join(Environment.NewLine,
            //        textBox_CAN_Data.Lines.Skip(textBox_CAN_Data.Lines.Length - 1000));
            //    }
            //}

        }

        private void inputNumber_send4_ValueChanged(object sender, DecimalEventArgs e)
        {

        }

        private void label_CAN_ID_Click(object sender, EventArgs e)
        {

        }

        private void radio_Torque_CheckedChanged(object sender, BoolEventArgs e)
        {

        }

        private void button_NumberScale_Click(object sender, EventArgs e)
        {
            if(button_NumberScale.Text == "ʮ������")
            {
                inputNumber_send1.Hexadecimal = false;
                inputNumber_send2.Hexadecimal = false;
                inputNumber_send3.Hexadecimal = false;
                inputNumber_send4.Hexadecimal = false;
                inputNumber_send5.Hexadecimal = false;
                inputNumber_send6.Hexadecimal = false;
                inputNumber_send7.Hexadecimal = false;
                inputNumber_send8.Hexadecimal = false;
                button_NumberScale.Text = "ʮ����";

            }
            else 
            {
                inputNumber_send1.Hexadecimal = true;
                inputNumber_send2.Hexadecimal = true;
                inputNumber_send3.Hexadecimal = true;
                inputNumber_send4.Hexadecimal = true;
                inputNumber_send5.Hexadecimal = true;
                inputNumber_send6.Hexadecimal = true;
                inputNumber_send7.Hexadecimal = true;
                inputNumber_send8.Hexadecimal = true;

                button_NumberScale.Text = "ʮ������";
            }



        }
        // ��ʱ��Tick�¼�������
        public void DataReceiveTimer_Tick(object sender, EventArgs e)
        {
            uint ret = 0;
            ret = CAN_TL.ReadData(out string? str);
            if (ret != 0)
            {
                // ʹ��Invokeȷ����UI�߳��ϸ��¿ؼ�
                if (textBox_CAN_Data.InvokeRequired)
                {
                    textBox_CAN_Data.Invoke(new Action(() => UpdateTextBox(str)));
                }
                else
                {
                    UpdateTextBox(str);
                }
            }
        }

        // ����TextBox�ķ���
        private void UpdateTextBox(string str)
        {
            textBox_CAN_Data.AppendText(str);
            textBox_CAN_Data.ScrollToCaret();

            // �������1000��
            if (textBox_CAN_Data.Lines.Length > 1000)
            {
                textBox_CAN_Data.Text = string.Join(Environment.NewLine,
                    textBox_CAN_Data.Lines.Skip(textBox_CAN_Data.Lines.Length - 1000));
            }
        }

        // ��ʼ��ʱ���ķ���
        private void StartReceiving()
        {
            dataReceiveTimer.Start();
        }

        // ֹͣ��ʱ���ķ���
        private void StopReceiving()
        {
            dataReceiveTimer.Stop();
        }

      
    }
}
