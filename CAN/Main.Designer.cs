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
            button1 = new AntdUI.Button();
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
            label_OpenedDevice.Location = new Point(689, 152);
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
            tooltip1.Location = new Point(221, 115);
            tooltip1.MaximumSize = new Size(68, 38);
            tooltip1.MinimumSize = new Size(68, 38);
            tooltip1.Name = "tooltip1";
            tooltip1.Size = new Size(68, 38);
            tooltip1.TabIndex = 8;
            tooltip1.Text = "tooltip1";
            // 
            // button1
            // 
            button1.Location = new Point(344, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 538);
            Controls.Add(button1);
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
            ResumeLayout(false);
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
        private AntdUI.Button button1;
    }
}
