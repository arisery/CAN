using AntdUI;
using Peak.Can.Basic;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Channels;
using System.Windows.Forms;

namespace CAN
{
    public partial class Main : AntdUI.Window
    {
        public Can_TL CAN_TL;
        AntdUI.FormFloatButton FloatButton = null;
        public Main()
        {

            InitializeComponent();
            CAN_TL = new();
            //  CAN_TL.channelsInformation
            //  select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.DeviceID}").ToArray());
            button_FreshChannel_Click(this, EventArgs.Empty);
            // ����������ť����
            //var config = new FloatButton.Config(this, new[] {
            // new FloatButton.ConfigBtn("����1", "ͼ��1"),
            // new FloatButton.ConfigBtn("����2", "ͼ��2")
            //                }, btn => {
            //        // ��ť����ص�
            //     MessageBox.Show($"�����: {btn.Name}");
            //        });

            //// �򿪸�����ť
            //var floatButton = FloatButton.open(config);
            FloatButton = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, new AntdUI.FloatButton.ConfigBtn[] {
                            new AntdUI.FloatButton.ConfigBtn("id1", "SearchOutlined", true){
                                Tooltip = "����һ��",
                                Type= AntdUI.TTypeMini.Primary
                            },
                            new AntdUI.FloatButton.ConfigBtn("id2", Properties.Resources.img1){
                                Badge = " ",
                                Tooltip = "Ц����",
                            },
                            new AntdUI.FloatButton.ConfigBtn("id3",Properties.Resources.icon_like, true){
                                Badge = "9",
                                Tooltip = "�Ⱦ���"
                            },
                            new AntdUI.FloatButton.ConfigBtn("id4", "PoweroffOutlined", true){
                                Badge = "99+",
                                Tooltip = "û����",
                                Round = false,
                                Type= AntdUI.TTypeMini.Primary
                            }
                        }, btn =>
                        {
                            btn.Loading = true;
                            AntdUI.ITask.Run(() =>
                            {
                                System.Threading.Thread.Sleep(2000);
                                btn.Loading = false;
                            });
                            AntdUI.Message.info(this, "����ˣ�" + btn.Name, Font);
                        }));


        }
        private void button_FreshChannel_Click(object sender, EventArgs e)
        {
            // Refresh channel logic here
            select_AvailableDevice.Items.Clear();
            select_AvailableDevice.SelectedIndex = -1;
            try
            {
                PcanStatus result = Api.GetValue(PcanChannel.None, PcanParameter.AttachedChannelsCount, out uint channelsCount);
                if (result != PcanStatus.OK)
                {
                    // An error occurred  
                    Api.GetErrorText(result, out var errorText);
                    Console.WriteLine(errorText);
                }
                else if (channelsCount > 0)
                {
                    CAN_TL.GetCANDevice();
                    select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.DeviceID}").ToArray());

                }
                else
                {
                    select_AvailableDevice.Text = "No available CAN devices found.";
                    select_AvailableDevice.SelectedIndex = -1;
                }
            }
            catch (TypeInitializationException ex)
            {
                // ˵�� Peak.Can.Basic.Api �����ʱ����
                var detail = ex.InnerException?.Message ?? ex.Message;
                Console.WriteLine("PCAN ��ʼ������: " + detail);
            }
            catch (PcanBasicException ex)
            {
                // PCAN �Լ��׵��쳣
                Console.WriteLine("PCAN API ����: " + ex.Message);
            }
            catch (Exception ex)
            {
                // �����쳣
                Console.WriteLine("�����쳣: " + ex.Message);
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
            if (select_AvailableDevice.Items.Count > 0 && CAN_TL.IsOpen == 'N')
            {

                //result = Api.Initialize(PCAN_channel, CANBaudrate); // ʹ��PcanStatus����  
                //if (result != PcanStatus.OK)
                //{
                //    // ������  
                //    Api.GetErrorText(result, out var errorText);
                //    Console.WriteLine(errorText);
                //}
                //else
                //{
                //    // A success message is shown  
                //    Console.WriteLine($"The hardware represented by the handle {PCAN_channel} was successfully initialized.");
                //}
                label_OpenedDevice.Text = $"{select_AvailableDevice.Text}";
                CAN_TL.IsOpen = 'Y';
            }
            else if (select_AvailableDevice.Items.Count > 0 && CAN_TL.IsOpen == 'Y')
            {
                label_OpenedDevice.Text = " ";
                CAN_TL.IsOpen = 'N';
            }
            else
            {
                MessageBox.Show("Please select a CAN device to open.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CloseDevice_Click(object sender, EventArgs e)
        {

        }
    }
}
