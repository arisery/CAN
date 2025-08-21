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
            SuspendLayout();
            // 
            // button_FreshChannel
            // 
            button_FreshChannel.Location = new Point(528, 157);
            button_FreshChannel.Name = "button_FreshChannel";
            button_FreshChannel.Size = new Size(56, 36);
            button_FreshChannel.TabIndex = 0;
            button_FreshChannel.Text = "刷新";
            button_FreshChannel.Click += button1_Click;
            // 
            // pageHeader_Top
            // 
            pageHeader_Top.Dock = DockStyle.Top;
            pageHeader_Top.Location = new Point(0, 0);
            pageHeader_Top.Name = "pageHeader_Top";
            pageHeader_Top.ShowButton = true;
            pageHeader_Top.ShowIcon = true;
            pageHeader_Top.Size = new Size(800, 39);
            pageHeader_Top.TabIndex = 1;
            pageHeader_Top.Text = "pageHeader1";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pageHeader_Top);
            Controls.Add(button_FreshChannel);
            Name = "Main";
            Text = "MainForm";
            ResumeLayout(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh channel logic here
            MessageBox.Show("Channel refreshed!");
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private AntdUI.Button button_FreshChannel;
        private AntdUI.PageHeader pageHeader_Top;
    }
}
