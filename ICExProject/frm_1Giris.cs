using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICEProject
{
    public partial class frm_1Giris : Form
    {
        cls_Client Client = new cls_Client();
        string frm_savePath = AppDomain.CurrentDomain.BaseDirectory + "frmGiris.cs";
        public frm_1Giris()
        {
            InitializeComponent();
        }
        
        #region [Menu_code]
        private void m_TopMost_Click(object sender, EventArgs e)
        {
            if (m_TopMost.Checked) { m_TopMost.Checked = false; } else { m_TopMost.Checked = true; }
        }
        private void m_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = m_TopMost.Checked;
        }
        private void m_Hide_Click(object sender, EventArgs e)
        {
            N_icon.Visible = true;
            N_icon.ShowBalloonTip(0, "[ICE Project - Bilgilendirme]", "Bot buraya gizlendi..", ToolTipIcon.Info);
            Hide();
        }
        private void N_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            N_icon.Visible = false;
            Show();
        }

        private void m_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        
        private void btn_ayarkaydet_Click(object sender, EventArgs e)
        {
            frmSaveRead(true);
        }
        public void frmSaveRead(bool frmStatu)
        {
            if (frmStatu)
            {
                cls_IniFile svIini = new cls_IniFile(frm_savePath, "Giriş Bölümü");
                svIini.Write("clntCount", (lstv_oyunlar.Items.Count).ToString());
                for (int i = 0; i < lstv_oyunlar.Items.Count; i++)
                {
                    svIini.Write("ClientText(" + i + ")", lstv_oyunlar.Items[i].Text);
                    svIini.Write("ClientName(" + i + ")", lstv_oyunlar.Items[i].SubItems[1].Text);
                    svIini.Write("ClientServer(" + i + ")", lstv_oyunlar.Items[i].SubItems[2].Text);
                    svIini.Write("ClientJob(" + i + ")", lstv_oyunlar.Items[i].SubItems[3].Text);
                    svIini.Write("ClientCheck(" + i + ")", lstv_oyunlar.Items[i].Checked.ToString());
                }
                svIini.Write("chk_hepsinisec", chk_hepsinisec.Checked.ToString());
            }
            else
            {
                if (File.Exists(frm_savePath))
                {
                    cls_IniFile svIini = new cls_IniFile(frm_savePath, "Giriş Bölümü");
                    for (int i = 0; i < Convert.ToInt32(svIini.Read("clntCount")); i++)
                    {
                        if (Client.searchListView(svIini.Read("ClientText(" + i + ")"), 1, lstv_oyunlar) == false)
                        {
                            ListViewItem svItem = new ListViewItem(new string[] { svIini.Read("ClientText(" + i + ")"), svIini.Read("ClientName(" + i + ")"), svIini.Read("ClientServer(" + i + ")"), svIini.Read("ClientJob(" + i + ")") });
                            svItem.Checked = Convert.ToBoolean(svIini.Read("ClientCheck(" + i + ")"));
                            lstv_oyunlar.Items.Add(svItem);

                        }
                    }
                }
                else
                {
                    Client.goTxt("Giriş kayıt dosyası bulunamadı !");
                }
            }
        }

        private void frm_ICEProject_Load(object sender, EventArgs e)
        {
            frmSaveRead(false);
            Client.getWinName("KnightOnLine", lstv_acikoyunlar);
            int a1 = 220;
            string Deneme = a1.ToString() + "007";
            Console.WriteLine(Convert.ToInt32(Deneme));
        }

        private void lstv_acikoyunlar_DoubleClick(object sender, EventArgs e)
        {
            string selctItem = lstv_acikoyunlar.Items[lstv_acikoyunlar.FocusedItem.Index].Text;
            if (lstv_acikoyunlar.FocusedItem.Index > -1 && Client.searchListView(selctItem, 1, lstv_oyunlar) == false)
            {
                ListViewItem fcsItem = lstv_acikoyunlar.FocusedItem;
                lstv_oyunlar.Items.Add((ListViewItem)fcsItem.Clone());
                lstv_acikoyunlar.FocusedItem.Remove();
            }
        }

        private void btn_yukle_Click(object sender, EventArgs e)
        {
            int cliArrayLength = lstv_oyunlar.Items.Count;
            KO.C = new cls_Bot[cliArrayLength];
            for (int i = 0; i < lstv_oyunlar.Items.Count; i++)
            {
                if (lstv_oyunlar.Items[i].Checked == false)
                {
                    Client.goTxt("Kullanmayacağınız oyunları lütfen kaldırın.\r\nKaldırmak istediğinize çift tıklayınız.");
                    return;
                }
                KO.C[i] = new cls_Bot(lstv_oyunlar.Items[i].Text);
                KO.C[i].getHandle();
                if (KO.C[i].Ko_Statu == true)
                {
                    KO.Count += 1;
                }
                else
                {
                    Client.goTxt(lstv_oyunlar.Items[i].Text + " Açık değildir.\r\nLütfen listeden kaldırınız.");
                    return;
                }
                
            }
            frm_2Genel g = new frm_2Genel();
            g.Show();
            Hide();
        }

        private void btn_oyunbul_Click(object sender, EventArgs e)
        {
            Client.getWinName("KnightOnLine", lstv_acikoyunlar);
        }

        private void btn_hepsiniekle_Click(object sender, EventArgs e)
        {
            if (lstv_acikoyunlar.Items.Count > 0)
            {
                foreach (ListViewItem itmLst in lstv_acikoyunlar.Items)
                {
                    if (Client.searchListView(itmLst.Text, 1, lstv_oyunlar) == false)
                        lstv_oyunlar.Items.Add((ListViewItem)itmLst.Clone());
                }
                lstv_acikoyunlar.Items.Clear();
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lstv_oyunlar.Items.Clear();
        }

        private void chk_hepsinisec_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem itmLst in lstv_oyunlar.Items)
                itmLst.Checked = chk_hepsinisec.Checked;
        }

        private void lstv_oyunlar_DoubleClick(object sender, EventArgs e)
        {
            if (lstv_oyunlar.FocusedItem.Index > -1)
                lstv_oyunlar.FocusedItem.Remove();
        }
    }
}
