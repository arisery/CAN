using AntdUI;

namespace CAN
{
    public partial class Main : AntdUI.Window
    {
          // 显示关闭、最大化、最小化按钮
   
        public Main()
        {
            
            InitializeComponent();
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }
    }
}
