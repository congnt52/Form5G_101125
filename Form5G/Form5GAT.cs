using Form5G.Instruments.BBU;
using Form5G.Instruments.VSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form5G
{
    public partial class Form5GAT : Form
    {
        public Form5GAT()
        {
            InitializeComponent();
            BBU = new BBU(this);
            frmBBU = new SetupBBU(this);
            frmVSA = new SetupVSA(this);
            #region Test1
            LoadFromXml();
            LoadXmltoTextbox();
            LoadTestcasesToTreeView();
            foreach (TreeNode node in trvTestcase.Nodes)
            {
                ApplyCheckSync(node);
            }
            trvTestcase.AfterCheck += treeView1_AfterCheck;
            #endregion



        }

        string rruSerial = "";
        int port = 1970;
        string statusBBU = "";
        public BBU BBU;
        public VSA VSA;
        SetupBBU frmBBU;
        SetupVSA frmVSA;
        //Khai bao thu muc
        public string directionPathTemplate = @"C:\test3gpp\OQC\32T32R10W\templates\";
        public void BBUConnection(string instrument, string IP, string User, string Pass, out bool connStatus)
        {
            BBU.BBUVersion(instrument);
            BBU.Connection(IP, User, Pass, out connStatus);
        }

        public void VSAConnection(string IP, string cmd, string instrument, out string manufacturer, out string model, out string serial)
        {
            VSA.Instrument(instrument);
            VSA.Connection(IP, cmd, out manufacturer, out model, out serial);
        }


        public void LogText(string text)
        {
            Console.WriteLine(text);
            string time = DateTime.Now.ToString("ddMMyyyy");
            string directoryPath = directionPathTemplate + "logs" + "\\" + time;
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            directory.Create();
            string filepath = directoryPath + "\\" + rruSerial.Trim() + "_" + time + ".txt";
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ": " + text);
            sWriter.Flush();
            fs.Close();
        }
        #region Test
        private void Form5GAT_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadFromXml()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("E:\\C# Project\\MadeNew\\Form5G\\Form5G\\config.xml"); // đọc file xml

            cbbSw1.DataSource = ds.Tables["SW1"];  // bind table Item
            cbbSw1.DisplayMember = "IP";          // hiển thị Name
            cbbSw1.ValueMember = "Id";              // giá trị thực tế là Id

            cbbSw2.DataSource = ds.Tables["SW2"];  // bind table Item
            cbbSw2.DisplayMember = "IP";          // hiển thị Name
            cbbSw2.ValueMember = "Id";              // giá trị thực tế là Id

            cbbSw3.DataSource = ds.Tables["SW3"];  // bind table Item
            cbbSw3.DisplayMember = "IP";          // hiển thị Name
            cbbSw3.ValueMember = "Id";              // giá trị thực tế là Id

           
        }
        private void LoadXmltoTextbox()
        { 
            XmlDocument doc = new XmlDocument();
            doc.Load("E:\\C# Project\\MadeNew\\Form5G\\Form5G\\config.xml");
            txtRRUSerial.Text = doc.SelectSingleNode("//SN")?.InnerText;
            txtFrequency.Text = doc.SelectSingleNode("//Freq")?.InnerText;
            txtPower.Text = doc.SelectSingleNode("//Power")?.InnerText;
        }
        private void LoadTestcasesToTreeView()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\C# Project\MadeNew\Form5G\Form5G\config.xml");

            XmlNode testcaseNode = doc.SelectSingleNode("//TestCases");

            if (testcaseNode != null)
            {
                // Xóa các node cũ
                trvTestcase.Nodes.Clear();

                // Tạo node gốc
                TreeNode root = new TreeNode("Test Cases");
                trvTestcase.Nodes.Add(root);

                // Gọi hàm đệ quy để thêm node con
                foreach (XmlNode child in testcaseNode.ChildNodes)
                {
                    TreeNode childNode = CreateTreeNode(child);
                    root.Nodes.Add(childNode);
                }

                // Mở rộng node gốc
                root.Expand();
            }
        }
        private TreeNode CreateTreeNode(XmlNode xmlNode)
        {
            // Nếu node có thuộc tính name thì lấy ra
            string text = xmlNode.Attributes?["name"]?.Value ?? xmlNode.Name;
            TreeNode treeNode = new TreeNode(text);

            // Duyệt các node con (nếu có) và thêm vào
            foreach (XmlNode child in xmlNode.ChildNodes)
            {
                treeNode.Nodes.Add(CreateTreeNode(child));
            }

            return treeNode;
        }

        



        private void btnCheckconnect_Click(object sender, EventArgs e)
        {
            StringBuilder rs = new StringBuilder();
            rs.AppendLine(CheckConnection("SW1", cbbSw1.Text));
            rs.AppendLine(CheckConnection("SW2", cbbSw2.Text));
            rs.AppendLine(CheckConnection("SW3", cbbSw3.Text));
            MessageBox.Show(rs.ToString(), "Kết quả kiểm tra kết nối",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //
        //
        //
        private void ApplyCheckSync(TreeNode node)
        {
            // Cập nhật các nút cha dựa trên trạng thái con
            UpdateParentNodes(node);

            // Duyệt tiếp các node con
            foreach (TreeNode child in node.Nodes)
            {
                ApplyCheckSync(child);
            }
        }

        bool isUpdating = false;

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (isUpdating) return;

            isUpdating = true;

            // Cập nhật các nút con
            UpdateChildNodes(e.Node, e.Node.Checked);

            // Cập nhật các nút cha
            UpdateParentNodes(e.Node);

            isUpdating = false;
        }

        private void UpdateChildNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;
                UpdateChildNodes(child, isChecked);
            }
        }

        private void UpdateParentNodes(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                bool allChecked = true;
                foreach (TreeNode sibling in parent.Nodes)
                {
                    if (!sibling.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }

                parent.Checked = allChecked;
                parent = parent.Parent;
            }
        }



        //
        //
        //

        private string CheckConnection(string name, string ipAddress)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(ipAddress, 1000); // timeout 1000ms
                    if (reply.Status == IPStatus.Success)
                    {
                       return($"{name} ({ipAddress}) kết nối thành công! " +
                                        $"Thời gian phản hồi: {reply.RoundtripTime} ms");
                    }
                    else
                    {
                        return($"{name} ({ipAddress}) KHÔNG kết nối được. Trạng thái: {reply.Status}");
                    }
                }
            }
            catch (Exception ex)
            {
                return ($"{name} ({ipAddress}) lỗi khi kiểm tra: {ex.Message}");
            }
        }

        #endregion

        //Khai bao bien
        string instrBBU, ipBBU, userBBU, passBBU;
        string statusVSA = "";
        string ipVSA = "";
        private void vSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVSA.flagConn(statusVSA);
            frmVSA.ShowDialog();
            frmVSA.StatusConnection(out ipVSA, out statusVSA);
        }

        private void dUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBBU.flagConn(statusBBU);
            frmBBU.ShowDialog();
            frmBBU.statusConnection(out ipBBU, out statusBBU);
        }
        
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            rruSerial = txtRRUSerial.Text;
            frmBBU.infor(out instrBBU, out ipBBU, out port, out userBBU, out passBBU);
        }
    }
}
