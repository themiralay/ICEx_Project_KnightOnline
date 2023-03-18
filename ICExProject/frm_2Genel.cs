using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICEProject
{
    public partial class frm_2Genel : Form
    {
        private void frm_Genel_Load(object sender, EventArgs e)
        {
            cls_Client.setControls(lst_kBot, KO.Count);
            tmr_1000.Enabled = true;
            tmr_100.Enabled = true;
            tmr_50.Enabled = true;
        }
        #region Forms Code
        public frm_2Genel()
        {
            InitializeComponent();
        }
        private void m_OnTop_Click(object sender, EventArgs e)
        {
            if (m_OnTop.Checked)
                m_OnTop.Checked = false;
            else
                m_OnTop.Checked = true;
        }
        private void m_OnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = m_OnTop.Checked;
        }
        private void m_Hide_Click(object sender, EventArgs e)
        {
            N_icon.Visible = true;
            N_icon.ShowBalloonTip(0, "[CS - Project Bilgilendirme]", "Bot buraya gizlendi..", ToolTipIcon.Info);
            Visible = false;
        }
        private void N_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            N_icon.Visible = false;
            Visible = true;
        }
        private void m_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btn_Test_Click(object sender, EventArgs e)
        {
            KO.C[0].getPartyInformation();
            Console.WriteLine(KO.C[0].PartyUserX[2]);
        }

        private void tmr_50_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < KO.Count; x++)
            {
                if(lst_kBot.GetItemChecked(x))
                {
                    //Wall Hack
                    if (chk_WallHack.Checked)
                        KO.C[x].CharWall(false);
                    else
                        KO.C[x].CharWall(true);

                    //Minor
                    if (chk_Minor.Checked)
                        KO.C[x].useMinor(KO.C[x].CharID());

                    //Oto Ts
                    if (chk_OtoTs.Checked)
                        KO.C[x].useTs(cmb_OtoTs.SelectedIndex);

                    //Attack Buff Bug
                    if (chk_AtakBuff.Checked)
                        KO.C[x].useAttackBuffBug();

                    //Atak Sc Bug
                    if (chk_AtakSc.Checked)
                        KO.C[x].useAttackScBug();

                    //Drop Sc Bug
                    if (chk_DropSc.Checked)
                        KO.C[x].useDropScBug();

                    //Weapon Sc
                    if (chk_WeaponSc.Checked)
                        KO.C[x].useWeaponSc();

                    //Armor Sc
                    if (chk_ArmorSc.Checked)
                        KO.C[x].useArmorSc();

                    //F3 Town
                    if (chk_TownF3.Checked && cls_Api.GetAsyncKeyState(114) < 0)
                        KO.C[x].useTown();

                    //F4 Respawn
                    if (chk_intiharF4.Checked && cls_Api.GetAsyncKeyState(115) < 0)
                        KO.C[x].useRespawn();

                    //F5 Gate
                    if (chk_GateF5.Checked && cls_Api.GetAsyncKeyState(116) < 0)
                        KO.C[x].useGate();

                    //Magic Hammer
                    if (chk_MagicHammer.Checked)
                        KO.C[x].useMagicHammer();
                }
            }
        }

        private void chk_kBot_CheckedChanged(object sender, EventArgs e)
        {
            cls_Client.setCheckedList(chk_kBot, lst_kBot);
        }
          
        private void tmr_100_Tick(object sender, EventArgs e)
        { 
            for (int x = 0; x < KO.Count; x++)
            {
                if(lst_kBot.GetItemChecked(x))
                {
                    if(rb_otoPOT.Checked)
                    {
                        if(chk_HpPot.Checked)
                            KO.C[x].AutoPotionHP();
                        if (chk_MpPot.Checked)
                            KO.C[x].AutoPotionMP();
                    }else if(rb_sinirPOT.Checked)
                    {
                        if (chk_HpPot.Checked)
                            KO.C[x].AutoPotionHP(Convert.ToInt32(txt_HpPot.Text));
                        if (chk_MpPot.Checked)
                            KO.C[x].AutoPotionMP(Convert.ToInt32(txt_MpPot.Text));
                    }
                }
            }
        }

        private void tmr_1000_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < KO.Count; x++)
            {
                if (lst_kBot.GetItemChecked(x))
                {
                    //Follow Function
                    if(chk_TakipEt.Checked)
                    {
                        switch (cmb_TakipEt.SelectedIndex)
                        {
                            case 2:// Party Leader
                                if (KO.C[x].getPartyCount() > 1)
                                {
                                    KO.C[x].getPartyInformation();
                                    if (KO.C[x].PartyUserDistance[1] > 0)
                                        KO.C[x].CharTP(KO.C[x].PartyUserX[1], KO.C[x].PartyUserY[1]);
                                }
                                break;
                            case 1:// Selected Target
                                if (KO.C[0].getTargetDistance() > 0)
                                    KO.C[x].CharTP(KO.C[0].getTargetX(KO.C[0].getTargetID()), KO.C[0].getTargetY(KO.C[0].getTargetID()));
                                break;
                            default://Client 1
                                if (KO.C[x].getDistance(KO.C[0].CharX(), KO.C[0].CharY()) > 0)
                                    KO.C[x].CharTP(KO.C[0].CharX(), KO.C[0].CharY());
                                break;
                        }
                    }//Follow End
                }
            }
  
        }
        private void frm_2Genel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}
