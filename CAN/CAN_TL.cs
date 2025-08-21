using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN
{
   
public class Can_TL
    {
        public PcanChannel PCAN_channel = PcanChannel.Usb01;
        public Bitrate CANBaudrate = Bitrate.Pcan1000; // 波特率1M  
        public PcanChannelInformation[] channelsInformation= Array.Empty<PcanChannelInformation>(); // 初始化为一个空数组  
        public char IsOpen = 'N'; // 是否打开设备，默认为未打开
        public Can_TL()
        {
            GetCANDevice();
        }

        public void GetCANDevice()
        {
            PcanChannel channel = PcanChannel.None;

            // The amount of hardware currently attached to the system is retrieved  
            PcanStatus result = Api.GetValue(channel, PcanParameter.AttachedChannelsCount, out uint channelsCount);
            if (result != PcanStatus.OK)
            {
                // An error occurred  
                Api.GetErrorText(result, out var errorText);
                Console.WriteLine(errorText);
            }
            else
            {
                // Information about the hardware currently attached to the system is retrieved  
                channelsInformation = new PcanChannelInformation[channelsCount];
                result = Api.GetValue(channel, PcanParameter.AttachedChannelsInformation, channelsInformation);
                if (result != PcanStatus.OK)
                {
                    // An error occurred  
                    Api.GetErrorText(result, out var errorText);
                    Console.WriteLine(errorText);
                }
                else
                {
                    // The information about the channels is shown  
                    Console.WriteLine($"There are {channelsCount} Channels attached to the system:");
                    for (int i = 0; i < channelsCount; i++)
                    {
                        Console.WriteLine(" {0}) ---------------------------", i + 1);
                        Console.WriteLine("    Name: {0}", channelsInformation[i].DeviceName);
                        Console.WriteLine("    Handle: 0x{0:X}", channelsInformation[i].ChannelHandle);
                        Console.WriteLine("    Controller: {0}", channelsInformation[i].ControllerNumber);
                        Console.WriteLine("    Condition: {0}", channelsInformation[i].ChannelCondition);
                    }
                }
            }

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
        }
    }
}
