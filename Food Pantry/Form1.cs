using System;
using System.Collections;
using System.Timers;
using System.Windows.Forms;
using Spire.Doc;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Food_Pantry
{
    public partial class Form1 : Form
    {


        public int x = 0;
        public string name = "";
        ArrayList checkins = new ArrayList();
        String text;
        public int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (R2.TextLength > 5)
            {
                //submit.Visible = false;

            }
            else {

            }
            nameResults.Visible = true;
            listResultsLabel.Visible = true;
            string information = "33135-Zack-Pavelski-5-2/33134-Erick-Hagan-3-0";//System.IO.File.ReadAllText(@"..\info.txt");
            string[] info = information.Split('/');
            //PANTRYID-NAME_FIRST-NAME_LAST-HOUSEHOLD_MEMBERS-CHILDREN_IN_HOUSEHOLD
            //       0           1    2     3                4                   //
            //---------------------------------------------------------------------
            //nameResults.Columns.Add("Pantry_ID", 20);
            //nameResults.Columns.Add("First_Name", 10);
            //nameResults.Columns.Add("Last_Name", 10);
            foreach (string item in info) {
                string[] items = item.Split('-');
                // Pantry id, name, members in household, children
                string row = "ID:" + items[0] + "   Name:" + items[1] + items[2] + "   # in Family: " + items[3] + "   Children:" + items[4];

                if (items[0] == R2.Text)
                {
                    var listViewItem = new ListViewItem(row);
                    name = items[1] + " " + items[2];
                    nameResults.Items.Add(listViewItem);
                }
                else {
                    continue;
                }

                R2.Text = "";
            }

        }
        private void closer()
        {
            
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string path = @"C:\Users\" + userName + "\\Desktop\\" + "checkin" + ".docx";
            path = path.Replace("\\CAT", "");
            Document document = new Document();
            document.LoadFromFile(path, FileFormat.Docx);
            Paragraph paraInserted = new Paragraph(document);
            string date = DateTime.Now.ToString("M/d/yyyy");

            TextRange textD = paraInserted.AppendText(date + "\n");
            textD.CharacterFormat.FontSize = 12;

            foreach (string item in checkins)
            {

                TextRange textR = paraInserted.AppendText(item + "\n");
                textR.CharacterFormat.FontSize = 12;

            }
            
            //document.Sections[0].Paragraphs.Insert(0, document.Sections[0].Paragraphs[document.Sections[0].Paragraphs.Count - 1]);
            document.Sections[0].Paragraphs.Insert(0, paraInserted);
            document.SaveToFile(path, FileFormat.Docx);

            
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //System.Windows.Forms.Application.Restart();
            //Environment.Exit(0);
        }
        private void NameResults_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        int x = 0;
        text = nameResults.SelectedItems[x].Text;
        string date = DateTime.Now.ToString("M/d/yyyy");

        string[] lines = { text };

                
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            string path = @"C:\Users\"+userName+"\\Desktop\\" + "checkin3" + ".xls";
            path = path.Replace("\\CAT","");
            //Excel.Application xlApp = new Excel.Application();
            //xlApp.DisplayAlerts = false;

            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(path);
            //xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];        // NAME OF THE SHEET.
            //int lastUsedRow = xlWorkSheet.Cells.Find("*", System.Reflection.Missing.Value,
            //            System.Reflection.Missing.Value, System.Reflection.Missing.Value,
            //            Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
            //            false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
            ////int maxRow = xlWorkSheet.Rows.Count;
            //x = 1;
            //int y = 1;
            //while (true) {
            //    if (!(xlWorkSheet.Cells[y][x].value == "" || xlWorkSheet.Cells[5][1].value == " "))
            //    {
            //        break;
            //    }
            //    else {
            //        x++;
            //        y++;
            //    }
            //}

            //xlWorkSheet.Cells[x][y].value = text + "    date:"+date;

            //xlWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            //xlWorkBook.Close();
            //xlApp.Quit();

            //// CLEAN UP.
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);

                
       
           
            confirm.Text = name + " has been checked in!";
            checkins.Add(text);
            confirm.Text = Convert.ToString(checkins[y]);
            y++;
            nameResults.Clear();
            var listViewItem = new ListViewItem(Convert.ToString(checkins[checkins.Count - 1]));
            allCheckins.Items.Add(listViewItem);
            /*foreach (string item in checkins) {
                var listViewItem = new ListViewItem(Convert.ToString(item));
                allCheckins.Items.Add(listViewItem);
            }*/

            //nameResults.Visible = false;
            //listResultsLabel.Visible = false;
            //nameResults.Clear();
            //R2.Text = "";
            //System.Timers.Timer aTimer = new System.Timers.Timer(1500);
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Enabled = true;
            //confirm.Text = "";

        }


        private void ListResultsLabel_Click(object sender, EventArgs e)
        {
        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            closer();
            Environment.Exit(0);
        }
    }
}
