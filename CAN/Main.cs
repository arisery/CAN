using AntdUI;
using Peak.Can.Basic;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Channels;

namespace CAN
{
    public partial class Main : AntdUI.Window
    {
        public Can_TL CAN_TL;

        public Main()
        {

            InitializeComponent();
            CAN_TL = new();
            //  CAN_TL.channelsInformation
            //  select_AvailableDevice.Items.AddRange(CAN_TL.channelsInformation.Select(c => $"{c.DeviceName}-{c.DeviceID}").ToArray());
            button_FreshChannel_Click(this, EventArgs.Empty);




        }
        private void button_FreshChannel_Click(object sender, EventArgs e)
        {
            // Refresh channel logic here
            select_AvailableDevice.Items.Clear();
            select_AvailableDevice.SelectedIndex = -1;
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

                //result = Api.Initialize(PCAN_channel, CANBaudrate); // 使用PcanStatus类型  
                //if (result != PcanStatus.OK)
                //{
                //    // 错误处理  
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
    }
}
