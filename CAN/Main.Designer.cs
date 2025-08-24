namespace CAN
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_FreshChannel = new AntdUI.Button();
            pageHeader_Top = new AntdUI.PageHeader();
            select_AvailableDevice = new AntdUI.Select();
            button_OpenDevice = new AntdUI.Button();
            checkbox1 = new AntdUI.Checkbox();
            label_OpenedDevice = new AntdUI.Label();
            label2 = new AntdUI.Label();
            button_CloseDevice = new AntdUI.Button();
            tooltip1 = new AntdUI.Tooltip();
            button_Transmit = new AntdUI.Button();
            button_Tip = new AntdUI.Button();
            button_boot = new AntdUI.Button();
            button_shutdown = new AntdUI.Button();
            label_velocity = new AntdUI.Label();
            labelTime1 = new AntdUI.LabelTime();
            label_torque = new AntdUI.Label();
            label_position = new AntdUI.Label();
            inputNumber_velocity = new AntdUI.InputNumber();
            inputNumber_torque = new AntdUI.InputNumber();
            inputNumber_positon = new AntdUI.InputNumber();
            panel_Mode = new AntdUI.Panel();
            label_Mode = new AntdUI.Label();
            radio_position = new AntdUI.Radio();
            radio_velocity = new AntdUI.Radio();
            radio_Torque = new AntdUI.Radio();
            inputNumber_send1 = new AntdUI.InputNumber();
            panel1 = new AntdUI.Panel();
            inputNumber_send8 = new AntdUI.InputNumber();
            inputNumber_send7 = new AntdUI.InputNumber();
            inputNumber_send6 = new AntdUI.InputNumber();
            inputNumber_send5 = new AntdUI.InputNumber();
            inputNumber_send4 = new AntdUI.InputNumber();
            inputNumber_send3 = new AntdUI.InputNumber();
            inputNumber_send2 = new AntdUI.InputNumber();
            textBox_CAN_Data = new TextBox();
            button_Receive = new AntdUI.Button();
            inputNumber_CAN_ID = new AntdUI.InputNumber();
            label_CAN_ID = new AntdUI.Label();
            panel_Mode.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_FreshChannel
            // 
            button_FreshChannel.Location = new Point(742, 45);
            button_FreshChannel.Name = "button_FreshChannel";
            button_FreshChannel.Size = new Size(56, 36);
            button_FreshChannel.TabIndex = 0;
            button_FreshChannel.Text = "刷新";
            button_FreshChannel.Click += button_FreshChannel_Click;
            // 
            // pageHeader_Top
            // 
            pageHeader_Top.Dock = DockStyle.Top;
            pageHeader_Top.Location = new Point(0, 0);
            pageHeader_Top.Name = "pageHeader_Top";
            pageHeader_Top.ShowButton = true;
            pageHeader_Top.ShowIcon = true;
            pageHeader_Top.Size = new Size(884, 39);
            pageHeader_Top.TabIndex = 1;
            pageHeader_Top.Text = "CAN";
            pageHeader_Top.Click += pageHeader_Top_Click;
            // 
            // select_AvailableDevice
            // 
            select_AvailableDevice.Location = new Point(523, 41);
            select_AvailableDevice.Name = "select_AvailableDevice";
            select_AvailableDevice.SelectionStart = 6;
            select_AvailableDevice.Size = new Size(204, 40);
            select_AvailableDevice.TabIndex = 2;
            select_AvailableDevice.Text = "device";
            select_AvailableDevice.SelectedIndexChanged += select_AvailableDevice_SelectedIndexChanged;
            // 
            // button_OpenDevice
            // 
            button_OpenDevice.Location = new Point(575, 96);
            button_OpenDevice.Name = "button_OpenDevice";
            button_OpenDevice.Size = new Size(74, 33);
            button_OpenDevice.TabIndex = 3;
            button_OpenDevice.Text = "打开";
            button_OpenDevice.Click += button_OpenDevice_Click;
            // 
            // checkbox1
            // 
            checkbox1.Location = new Point(484, 236);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(8, 8);
            checkbox1.TabIndex = 4;
            checkbox1.Text = "checkbox1";
            // 
            // label_OpenedDevice
            // 
            label_OpenedDevice.BackColor = SystemColors.ActiveCaption;
            label_OpenedDevice.Location = new Point(669, 152);
            label_OpenedDevice.Name = "label_OpenedDevice";
            label_OpenedDevice.Size = new Size(141, 23);
            label_OpenedDevice.TabIndex = 5;
            label_OpenedDevice.Text = "";
            // 
            // label2
            // 
            label2.Location = new Point(575, 145);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 6;
            label2.Text = "当前设备：";
            // 
            // button_CloseDevice
            // 
            button_CloseDevice.Location = new Point(689, 96);
            button_CloseDevice.Name = "button_CloseDevice";
            button_CloseDevice.Size = new Size(74, 33);
            button_CloseDevice.TabIndex = 7;
            button_CloseDevice.Text = "关闭";
            button_CloseDevice.Click += button_CloseDevice_Click;
            // 
            // tooltip1
            // 
            tooltip1.Location = new Point(553, 276);
            tooltip1.MaximumSize = new Size(68, 38);
            tooltip1.MinimumSize = new Size(68, 38);
            tooltip1.Name = "tooltip1";
            tooltip1.Size = new Size(68, 38);
            tooltip1.TabIndex = 8;
            tooltip1.Text = "tooltip1";
            // 
            // button_Transmit
            // 
            button_Transmit.Location = new Point(458, 292);
            button_Transmit.Name = "button_Transmit";
            button_Transmit.Size = new Size(47, 42);
            button_Transmit.TabIndex = 9;
            button_Transmit.Text = "发送";
            button_Transmit.Click += button_Transmit_Click;
            // 
            // button_Tip
            // 
            button_Tip.Location = new Point(458, 45);
            button_Tip.Name = "button_Tip";
            button_Tip.Size = new Size(48, 38);
            button_Tip.TabIndex = 11;
            button_Tip.Text = "Tip";
            button_Tip.MouseEnter += button_Tip_MouseEnter;
            // 
            // button_boot
            // 
            button_boot.Location = new Point(50, 58);
            button_boot.Name = "button_boot";
            button_boot.Size = new Size(66, 36);
            button_boot.TabIndex = 12;
            button_boot.Text = "启动";
            button_boot.Click += button2_Click;
            // 
            // button_shutdown
            // 
            button_shutdown.Location = new Point(160, 60);
            button_shutdown.Name = "button_shutdown";
            button_shutdown.Size = new Size(72, 34);
            button_shutdown.TabIndex = 13;
            button_shutdown.Text = "关闭";
            // 
            // label_velocity
            // 
            label_velocity.Location = new Point(50, 187);
            label_velocity.Name = "label_velocity";
            label_velocity.Size = new Size(75, 23);
            label_velocity.TabIndex = 14;
            label_velocity.Text = "velocity";
            label_velocity.Click += label1_Click;
            // 
            // labelTime1
            // 
            labelTime1.Location = new Point(280, 29);
            labelTime1.Name = "labelTime1";
            labelTime1.Size = new Size(75, 23);
            labelTime1.TabIndex = 15;
            labelTime1.Text = "labelTime1";
            // 
            // label_torque
            // 
            label_torque.Location = new Point(50, 141);
            label_torque.Name = "label_torque";
            label_torque.Size = new Size(75, 23);
            label_torque.TabIndex = 16;
            label_torque.Text = "torque";
            // 
            // label_position
            // 
            label_position.Location = new Point(50, 236);
            label_position.Name = "label_position";
            label_position.Size = new Size(75, 23);
            label_position.TabIndex = 17;
            label_position.Text = "position";
            // 
            // inputNumber_velocity
            // 
            inputNumber_velocity.Location = new Point(140, 169);
            inputNumber_velocity.Name = "inputNumber_velocity";
            inputNumber_velocity.SelectionStart = 1;
            inputNumber_velocity.Size = new Size(135, 41);
            inputNumber_velocity.TabIndex = 18;
            inputNumber_velocity.Text = "0";
            // 
            // inputNumber_torque
            // 
            inputNumber_torque.Location = new Point(140, 123);
            inputNumber_torque.Name = "inputNumber_torque";
            inputNumber_torque.SelectionStart = 1;
            inputNumber_torque.Size = new Size(135, 41);
            inputNumber_torque.TabIndex = 19;
            inputNumber_torque.Text = "0";
            // 
            // inputNumber_positon
            // 
            inputNumber_positon.Location = new Point(140, 220);
            inputNumber_positon.Name = "inputNumber_positon";
            inputNumber_positon.SelectionStart = 1;
            inputNumber_positon.Size = new Size(135, 41);
            inputNumber_positon.TabIndex = 20;
            inputNumber_positon.Text = "0";
            // 
            // panel_Mode
            // 
            panel_Mode.Controls.Add(label_Mode);
            panel_Mode.Controls.Add(radio_position);
            panel_Mode.Controls.Add(radio_velocity);
            panel_Mode.Controls.Add(radio_Torque);
            panel_Mode.Location = new Point(291, 123);
            panel_Mode.Name = "panel_Mode";
            panel_Mode.Size = new Size(120, 131);
            panel_Mode.TabIndex = 21;
            panel_Mode.Text = "panel1";
            // 
            // label_Mode
            // 
            label_Mode.Location = new Point(3, 6);
            label_Mode.Name = "label_Mode";
            label_Mode.Size = new Size(75, 23);
            label_Mode.TabIndex = 24;
            label_Mode.Text = "MODE";
            // 
            // radio_position
            // 
            radio_position.Location = new Point(3, 93);
            radio_position.Name = "radio_position";
            radio_position.Size = new Size(75, 23);
            radio_position.TabIndex = 23;
            radio_position.Text = "position";
            // 
            // radio_velocity
            // 
            radio_velocity.Location = new Point(3, 64);
            radio_velocity.Name = "radio_velocity";
            radio_velocity.Size = new Size(75, 23);
            radio_velocity.TabIndex = 22;
            radio_velocity.Text = "velocity";
            // 
            // radio_Torque
            // 
            radio_Torque.Location = new Point(3, 35);
            radio_Torque.Name = "radio_Torque";
            radio_Torque.Size = new Size(75, 23);
            radio_Torque.TabIndex = 0;
            radio_Torque.Text = "Torque";
            // 
            // inputNumber_send1
            // 
            inputNumber_send1.Location = new Point(3, 3);
            inputNumber_send1.Name = "inputNumber_send1";
            inputNumber_send1.SelectionStart = 1;
            inputNumber_send1.Size = new Size(42, 34);
            inputNumber_send1.TabIndex = 22;
            inputNumber_send1.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(inputNumber_send8);
            panel1.Controls.Add(inputNumber_send7);
            panel1.Controls.Add(inputNumber_send6);
            panel1.Controls.Add(inputNumber_send5);
            panel1.Controls.Add(inputNumber_send4);
            panel1.Controls.Add(inputNumber_send3);
            panel1.Controls.Add(inputNumber_send2);
            panel1.Controls.Add(inputNumber_send1);
            panel1.Location = new Point(37, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 42);
            panel1.TabIndex = 23;
            panel1.Text = "panel1";
            panel1.Click += panel1_Click;
            // 
            // inputNumber_send8
            // 
            inputNumber_send8.Location = new Point(334, 5);
            inputNumber_send8.Name = "inputNumber_send8";
            inputNumber_send8.SelectionStart = 1;
            inputNumber_send8.Size = new Size(42, 34);
            inputNumber_send8.TabIndex = 29;
            inputNumber_send8.Text = "0";
            // 
            // inputNumber_send7
            // 
            inputNumber_send7.Location = new Point(286, 5);
            inputNumber_send7.Name = "inputNumber_send7";
            inputNumber_send7.SelectionStart = 1;
            inputNumber_send7.Size = new Size(42, 34);
            inputNumber_send7.TabIndex = 28;
            inputNumber_send7.Text = "0";
            // 
            // inputNumber_send6
            // 
            inputNumber_send6.Location = new Point(238, 5);
            inputNumber_send6.Name = "inputNumber_send6";
            inputNumber_send6.SelectionStart = 1;
            inputNumber_send6.Size = new Size(42, 34);
            inputNumber_send6.TabIndex = 27;
            inputNumber_send6.Text = "0";
            // 
            // inputNumber_send5
            // 
            inputNumber_send5.Location = new Point(190, 5);
            inputNumber_send5.Name = "inputNumber_send5";
            inputNumber_send5.SelectionStart = 1;
            inputNumber_send5.Size = new Size(42, 34);
            inputNumber_send5.TabIndex = 26;
            inputNumber_send5.Text = "0";
            // 
            // inputNumber_send4
            // 
            inputNumber_send4.Location = new Point(142, 5);
            inputNumber_send4.Name = "inputNumber_send4";
            inputNumber_send4.SelectionStart = 1;
            inputNumber_send4.Size = new Size(42, 34);
            inputNumber_send4.TabIndex = 25;
            inputNumber_send4.Text = "0";
            // 
            // inputNumber_send3
            // 
            inputNumber_send3.Location = new Point(94, 3);
            inputNumber_send3.Name = "inputNumber_send3";
            inputNumber_send3.SelectionStart = 1;
            inputNumber_send3.Size = new Size(42, 34);
            inputNumber_send3.TabIndex = 24;
            inputNumber_send3.Text = "0";
            // 
            // inputNumber_send2
            // 
            inputNumber_send2.Location = new Point(46, 3);
            inputNumber_send2.Name = "inputNumber_send2";
            inputNumber_send2.SelectionStart = 1;
            inputNumber_send2.Size = new Size(42, 34);
            inputNumber_send2.TabIndex = 23;
            inputNumber_send2.Text = "0";
            // 
            // textBox_CAN_Data
            // 
            textBox_CAN_Data.Location = new Point(40, 356);
            textBox_CAN_Data.Multiline = true;
            textBox_CAN_Data.Name = "textBox_CAN_Data";
            textBox_CAN_Data.Size = new Size(383, 145);
            textBox_CAN_Data.TabIndex = 24;
            // 
            // button_Receive
            // 
            button_Receive.Location = new Point(445, 414);
            button_Receive.Name = "button_Receive";
            button_Receive.Size = new Size(47, 42);
            button_Receive.TabIndex = 25;
            button_Receive.Text = "接收";
            button_Receive.Click += button_Receive_Click;
            // 
            // inputNumber_CAN_ID
            // 
            inputNumber_CAN_ID.Location = new Point(140, 257);
            inputNumber_CAN_ID.Name = "inputNumber_CAN_ID";
            inputNumber_CAN_ID.SelectionStart = 1;
            inputNumber_CAN_ID.Size = new Size(81, 32);
            inputNumber_CAN_ID.TabIndex = 26;
            inputNumber_CAN_ID.Text = "0";
            // 
            // label_CAN_ID
            // 
            label_CAN_ID.Location = new Point(50, 266);
            label_CAN_ID.Name = "label_CAN_ID";
            label_CAN_ID.Size = new Size(75, 23);
            label_CAN_ID.TabIndex = 27;
            label_CAN_ID.Text = "ID";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 538);
            Controls.Add(label_CAN_ID);
            Controls.Add(inputNumber_CAN_ID);
            Controls.Add(button_Receive);
            Controls.Add(textBox_CAN_Data);
            Controls.Add(panel1);
            Controls.Add(panel_Mode);
            Controls.Add(inputNumber_positon);
            Controls.Add(inputNumber_torque);
            Controls.Add(inputNumber_velocity);
            Controls.Add(label_position);
            Controls.Add(label_torque);
            Controls.Add(labelTime1);
            Controls.Add(label_velocity);
            Controls.Add(button_shutdown);
            Controls.Add(button_boot);
            Controls.Add(button_Tip);
            Controls.Add(button_Transmit);
            Controls.Add(tooltip1);
            Controls.Add(button_CloseDevice);
            Controls.Add(label2);
            Controls.Add(label_OpenedDevice);
            Controls.Add(checkbox1);
            Controls.Add(button_OpenDevice);
            Controls.Add(select_AvailableDevice);
            Controls.Add(pageHeader_Top);
            Controls.Add(button_FreshChannel);
            Name = "Main";
            Text = "MainForm";
            Load += Main_Load_1;
            panel_Mode.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private SaveFileDialog saveFileDialog1;
        private AntdUI.Button button_FreshChannel;
        private AntdUI.PageHeader pageHeader_Top;
        private AntdUI.Select select_AvailableDevice;
        private AntdUI.Button button_OpenDevice;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Label label_OpenedDevice;
        private AntdUI.Label label2;
        private AntdUI.Button button_CloseDevice;
        private AntdUI.Tooltip tooltip1;
        private AntdUI.Button button_Transmit;
        private AntdUI.Button button_Tip;
        private AntdUI.Button button_boot;
        private AntdUI.Button button_shutdown;
        private AntdUI.Label label_velocity;
        private AntdUI.LabelTime labelTime1;
        private AntdUI.Label label_torque;
        private AntdUI.Label label_position;
        private AntdUI.InputNumber inputNumber_velocity;
        private AntdUI.InputNumber inputNumber_torque;
        private AntdUI.InputNumber inputNumber_positon;
        private AntdUI.Panel panel_Mode;
        private AntdUI.Radio radio_velocity;
        private AntdUI.Radio radio_Torque;
        private AntdUI.Label label_Mode;
        private AntdUI.Radio radio_position;
        private AntdUI.InputNumber inputNumber_send1;
        private AntdUI.Panel panel1;
        private AntdUI.InputNumber inputNumber_send6;
        private AntdUI.InputNumber inputNumber_send5;
        private AntdUI.InputNumber inputNumber_send4;
        private AntdUI.InputNumber inputNumber_send3;
        private AntdUI.InputNumber inputNumber_send2;
        private AntdUI.InputNumber inputNumber_send8;
        private AntdUI.InputNumber inputNumber_send7;
        private TextBox textBox_CAN_Data;
        private AntdUI.Button button_Receive;
        private AntdUI.InputNumber inputNumber_CAN_ID;
        private AntdUI.Label label_CAN_ID;
    }
}
