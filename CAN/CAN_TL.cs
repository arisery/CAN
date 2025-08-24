using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CAN
{
   
public class Can_TL
    {
        public PcanChannel PCAN_channel = PcanChannel.Usb01;
        public Bitrate CANBaudrate = Bitrate.Pcan1000; // 波特率1M  
        public uint CAN_DeviceCount;
       public uint CAN_ID;
        public byte[] bytes_send = new byte[8]; // 数据字节数组，长度为8
        public PcanChannelInformation[] channelsInformation= Array.Empty<PcanChannelInformation>(); // 初始化为一个空数组  
        public char IsOpen = 'N'; // 是否打开设备，默认为未打开
        public Can_TL()
        {
            GetCANDevice();
        }

        public void GetCANDevice()
        {
            PcanChannel channel = PcanChannel.None;
            
            try
            {
                // The amount of hardware currently attached to the system is retrieved  
              PcanStatus  result = Api.GetValue(channel, PcanParameter.AttachedChannelsCount, out  CAN_DeviceCount);
                if (result != PcanStatus.OK)
                {
                    // An error occurred  
                    Api.GetErrorText(result, out var errorText);
                    Console.WriteLine(errorText);
                }
                else
                {
                    // Information about the hardware currently attached to the system is retrieved  
                    channelsInformation = new PcanChannelInformation[CAN_DeviceCount];
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
                        Console.WriteLine($"There are {CAN_DeviceCount} Channels attached to the system:");
                        for (int i = 0; i < CAN_DeviceCount; i++)
                        {
                            Console.WriteLine(" {0}) ---------------------------", i + 1);
                            Console.WriteLine("    Name: {0}", channelsInformation[i].DeviceName);
                            Console.WriteLine("    Handle: 0x{0:X}", channelsInformation[i].ChannelHandle);
                            Console.WriteLine("    Controller: {0}", channelsInformation[i].ControllerNumber);
                            Console.WriteLine("    Condition: {0}", channelsInformation[i].ChannelCondition);
                        }
                    }

                }

            }
            catch (TypeInitializationException ex)
            {
                // 说明 Peak.Can.Basic.Api 类加载时出错
                var detail = ex.InnerException?.Message ?? ex.Message;
                Console.WriteLine("PCAN 初始化错误: " + detail);
            }
            catch (PcanBasicException ex)
            {
                // PCAN 自己抛的异常
                Console.WriteLine("PCAN API 错误: " + ex.Message);
            }
            catch (Exception ex)
            {
                // 兜底异常
                Console.WriteLine("其他异常: " + ex.Message);
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

        public void ModeChanged(uint mode)
        {

        }
        public uint SendData(uint ID,byte[] data,byte Length)
        {
            if (IsOpen == 'N')
            {
                Console.WriteLine("设备未打开，请先打开设备。");
                return 0; // 或者抛出异常
            }
            PcanMessage message = new PcanMessage();
            
            message.DLC = Length; // 设置数据长度
            message.Data = data;
            message.ID = ID; // 设置CAN ID
            // 发送数据的逻辑
            // 这里需要使用 Peak.Can.Basic.Api.Send 方法来发送数据
            // 假设 data 是要发送的数据字节数组
            // 示例代码（需要根据实际情况调整）：
            PcanStatus status = Api.Write(PCAN_channel, message);
            if (status != PcanStatus.OK)
            {
                Api.GetErrorText(status, out var errorText);
                Console.WriteLine($"发送数据失败: {errorText}");
                return 0; // 或者抛出异常
            }
            Console.WriteLine("数据发送成功");
            
            return 1; // 返回成功标志
        }

        public uint ReadData(out string? str)
        {
            StringBuilder receivedDataBuilder = new StringBuilder();
            str = null;
            if (IsOpen == 'N')
            {
                Console.WriteLine("设备未打开，请先打开设备。");
                str = null;
                return 0; // 或者抛出异常
            }
            PcanMessage msg;
            ulong timestamp;
            PcanStatus result;
            do
            {
                result = Api.Read(PCAN_channel, out msg, out timestamp);
                if (result == PcanStatus.OK)
                {
                    // Process the received message
                    // 
                    //ProcessMessage(msg, timestamp);
                    string hexData = string.Join(" ", Enumerable.Range(0, msg.DLC)
                                                    .Select(i => "0x" + msg.Data[i].ToString("X2")));
                    
                    receivedDataBuilder.AppendLine($"[{DateTime.Now:HH:mm:ss.fff}] :{hexData}");
                    Console.WriteLine(hexData);
                }
                else
                {
                    if ((result & PcanStatus.ReceiveQueueEmpty) != PcanStatus.ReceiveQueueEmpty)
                    {
                        // An unexpected error occurred
                        // 
                        Api.GetErrorText(result, out var errorText);
                        Console.WriteLine("Reading process canceled due to unexpected error: " + errorText);
                        break;
                    }
                }

            } while ((result & PcanStatus.ReceiveQueueEmpty) != PcanStatus.ReceiveQueueEmpty);
            str = receivedDataBuilder.ToString();
            return 1; // 返回成功标志
        }
    }
}
