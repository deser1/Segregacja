//using Ext.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Segregacja
{
    public partial class MainForm : Form
    {
        private String BootleText;
        private String ShiftNumberText;
        private readonly String appPath = Path.GetDirectoryName(Application.ExecutablePath);
        private String XmlPath { get; set; }
        private Document xml;
        private XmlTextReader XmlRead = null;
        private List<string> ElementName;
        private List<string> SubElementName;
        private List<string> TextName;

        protected void LoadXML(String filename)
        {
            int i = 0;
            try
            {
                XmlPath = filename;
                XmlRead = new XmlTextReader(XmlPath);
                XmlRead.MoveToContent();
                
                if ((XmlRead.NodeType == XmlNodeType.Element) && (XmlRead.Name == "Document"))
                {
                    /*while (XmlRead.Read())
                    {
                        if (XmlRead.NodeType == XmlNodeType.Element)
                        {
                            ElementName = new string[i];
                            //Count Element
                            i++;
                        }
                    }*/
                    ElementName = new List<string>();
                    TextName = new List<string>();
                    while (XmlRead.Read())
                    {
                        if (XmlRead.NodeType == XmlNodeType.Element)
                        {
                            //Read element name node
                            ElementName.Add(XmlRead.Name);

                            XmlRead.Read();
                            //Read text element properities
                            if ((XmlRead.NodeType == XmlNodeType.Text) && (XmlRead.HasValue))
                            {
                                TextName.Add(XmlRead.Value);
                            }
                            i++;
                        }
                    }
                }
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Document));
                xmlSerializer.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
                xmlSerializer.UnknownAttribute += new XmlAttributeEventHandler(XmlSerializer_UnknownAttribute);
                StreamReader reader = new StreamReader(@XmlPath);
                xml = (Document)xmlSerializer.Deserialize(reader);
                if (reader != null)
                    reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        protected void XmlSerializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            MessageBox.Show("Unknown Node:" + e.Name + "\t" + e.Text,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        protected void XmlSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            MessageBox.Show("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
            BootleType.SelectedIndex = 0;
            ShiftNumber.SelectedIndex = 0;
            //Load BootleType in ComboBox
            //xml = new Document();
            //while (xml.BootleTypes.Items>0)
            //{

            //}
            BootleType.Items.Add("test");
            DateComboBox.Value = DateTime.Now;
            System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fieVersionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
            var version = fieVersionInfo.FileVersion;
            Text = "Segregacja v."+version;
            XmlPath = appPath + "\\" + "document.xml";
            LoadXML(XmlPath);
        }

        private void SegregacjaPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 0;
            //int y = 360;
            int xwidth = 825;//A4 = {Width:2480px, Height: 3508px}
            int yheight = 630;
            //Fon = new Font("Arial", 36, FontStyle.Bold);
            Rectangle Rect = new Rectangle(x, 0, xwidth, yheight);//Title
            Rectangle Rect1 = new Rectangle(x, 150, xwidth, yheight);//Typ butelki
            Rectangle Rect2 = new Rectangle(x, 330, xwidth, yheight);//Zmiana ....
            Rectangle Rect3 = new Rectangle(x, 330, xwidth, yheight);//Zmiana nr
            Rectangle Rect4 = new Rectangle(x, 530, xwidth, yheight);//Date
            BootleText = BootleType.GetItemText(BootleType.SelectedItem);
            //DateComboBoxValue = String.Format("{0:dd.mm.yyyy}",DateComboBox.Value);
            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            //Malowanie ramki z tłem
            //e.Graphics.FillRectangle(Brushes.WhiteSmoke, Rect);
            // e.Graphics.DrawRectangle(Pens.Black, Rect);
            e.Graphics.DrawString("WYSEGREGOWANE BUTELKI", new Font("Arial", 36, FontStyle.Bold), Brushes.Black, Rect, sf);
            e.Graphics.DrawString(BootleText, new Font("Arial", 72, FontStyle.Bold), Brushes.Black, Rect1, sf);
            if (NoQueryShiftNumberRadioButton.Checked) {
                e.Graphics.DrawString("ZMIANA .....", new Font("Arial", 72, FontStyle.Bold), Brushes.Black, Rect2, sf);
            }else if (YesQueryShiftNumberRadioButton.Checked)
            {
                e.Graphics.DrawString("ZMIANA " + ShiftNumberText, new Font("Arial", 72, FontStyle.Bold), Brushes.Black, Rect3, sf);
            }
            e.Graphics.DrawString(DateComboBox.Value.ToString("dd.MM.yyyy"), new Font("Arial", 72, FontStyle.Bold), Brushes.Black, Rect4, sf);
            //new Point(0,0)
        }

        private void BootleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BootleText = BootleType.GetItemText(BootleType.SelectedItem);
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
        }

        private void ShiftNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftNumberText = ShiftNumber.GetItemText(ShiftNumber.SelectedItem);
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
        }

        private void YesQueryShiftNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxShiftNumber.Enabled = true;
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
        }

        private void NoQueryShiftNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxShiftNumber.Enabled = false;
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
        }

        private void Zoomin_Click(object sender, EventArgs e)
        {
            SegregacjaPrintPreviewControl.Zoom = 0.7;
        }

        private void Zoomout_Click(object sender, EventArgs e)
        {
            SegregacjaPrintPreviewControl.AutoZoom = true;
        }

        private void DateComboBox_ValueChanged(object sender, EventArgs e)
        {
            SegregacjaPrintPreviewControl.Document = SegregacjaPrintDocument;
        }

        private void MenuNotifyClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = SegregacjaPrintDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                SegregacjaPrintDocument.Print();
            }
                
        }

        private void SegregacjaRestoreDate_Click(object sender, EventArgs e)
        {
            DateComboBox.Value = DateTime.Now;
        }

        private void MenuNotifyAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
