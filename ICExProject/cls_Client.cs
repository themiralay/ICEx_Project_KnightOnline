using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace ICEProject
{
    public class cls_Client : cls_Api
    {

        public void getWinName(string WindFile, ListView lstView)
        {
            lstView.Items.Clear();
            foreach (Process WindP in Process.GetProcesses())
            {
                if (WindP.ProcessName == WindFile)
                {
                    ListViewItem lstItem = new ListViewItem(new string[] { WindP.MainWindowTitle, "Enes Can", "Işık", "13123" });
                    lstView.Items.Add(lstItem);
                }
            }
        }
        public bool searchListView(string vwText, int vwColumn, ListView vwList)
        {
            bool result = false;
            if (vwList.Columns.Count >= vwColumn)
            {
                for (int i = 0; i < vwList.Items.Count; )
                {
                    if (vwColumn <= 1)
                    {
                        if (vwList.Items[i].Text == vwText)
                        {
                            vwList.Items[i].EnsureVisible();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (vwList.Items[i].SubItems[vwColumn - 1].Text == vwText)
                        {
                            vwList.Items[i].EnsureVisible();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return result;
        }
        public void goTxt(string txtMessage)
        {
            MessageBox.Show(txtMessage, "ICE Project Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void setControls(CheckedListBox lst,int Count)
        {
            lst.Items.Clear();
            for (int i = 0; i < Count; i++)
            {
                lst.Items.Add("(" + (i + 1).ToString() + ")");
            }
        }
        public static void setCheckedList(CheckBox chk, CheckedListBox lst)
        {
            for (int i = 0; i <= lst.Items.Count -1 ; i++)
            {
                if (chk.Checked)
                    lst.SetItemCheckState(i, CheckState.Checked);
                else
                    lst.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
