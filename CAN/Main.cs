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
        public FloatButton.Config config;
        public Main()
        {

            InitializeComponent();
            inputNumber_send1.Maximum = 256; // 设置最大值为256
            inputNumber_send1.Minimum = 0; // 设置最小值为0
            inputNumber_send2.Maximum = 256; // 设置最大值为256
            inputNumber_send2.Minimum = 0; // 设置最小值为0
            inputNumber_send3.Maximum = 256; // 设置最大值为256
            inputNumber_send3.Minimum = 0; // 设置最小值为0
            inputNumber_send4.Maximum = 256; // 设置最大值为256
            inputNumber_send4.Minimum = 0; // 设置最小值为0
            inputNumber_send5.Maximum = 256; // 设置最大值为256
            inputNumber_send5.Minimum = 0; // 设置最小值为0
            inputNumber_send6.Maximum = 256; // 设置最大值为256
            inputNumber_send6.Minimum = 0; // 设置最小值为0
            inputNumber_send7.Maximum = 256; // 设置最大值为256
            inputNumber_send8.Maximum = 256; // 设置最大值为256
            inputNumber_send8.Minimum = 0; // 设置最小值为0

            inputNumber_CAN_ID.Minimum = 0; // 设置最小值为0
            inputNumber_CAN_ID.Maximum = 0x0FFFFFFF; // 设置最大值为29位CAN ID的最大值

            CAN_TL = new();
            //  CAN_TL.channelsInformation
            //  select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.DeviceID}").ToArray());
            button_FreshChannel_Click(this, EventArgs.Empty);
            // 将浮窗创建移到 Load 事件中
            Load += Main_Load;



        }
        private void Main_Load(object? sender, EventArgs e)
        {
            // 创建浮动按钮配置
            config = new FloatButton.Config(this, new FloatButton.ConfigBtn[] {
                new FloatButton.ConfigBtn("操作1", "图标1", false)
                {
                     Tooltip = " ",
                     Type= AntdUI.TTypeMini.Primary,

                }
            }, btn =>
            {
                //  btn.Loading = true;
                // MessageBox.Show($"点击了: {btn.Name}");
            });

            config.MarginX = 20;
            config.MarginY = 20;

            FloatButton1 = AntdUI.FloatButton.open(config);

            // this.Controls.Add(FloatButton1);
            //FloatButton1 = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, new AntdUI.FloatButton.ConfigBtn[] {
            //                new AntdUI.FloatButton.ConfigBtn("id1", "SearchOutlined", true){
            //                    Tooltip = "搜索一下",
            //                    Type= AntdUI.TTypeMini.Primary,
            //                },
            //                new AntdUI.FloatButton.ConfigBtn("id2", "vvvv"){
            //                    //Badge = " ",
            //                    Tooltip = "笑死人",
            //                },
            //                new AntdUI.FloatButton.ConfigBtn("id3","aaa"){
            //                    //Badge = "9",
            //                    Tooltip = "救救我",
            //                },
            //                new AntdUI.FloatButton.ConfigBtn("id4", "PoweroffOutlined"){
            //                  //  Badge = "99+",
            //                    Tooltip = "没救了",
            //                    Round = false,
            //                    Type= AntdUI.TTypeMini.Primary,
            //                }
            //            }, btn =>
            //            {
            //                btn.Loading = true;
            //                AntdUI.ITask.Run(() =>
            //                {
            //                    System.Threading.Thread.Sleep(2000);
            //                    btn.Loading = false;
            //                });
            //                AntdUI.Message.info(this, "点击了：" + btn.Name, Font);
            //            }));

            if (FloatButton1 == null)
            {
                MessageBox.Show("无法创建浮动按钮");
            }
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

                PcanStatus result;
                if (CAN_TL.IsOpen == 'Y')
                {


                    //先关闭当前设备
                    result = Api.Uninitialize(CAN_TL.PCAN_channel);
                    if (result != PcanStatus.OK)
                    {
                        // An error occurred
                        // 
                        Api.GetErrorText(result, out var errorText);
                        Console.WriteLine(errorText);
                    }
                    else
                    {
                        CAN_TL.IsOpen = 'N';
                        Console.WriteLine($"The hardware represented by the handle {CAN_TL.PCAN_channel} was successfully finalized.");
                    }
                }
                // label_OpenedDevice.Text = " ";
                CAN_TL.PCAN_channel = CAN_TL.channelsInformation[select_AvailableDevice.SelectedIndex].ChannelHandle;
                //打开新设备
                result = Api.Initialize(CAN_TL.PCAN_channel, CAN_TL.CANBaudrate); // 使用PcanStatus类型  
                if (result != PcanStatus.OK)
                {
                    CAN_TL.IsOpen = 'N';
                    // 错误处理  
                    Api.GetErrorText(result, out var errorText);
                    Console.WriteLine(errorText);
                }
                else
                {
                    CAN_TL.IsOpen = 'Y';
                    label_OpenedDevice.Text = $"{select_AvailableDevice.Text}";
                    // A success message is shown  
                    Console.WriteLine($"The hardware represented by the handle {CAN_TL.PCAN_channel} was successfully initialized.");
                }
            }
            else
            {
                CAN_TL.IsOpen = 'N';
                MessageBox.Show("Please select a CAN device to open.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CloseDevice_Click(object sender, EventArgs e)
        {
            //先关闭当前设备
            var result = Api.Uninitialize(CAN_TL.PCAN_channel);
            if (result != PcanStatus.OK)
            {
                // An error occurred
                // 
                Api.GetErrorText(result, out var errorText);
                Console.WriteLine(errorText);
            }
            else
            {
                CAN_TL.IsOpen = 'N';
                Console.WriteLine($"The hardware represented by the handle {CAN_TL.PCAN_channel} was successfully finalized.");
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
            //    CAN_TL.bytes_send[i] = (byte)inputNumber_send8.Value; // 填充数据字节数组
            //}
            CAN_TL.bytes_send[0] = (byte)inputNumber_send1.Value;
            CAN_TL.bytes_send[1] = (byte)inputNumber_send2.Value;
            CAN_TL.bytes_send[2] = (byte)inputNumber_send3.Value;
            CAN_TL.bytes_send[3] = (byte)inputNumber_send4.Value;
            CAN_TL.bytes_send[4] = (byte)inputNumber_send5.Value;
            CAN_TL.bytes_send[5] = (byte)inputNumber_send6.Value;
            CAN_TL.bytes_send[6] = (byte)inputNumber_send7.Value;
            CAN_TL.bytes_send[7] = (byte)inputNumber_send8.Value; // 填充数据字节数组

            CAN_TL.CAN_ID = (uint)inputNumber_CAN_ID.Value; // 获取CAN ID
            // 发送数据
            CAN_TL.SendData(CAN_TL.CAN_ID, CAN_TL.bytes_send,8);
        }

        private void button_Receive_Click(object sender, EventArgs e)
        {
           uint ret = 0;
            ret = CAN_TL.ReadData(out string? str);
            if(ret!=0)
            {
               
                    textBox_CAN_Data.AppendText(str);
                textBox_CAN_Data.ScrollToCaret();
                // 限制最多1000行
                if (textBox_CAN_Data.Lines.Length > 1000)
                {
                    textBox_CAN_Data.Text = string.Join(Environment.NewLine,
                    textBox_CAN_Data.Lines.Skip(textBox_CAN_Data.Lines.Length - 1000));
                }
            }

        }
    }
}
