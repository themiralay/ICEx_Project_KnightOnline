using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ICEProject
{
    public class cls_Bot : cls_Api
    {
        //==== Pointer ====
        public const int KO_PTR_CHR = 0xDF87E4;
        public const int KO_PTR_DLG = 0xDE861C;
        public const int KO_PTR_PKT = 0xDE85E8;
        public const int KO_SND_FNC = 0x48C370;
        public const int KO_FMBS = 0x4EB690;
        public const int KO_FPBS = 0x4EC600;
        public const int KO_FNC_ISEN = 0x558260;
        public const int KO_CHAR_SERV = 0xC397EC;
        public const int KO_OTO_LOGIN_PTR = 0xDE85F8;
        public const int KO_OTO_LOGIN_01 = 0x4D56D0;
        public const int KO_OTO_LOGIN_02 = 0x4CEBA0;
        public const int KO_OTO_LOGIN_03 = 0x4CE660;
        public const int KO_OTO_LOGIN_04 = 0x4D2FD0;
        public const int KO_OTO_BTN_PTR = 0xDE8618;
        public const int KO_BTN_LEFT = 0x4BE5E0;
        public const int KO_BTN_RIGHT = 0x4BE880;
        public const int KO_BTN_LOGIN = 0x4BAE10;
        public const int KO_FLDB = 0xDF87E0;
        public const int KO_FNCZ = 0x51B7C0;
        public const int KO_FNCB = 0x51B930;
        public const int KO_ITOB = 0xDF8618;
        public const int KO_RECV_FNC = 0x53B290;
        public const int KO_RECV_PTR = 0xB48038;
        //==== Offsetler ====
        public const int KO_OFF_CLASS = 0x6B0;
        public const int KO_OFF_NT = 0x6A8;
        public const int KO_OFF_MOVE = 0xF90;
        public const int KO_OFF_MOVEType = 0x3F0;
        public const int KO_OFF_GoX = 0xF9C;
        public const int KO_OFF_GoZ = 0xFA0;
        public const int KO_OFF_GoY = 0xFA4;
        public const int KO_OFF_X = 0xD8;
        public const int KO_OFF_Z = 0xDC;
        public const int KO_OFF_Y = 0xE0;
        public const int KO_OFF_ID = 0x680;
        public const int KO_OFF_WH = 0x6C0;
        public const int KO_OFF_MCOR = 0x420;

        public const int KO_OFF_PtBase = 0x1E8;
        public const int KO_OFF_PtCount = 0x300;
        public const int KO_OFF_Pt = 0x2FC;

        public const int KO_OFF_MAXEXP = 0xB70;
        public const int KO_OFF_EXP = 0xB78;
        public const int KO_OFF_MOB = 0x644;
        public const int KO_OFF_ZONE = 0xC00;
        public const int KO_OFF_NAMELEN = 0x698;
        public const int KO_OFF_NAME = 0x688;
        public const int KO_OFF_GOLD = 0xB6C;
        public const int KO_OFF_MAXMP = 0xB5C;
        public const int KO_OFF_MP = 0xB60;
        public const int KO_OFF_MAXHP = 0x6B8;
        public const int KO_OFF_HP = 0x6BC;
        public const int KO_OFF_LEVEL = 0x6B4;
        public const int KO_OFF_POINTStat = 0x6B0;
        public const int KO_OFF_StatSTR = 0xB94;
        public const int KO_OFF_StatHP = 0xB9C;
        public const int KO_OFF_StatDEX = 0xBA4;
        public const int KO_OFF_StatINT = 0xBAC;
        public const int KO_OFF_StatMP = 0xBB6;
        public const int KO_OFF_SBARBase = 0x1EC;
        public const int KO_OFF_BSkPoint = 0x16C;
        public const int KO_OFF_SPoint1 = 0x180;
        public const int KO_OFF_SPoint2 = 0x184;
        public const int KO_OFF_SPoint3 = 0x188;
        public const int KO_OFF_SPoint4 = 0x18C;
        //==== Fonksiyon Offsetleri ====
        public const int KO_OFF_ITEMB = 0x1B8;
        public const int KO_OFF_ITEMS = 0x20C;
        public const int KO_OFF_BANKB = 0x208;
        public const int KO_OFF_BANKS = 0x128;
        public const int KO_OFF_BANKCONT = 0xFC;
        public const int KO_OFF_SKILLBASE = 0x1D0;
        public const int KO_OFF_SKILLID = 0x12C;
        //==== İtem Silme ====
        public const int KO_ITEMDESCALL = 0x5D2600;
        public const int KO_ITEMDES = 0xDEAC04;
        public const int KO_ITEMDES2 = 0xDEAB30;
        public const int KO_FAKE_ITEM = 0x567980;
        public const int KO_SWIFT_PTR = 0xB41200; //Usko
        //public const int KO_SWIFT_PTR = 0xB49328; //Steam

        public const int KO_SH_HOOK = 0x4DFD4B;
        public const int KO_SH_VALUE = 0xB47220;
        public const int KO_SPD_HOOK = KO_SH_HOOK + 0x9D;

        //Hook Define
        public const int WIZ_CHAT = 0x10;
        public const int WIZ_GETLOOT = 0x23;
        public const int WIZ_LOOTOPEN = 0x24;

        //Game Define
        public const int KO_OFF_ITEMROW = 0;
        public const int KO_OFF_INVROW = 15 + KO_OFF_ITEMROW;
        public const int KO_OFF_INVCOUNT = 42 + KO_OFF_ITEMROW;
        public const int KO_OFF_SWIFT = 0x7C6;
        public const int KO_OFF_MCORX = 0x7C;
        public const int KO_OFF_MCORY = 0x84;
        public const int KO_OFF_MCORZ = 0x80;

        public string Ko_Title { get; set; }
        public int Ko_Pid;
        public bool Ko_Statu;
        public IntPtr Ko_Handle;
        public IntPtr Ko_Hwnd;
        public IntPtr KoSendAdress;
        public IntPtr KoExecuteAdress;
        public IntPtr Ko_RecvHandle;
        public IntPtr Ko_MsHandle;

        int[] rowPacket = new int[9999];
        int[] tickPacket = new int[9999];
        public int[] ItemIntID = new int[43];
        public int[] BankItemID = new int[191];
        public string[] PartyUserID = new string[8];
        public int[] PartyUserTargetID = new int[8];
        public int[] PartyUserHP = new int[8];
        public int[] PartyUserMaxHP = new int[8];
        public int[] PartyUserHPDist = new int[8];
        public int[] PartyUserCure = new int[8];
        public int[] PartyUserName = new int[8];
        public int[] PartyUserDisease = new int[8];
        public int[] PartyUserX = new int[8];
        public int[] PartyUserY = new int[8];
        public int[] PartyUserZ = new int[8];
        public int[] PartyUserDistance = new int[8];
        public int[] PartyBuffHP = new int[8];
        public int[] PartyRestHP = new int[8];
        public int[] PartyUserRestHPTime = new int[8];
        public int[] WarSkill = new int[25];
        public int[] RogueSkill = new int[50];
        public int[] MageSkill = new int[66];
        public int[] PriestSkill = new int[32];
        public string zTargetName;
        public int zTargetID;
        public int zTargetX;
        public int zTargetY;
        public int zTargetZ;
        public int zTargetDistance;
        public frm_2Genel frm = null;
        public cls_Bot(string cliTitle)
        {
            Ko_Title = cliTitle;
            getHandle();
        }
        //#########################################################################################
        #region [getHandle Function]
        public void getHandle()
        {
            Ko_Hwnd = FindWindow(null, Ko_Title);
            GetWindowThreadProcessId(Ko_Hwnd, out Ko_Pid);
            Ko_Handle = OpenProcess(ProcessAccessFlags.All, false, Ko_Pid);
            if (Ko_Handle == IntPtr.Zero)
            {
                Ko_Statu = false;
                return;
            }
            else
            {
                Ko_Statu = true;
                for (int i = 0; i < 5; i++)
                {
                    KoSendAdress = VirtualAllocEx(Ko_Handle, IntPtr.Zero, 1024, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);
                    KoExecuteAdress = VirtualAllocEx(Ko_Handle, IntPtr.Zero, 1024, AllocationType.Commit, MemoryProtection.ReadWrite);
                    Ko_RecvHandle = VirtualAllocEx(Ko_Handle, IntPtr.Zero, 1024, AllocationType.Commit, MemoryProtection.ReadWrite);
                    Ko_MsHandle = VirtualAllocEx(Ko_Handle, IntPtr.Zero, 1024, AllocationType.Commit, MemoryProtection.ReadWrite);
                }
            }
        }
        #endregion
        //#########################################################################################
        #region [ToFunction]
        public string getByteToString(byte[] inputBytes)
        {
            string convertedString = "";
            for (int i = 0; i < inputBytes.Length; i++)
                convertedString += Convert.ToChar(inputBytes[i]).ToString();
            return convertedString;
        }
        public string getHexToString(string HexValue)
        {
            string result = "", sHexVal = "";
            for (int i = 0; i < HexValue.Length; i+=2)
            {
                sHexVal = HexValue.Substring(i, 2);
                result += Convert.ToChar(Convert.ToUInt32(sHexVal, 16)).ToString();
            }
            return result;
        }
        public static string getToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
        }
        public static string getFromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        }
        public byte[] getStringToByteArray(string ArrayString)
        {
            byte[] tmpbyte = new byte[ArrayString.Length / 2 + 1];
            int sayac = 0;
            for (int i = 0; i < ArrayString.Length; i = i + 2)
            {
                tmpbyte[sayac] = byte.Parse(ArrayString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                sayac++;
            }
            return tmpbyte;
        }
        public string Adword(int _iValue, int _iBytes)
        {
            string sBigEndian = String.Format("{0:x" + (2 * _iBytes).ToString() + "}", _iValue);
            string sLittleEndian = "";
            for (int i = _iBytes - 1; i >= 0; i--)
            {
                sLittleEndian += sBigEndian.Substring(i * 2, 2);
            }

            return sLittleEndian.ToUpper();
        }
        public int DecDword(string hexValue)
        {
            string decString = "";
            for (int i = (hexValue.Length / 2) - 1; i >= 0; i--)
            {
                decString += hexValue.Substring(i * 2, 2);
            }
            return Convert.ToInt32(decString, 16);
        }
        #endregion
        //#########################################################################################
        #region Other Function
        public int getDistance(int Cor1,int Cor2,int GoCor1,int GoCor2)
        {
            return (int)Math.Sqrt(Math.Pow(GoCor1 - Cor1, 2) + Math.Pow(GoCor2 - Cor2, 2));
        }
        #endregion
        //#########################################################################################
        #region [readToHandle Function]
        public int getLong(int Address)
        {
            UInt32 ret;
            try
            {
                ReadProcessMemory(Ko_Handle, (IntPtr)Address, out ret, (UInt32)4, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (int)ret;
        }
        public float getFloat(int Address)
        {
            float ret;
            try
            {
                ReadProcessMemory(Ko_Handle, (IntPtr)Address, out ret, (UInt32)4, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (float)ret;
        }
        public int getByte(int Address)
        {
            UInt32 ret;
            try
            {
                ReadProcessMemory(Ko_Handle, (IntPtr)Address, out ret, (UInt32)1, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (int)ret;
        }
        public int getShort(int Address)
        {
            UInt32 ret;
            try
            {
                ReadProcessMemory(Ko_Handle, (IntPtr)Address, out ret, (UInt32)2, new IntPtr());
            }
            catch (Exception)
            {
                ret = 0;
            }
            return (int)ret;
        }
        public byte[] getByteArray(int dwAddress, int bufferLen)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[bufferLen];
            ReadProcessMemory(Ko_Handle, new IntPtr(dwAddress), buffer, (UInt32)bufferLen, out ptrBytesRead);
            return buffer;
        }
        #endregion
        //#########################################################################################
        #region [writeToHandle Function]
        public int setByte(int Address, int Value)
        {
            int ret;
            try
            {
                WriteProcessMemory(Ko_Handle, (IntPtr)Address, BitConverter.GetBytes(Value), 1, out ret);
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
        public int setByteArray(IntPtr Address, byte[] bValue,int bLength)
        {
            int ret;
            try
            {
                WriteProcessMemory(Ko_Handle, Address, bValue, bLength / 2 + 1, out ret);
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
        public int setLong(int Address, int Value)
        {
            int ret;
            try
            {
                WriteProcessMemory(Ko_Handle, (IntPtr)Address, BitConverter.GetBytes(Value), 4, out ret);
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
        public int setFloat(int Address, float Value)
        {
            int ret;
            try
            {
                WriteProcessMemory(Ko_Handle, (IntPtr)Address, BitConverter.GetBytes(Value), 4, out ret);
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
        #endregion
        //#########################################################################################
        #region sendHandle Function
        public void setPack(string Packet)
        {
            if (Packet.Length % 2 != 0)
                return;
            byte[] bPacket = getStringToByteArray(Packet);
            setByteArray(KoSendAdress, bPacket, Packet.Length);
            string pCode = "608B0D" + Adword(KO_PTR_PKT, 4) + "68" + Adword(Packet.Length / 2, 4) + "68" + Adword((int)KoSendAdress, 4) + "BF" + Adword(KO_SND_FNC, 4) + "FFD761C3";
            exCodeHandle(pCode);
        }
        public void exCodeHandle(string exCode)
        {
            uint ThreadId;
            byte[] exbCode = getStringToByteArray(exCode);
            setByteArray(KoExecuteAdress, exbCode,exCode.Length);
            IntPtr hThread = CreateRemoteThread(Ko_Handle, IntPtr.Zero, IntPtr.Zero, KoExecuteAdress, IntPtr.Zero, IntPtr.Zero, out ThreadId);
            WaitForSingleObject(hThread, 0xFFFF);
            CloseHandle(hThread);
        }
        public void setPSec(string Packet, int secPacket, int IDPacket)
        {
            if (rowPacket[IDPacket] <= 0)
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                setPack(Packet);
                rowPacket[IDPacket] = 1;
            }
            if((GetTickCount() - tickPacket[IDPacket])<=secPacket)
            {
                return;
            }
            else
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                rowPacket[IDPacket] = 0;
            }
        }

        public void setPriestSec(string Packet, int secPacket, int IDPacket)
        {
            if (rowPacket[IDPacket] <= 0)
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                setPack("3101" + Packet + "00000000000000000F00");
                setPack("3103" + Packet + "000000000000");
                rowPacket[IDPacket] = 1;
            }
            if ((GetTickCount() - tickPacket[IDPacket]) <= secPacket)
            {
                return;
            }
            else
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                rowPacket[IDPacket] = 0;
            }
        }
        public void setPacketPot(string PotionID, int IDPacket,string charID)
        {
            if (rowPacket[IDPacket] <= 0)
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                setPack("3103" + PotionID + "00" + charID + charID + "00000000000000000000000000000000");
                rowPacket[IDPacket] = 1;
            }
            if ((GetTickCount() - tickPacket[IDPacket]) < 2000)
            {
                return;
            }
            else
            {
                tickPacket[IDPacket] = (int)GetTickCount();
                rowPacket[IDPacket] = 0;
            }
        }
        #endregion
        //#########################################################################################
        #region HandleItem Function
        public int getItemID(int InvRow = 16)
        {
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x68)) + getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x6C));
        }
        public int getItemEx(int InvRow = 16)
        {
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x6C));
        }
        public int getItemInv(int InvRow = 0)
        {
            InvRow += KO_OFF_INVROW;
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x68)) + getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x6C));
        }
        public int getCountItem(int InvRow = 16)
        {
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x70));
        }
        public int getDurabItem(int InvRow = 16)
        {
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + (KO_OFF_ITEMS + (4 * InvRow))) + 0x74));
        }
        public int getCountByID(int InvItemID)
        {
            for (int i = 0; i <= 27; i++)
            {
                if (getItemInv(i) == InvItemID)
                {
                    return getCountItem(i + KO_OFF_INVROW);
                }
            }
            return -1;
        }

        public int getInvSlot(int InvItemID)
        {
            for (int i = KO_OFF_INVROW; i <= 43; i++)
            {
                if (getItemID(i) == InvItemID)
                {
                    return (i - KO_OFF_INVROW);
                }
            }
            return -1;
        }
        public int getAllNullSlot()
        {
            int result = 0;
            for (int i = KO_OFF_INVROW; i <= 43; i++)
            {
                if (getItemInv(i) == 0)
                {
                    result += 1;
                }
            }
            return result;
        }
        public int getFirstNullSlot()
        {
            for (int i = KO_OFF_INVROW; i <= 43; i++)
            {
                if (getItemInv(i) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public int getBankItemID(int BnkRow)
        {
            return getLong(getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_BANKB) + KO_OFF_BANKS + (4 * BnkRow)) + 0x68));
        }
        public void getReadBank()
        {
            for (int i = 0; i < BankItemID.Length; i++)
            {
                BankItemID[i] = getBankItemID(i);
            }
        }
        public int getBankItemSlot(int BnkItemID)
        {
            for (int i = 0; i < BankItemID.Length; i++)
            {
                if(getBankItemID(i) == BnkItemID)
                {
                    return i;
                }
            }
            return -1;
        }
        public int getBnkFirstNullSlot()
        {
            for (int i = 0; i < BankItemID.Length; i++)
            {
                if (getBankItemID(i) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool getControlBank()
        {
            return Convert.ToBoolean(getByte(getLong(getLong(KO_PTR_DLG) + KO_OFF_BANKB) + KO_OFF_BANKCONT));
        }
        public void setRemoveItem(int InvItemID)
        {
            if(getInvSlot(InvItemID) > -1)
            {
                int ItemBase, ItemIDBase;
                ItemBase = getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB);
                ItemIDBase = getInvSlot(InvItemID);
                setByte(KO_ITEMDES, 1);
                setLong(KO_ITEMDES + 0x4, ItemIDBase);
                setLong(KO_ITEMDES + 0x8, getItemBase(ItemIDBase + KO_OFF_INVROW));
                setByte(KO_ITEMDES2, 1);
                setLong(KO_ITEMDES2 + 0x8, getItemBase(ItemIDBase + KO_OFF_INVROW));
                setByte(KO_ITEMDES2 + 0xC, 1);
                setLong(KO_ITEMDES2 + 0x10, ItemIDBase);
                setByte(KO_ITEMDES2 + 0x14, 1);
                exCodeHandle("60B9" + Adword(ItemBase, 4) + "BF" + Adword(KO_ITEMDESCALL, 4) + "FFD761C3");
                setPack("6A02");
            }
        }
        public int getItemBase(int InvSlot)
        {
            return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_ITEMB) + KO_OFF_ITEMS + (4 * InvSlot));
        }
        #endregion
        //#########################################################################################
        #region HandleSkill Function
        public int getUsedSkill(int SkillNumber)
        {
            int SkillBase;
            SkillBase = getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SKILLBASE) + 0x4) + KO_OFF_SKILLID);
            for (int i = 1; i <= SkillNumber ; i++)
            {
                SkillBase = getLong(SkillBase);
            }
            SkillBase = getLong(SkillBase + 0x8);
            if(SkillBase>0)
            {
                SkillBase = getLong(SkillBase);
                return SkillBase;
            }
            return 0;
        }
        public int getSkillCount()
        {
            return getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SKILLBASE) + 0x4) + KO_OFF_SKILLID + 0x4);
        }
        public bool getSkillControl(string SkillNumber)
        {

            for (int i = 1; i <= getSkillCount(); i++)
            {
                string strSkill = getUsedSkill(i).ToString();
                if (strSkill.Substring(strSkill.Length - 3) == SkillNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public bool getTSControl(string SkillNumber)
        {

            for (int i = 1; i <= getSkillCount(); i++)
            {
                string strSkill = getUsedSkill(i).ToString();
                if (strSkill.Substring(0, 3) == SkillNumber)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
        //#########################################################################################
        #region Character Information
        public int CharStat(int rowStat)
        {
            switch (rowStat)
            {
                case 0:// Empty Stat
                    return getLong(getLong(KO_PTR_CHR) + 0xB54);
                case 1:// STR
                    return getLong(getLong(KO_PTR_CHR) + KO_OFF_StatSTR);
                case 2:// HP
                    return getLong(getLong(KO_PTR_CHR) + KO_OFF_StatHP);
                case 3:// DEX
                    return getLong(getLong(KO_PTR_CHR) + KO_OFF_StatDEX);
                case 4:// INT
                    return getLong(getLong(KO_PTR_CHR) + KO_OFF_StatINT);
                default:// MP
                    return getLong(getLong(KO_PTR_CHR) + KO_OFF_StatMP);
            }
        }
        public int CharSkill(int rowSkill)
        {
            switch (rowSkill)
            {
                case 0:// Empty Skill
                    return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SBARBase) + KO_OFF_BSkPoint);
                case 1:// Skill Row 1
                    return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SBARBase) + KO_OFF_SPoint1);
                case 2:// Skill Row 2
                    return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SBARBase) + KO_OFF_SPoint2);
                case 3:// Skill Row 3
                    return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SBARBase) + KO_OFF_SPoint3);
                default:// Skill Row 4
                    return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_SBARBase) + KO_OFF_SPoint4);
            }
        }
        public string CharName()
        {
            int CharNickLen = getLong(getLong(KO_PTR_CHR) + KO_OFF_NAMELEN);
            int CharNick = getLong(KO_PTR_CHR) + KO_OFF_NAME;
            if (CharNickLen > 15)
                return getByteToString(getByteArray(getLong(CharNick), CharNickLen));
            return getByteToString(getByteArray(CharNick, CharNickLen));
        }
        public string CharID()
        {
            return Adword((getLong(getLong(KO_PTR_CHR) + KO_OFF_ID)), 2);
        }
        public int CharIntID()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_ID);
        }
        public int CharMP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_MP);
        }
        public int CharMaxMP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_MAXMP);
        }
        public int CharHP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_HP);
        }
        public int CharMaxHP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_MAXHP);
        }
        public int CharEXP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_EXP);
        }
        public int CharMaxEXP()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_MAXEXP);
        }
        public int CharLevel()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_LEVEL);
        }
        public int CharClass()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_CLASS);
        }
        public int CharX()
        {
            return (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_X);
        }
        public int CharY()
        {
            return (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Y);
        }
        public int CharZ()
        {
            return (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Z);
        }
        public int CharMouseX()
        {
            return (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_GoX);
        }
        public int CharMouseY()
        {
            return (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_GoY);
        }
        public string CharClassName()
        {
            switch (CharClass())
            {
                case 101:case 105:case 106:case 205:case 206:
                    return "Warrior";
                case 102:case 107:case 108:case 207:case 208:
                    return "Rogue";
                case 103:case 109:case 110:case 209:case 210:
                    return "Mage";
                case 104:case 111:case 112:case 211:case 212:
                    return "Priest";
                default:
                    return "Kurian";
            }
        }
        public string CharNationName()
        {
            switch (getLong(getLong(KO_PTR_CHR) + KO_OFF_NT))
            {
                case 1:
                    return "Karus";
                case 2:
                    return "Human";
                default:
                    return "Nothing";
            }
        }
        public string CharZone()
        {
            switch (getLong(getLong(KO_PTR_CHR) + KO_OFF_ZONE))
            {
                case 1: case 5: return "Lüferson";
                case 2: return "El Morad";
                case 11: return "Karus - Eslant";
                case 12: return "Human - Eslant";
                case 21: case 22: case 23: return "Moradon";
                case 30: return "Delos";
                case 32: return "Abys";
                case 34: return "Felankor's Lair";
                case 48: return "Arena";
                case 71: return "Ronark Land";
                case 72: return "Ardream";
                case 73: return "Ronark Land Base";
                case 82: return "Adonis";
                default: return "Nothing";
            }
        }
        public bool CharRogueJob()
        {
            if(getItemID(8) > 0 && getItemID(10) > 0 && CharSkill(1) <= CharSkill(2))
            {
                return true;
            }
            return false;
        }
        public int CharUndyHp(int CharHP)
        {
            return (CharHP * 60 / 100);
        }
        public int LastMp()
        {
            return CharMaxMP() - CharMP();
        }
        public int LastHp()
        {
            return CharMaxHP() - CharHP();
        }
        public int getDistance(int goCor1,int goCor2)
        {
            return getDistance(CharX(), CharY(), goCor1, goCor2);
        }
        #endregion
        //#########################################################################################
        #region Client Priest Check
        public bool CharStrStatu()
        {
            if (getSkillControl("004"))
                return true;
            return false;
        }
        public bool CharResisStatu()
        {
            if (getSkillControl("609") || getSkillControl("627") || getSkillControl("636") || getSkillControl("645"))
                return true;
            return false;
        }
        public bool CharAccStatu()
        {
            if (getSkillControl("603") || getSkillControl("612") || getSkillControl("621") || getSkillControl("630") || getSkillControl("639") || getSkillControl("651") || getSkillControl("660") || getSkillControl("674") || getSkillControl("676"))
                return true;
            return false;
        }
        public bool CharBuffStatu()
        {
            if (getSkillControl("606") || getSkillControl("615") || getSkillControl("624") || getSkillControl("633") || getSkillControl("643") || getSkillControl("654") || getSkillControl("655") || getSkillControl("656") || getSkillControl("657") || getSkillControl("670") || getSkillControl("672") || getSkillControl("678"))
                return true;
            return false;
        }
        public bool CharRestoreStatu()
        {
            if (getSkillControl("503") || getSkillControl("512") || getSkillControl("521") || getSkillControl("530") || getSkillControl("539") || getSkillControl("548") || getSkillControl("570") || getSkillControl("575") || getSkillControl("580"))
                return true;
            return false;
        }

        public bool CharCureStatu()
        {
            if (getSkillControl("703") || getSkillControl("715") || getSkillControl("724") || getSkillControl("745") || getSkillControl("754") || getSkillControl("760"))
                return true;
            return false;
        }
        public bool CharDiseStatu()
        {
            if (getSkillControl("580") || getSkillControl("680") || getSkillControl("780"))
                return true;
            return false;
        }
        #endregion
        //#########################################################################################
        #region Target Base Function
        public int getTargetBase(int TargetID)
        {
            int Ebp, Esi, Eax, Fend, Base_Adr, GetTime, GetTickTime,MobHex;
            MobHex = TargetID < 9999 ? MobHex = 0x40 : MobHex = 0x34;
            Ebp = getLong(getLong(KO_FLDB) + MobHex);
            Fend = getLong(getLong((Ebp + 4)) + 4);
            Esi = getLong(Ebp);
            GetTickTime = (int)GetTickCount();
            GetTime = GetTickTime;
            while (Esi != Ebp)
            {
                if (GetTickTime - GetTime > 50) { break; }
                Base_Adr = getLong(Esi + 0x10);
                if (Base_Adr == 0) { break; }
                Eax = getLong(Esi + 8);
                if (getLong(Esi + 8) != Fend)
                {
                    while (getLong(Eax) != Fend)
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Eax = getLong(Eax);
                    }
                    Esi = Eax;
                }
                else
                {
                    Eax = getLong(Esi + 4);
                    while (Esi == getLong(Eax + 8))
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Esi = Eax;
                        Eax = getLong(Eax + 4);
                    }
                    if (getLong(Esi + 8) != Eax)
                    {
                        Esi = Eax;
                    }
                }
                if (TargetID == getLong(Base_Adr + KO_OFF_ID))
                { 
                    return Base_Adr;
                }
            }
            return 0;
        }
        #endregion
        //#########################################################################################
        #region Target Function
        public int getTargetStatu(int Target_Base)
        {
            return getByte(Target_Base + 0x2A0);
        }
        public int getTargetID()
        {
            return getLong(getLong(KO_PTR_CHR) + KO_OFF_MOB);
        }
        public string getTargetHexID()
        {
            return Adword(getTargetID(), 2);
        }
        public int getTargetX(int TargetID)
        {
            return (int)getFloat(getTargetBase(TargetID) + KO_OFF_X);
        }
        public int getTargetY(int TargetID)
        {
            return (int)getFloat(getTargetBase(TargetID) + KO_OFF_Y);
        }
        public int getTargetZ(int TargetID)
        {
            return (int)getFloat(getTargetBase(TargetID) + KO_OFF_Z);
        }
        public int getTargetHP(int TargetID)
        {
            return getLong(getTargetBase(TargetID) + KO_OFF_HP);
        }
        public int getTargetMaxHP(int TargetID)
        {
            return getLong(getTargetBase(TargetID) + KO_OFF_MAXHP);
        }
        public int getTargetNT(int TargetID)
        {
            return getLong(getTargetBase(TargetID) + KO_OFF_NT);
        }
        public string getTargetName(int TargetIDBase, bool getBase = false)
        {
            int TargetNickBase = getBase == false ? getTargetBase(TargetIDBase) : TargetIDBase;
            int TargetNickLen = getLong(TargetNickBase + KO_OFF_NAMELEN);
            int TargetNick = TargetNickBase + KO_OFF_NAME;
            if (TargetNickLen > 15)
                return getByteToString(getByteArray(getLong(TargetNick), TargetNickLen));
            return getByteToString(getByteArray(TargetNick, TargetNickLen));
        }
        public int getTargetX()
        {
            return (int)getFloat(getLong(getLong(KO_PTR_DLG) + KO_OFF_MCOR) + KO_OFF_MCORX);
        }
        public int getTargetY()
        {
            return (int)getFloat(getLong(getLong(KO_PTR_DLG) + KO_OFF_MCOR) + KO_OFF_MCORY);
        }
        public int getTargetZ()
        {
            return (int)getFloat(getLong(getLong(KO_PTR_DLG) + KO_OFF_MCOR) + KO_OFF_MCORZ);
        }
        public int getTargetDistance()
        {
            if (getTargetID() <= 0)
                return 255;
            return getDistance(CharX(), CharY(), getTargetX(), getTargetY());
        }
        #endregion
        //#########################################################################################
        #region Character Method
        public void CharLocked(bool Locked)
        {
            if(Locked == true)
            {
                setLong(getLong(KO_PTR_CHR) + KO_OFF_SWIFT, 0);
            }
            else
            {
                setLong(getLong(KO_PTR_CHR) + KO_OFF_SWIFT, 16256);
            }
        }
        public void CharWall(bool Wall)
        {
            setLong(getLong(KO_PTR_CHR) + KO_OFF_WH, Convert.ToInt32(Wall));
        }
        public void CharGo(int goX, int goY)
        {
            int JumpX = 6, JumpY = 6;
            int DistX, DistY;
            DistX = goX - CharX();
            DistY = goY - CharY();
            if (DistX == 0 & DistY == 0 || goX == 0 || goY == 0)
                return;
            for (int i = 0; i <= 6; i++)
            {
                if (DistX == -1 * i || DistX == i)
                {
                    JumpX = 1;
                }
                else if (DistY == -1 * i || DistY == i)
                    JumpY = 1;
            }
            if (DistX < 0)
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_X, CharX() - JumpX);
            else if (DistX > 0)
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_X, CharX() + JumpX);

            if (DistY < 0)
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_Y, CharY() - JumpY);
            else if (DistY > 0)
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_Y, CharY() + JumpY);

            setPack("06" + Adword(CharX() * 10, 2) + Adword(CharY() * 10, 2) + Adword(CharZ() * 10, 2) + "2D0000" + Adword(CharX() * 10, 2) + Adword(CharY() * 10, 2) + Adword(CharZ() * 10, 2));
        }
        public void CharTP(int goX, int goY)
        {
            int Jump = 1;
            double X, Y, isrtx, bykx, kckx, isrty, byky, kcky, A, b, D, e;
            int uzak, tx, ty, CoorX, CoorY;
            tx = (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_X);
            ty = (int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Y);
            X = Math.Abs(goX - tx);
            Y = Math.Abs(goY - ty);
            if (tx > goX) { isrtx = -1; bykx = tx; kckx = goX; } else { isrtx = 1; bykx = goX; kckx = tx; }
            if (ty > goY) { isrty = -1; byky = ty; kcky = goY; } else { isrty = 1; byky = goY; kcky = ty; }
            uzak = (int)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            if (uzak > 100 || goX <= 0 || goY <= 0)
                return;
            for (int i = Jump; i <= uzak; i += Jump)
            {
                A = Math.Pow(i, 2) * Math.Pow(X, 2);
                b = Math.Pow(X, 2) + Math.Pow(Y, 2);
                D = Math.Sqrt(A / b);
                e = Math.Sqrt(Math.Pow(i, 2) - Math.Pow(D, 2));
                CoorX = Convert.ToInt32(tx + isrtx * D);
                CoorY = Convert.ToInt32(ty + isrty * e);
                if (kckx <= CoorX && CoorX <= bykx && kcky <= CoorY && CoorY <= byky)
                {
                    setFloat(getLong(KO_PTR_CHR) + KO_OFF_X, CoorX);
                    setFloat(getLong(KO_PTR_CHR) + KO_OFF_Y, CoorY);
                    Console.WriteLine(CoorX + " - " + CoorY);
                    setPack("06" 
                        + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_X) * 10, 4).Substring(0, 4)
                        + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Y) * 10, 4).Substring(0, 4)
                        + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Z) * 10, 4).Substring(0, 4) 
                        + "2D0000" 
                        + Adword(CharX() * 10, 2)
                        + Adword(CharY() * 10, 2)
                        + Adword(5 * 10, 2));
                }
            }
        }
        public void CharWalk(int goX, int goY)
        {
            if(CharX() != goX || CharY() != goY)
            {
                setLong(getLong(KO_PTR_CHR) + KO_OFF_MOVE, 1);
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_GoX, goX);
                setFloat(getLong(KO_PTR_CHR) + KO_OFF_GoY, goY);
                setLong(getLong(KO_PTR_CHR) + KO_OFF_MOVEType, 2);
                setPack("06"
                    + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_X) * 10, 4).Substring(0, 4)
                    + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Y) * 10, 4).Substring(0, 4)
                    + Adword((int)getFloat(getLong(KO_PTR_CHR) + KO_OFF_Z) * 10, 4).Substring(0, 4)
                    + "2D0000"
                    + Adword(CharX() * 10, 2)
                    + Adword(CharY() * 10, 2)
                    + Adword(5 * 10, 2));
            }
        }
        #endregion
        //#########################################################################################
        #region Party Function
        public int getPartyCount()
        {
            return getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_PtBase) + KO_OFF_PtCount);
        }
        public void getPartyInformation()
        {
            int ptBase = 0;
            if (getPartyCount() < 2)
                return;
            for (int i = 1; i <= getPartyCount(); i++)
            {
                PartyUserID[i] = "";
                PartyUserTargetID[i] = 0;
                PartyUserHP[i] = 0;
                PartyUserMaxHP[i] = 0;
                PartyUserHPDist[i] = 0;
                PartyUserCure[i] = 0;
                PartyUserDisease[i] = 0;
                PartyUserX[i] = 0;
                PartyUserY[i] = 0;
                PartyUserZ[i] = 0;
                PartyUserDistance[i] = 0;
            }
            for (int i = 1; i <= getPartyCount(); i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (ptBase == 0)
                        ptBase = getLong(getLong(getLong(getLong(KO_PTR_DLG) + KO_OFF_PtBase) + KO_OFF_Pt));
                    else
                        ptBase = getLong(ptBase);
                }
                PartyUserID[i] = Adword(getLong(ptBase + 0x8),2);
                PartyUserTargetID[i] = getLong(ptBase + 0x8);
                PartyUserHP[i] = getLong(ptBase + 0x14);
                PartyUserMaxHP[i] = getLong(ptBase + 0x18);
                PartyUserHPDist[i] = PartyUserMaxHP[i] - PartyUserHP[i];
                PartyUserCure[i] = getLong(ptBase + 0x25);
                PartyUserDisease[i] = getLong(ptBase + 0x26);
                PartyUserX[i] = (int)getFloat(getTargetBase(PartyUserTargetID[i]) + KO_OFF_X);
                PartyUserY[i] = (int)getFloat(getTargetBase(PartyUserTargetID[i]) + KO_OFF_Y);
                PartyUserZ[i] = (int)getFloat(getTargetBase(PartyUserTargetID[i]) + KO_OFF_Z);
                PartyUserDistance[i] = getDistance(PartyUserX[i],PartyUserY[i]);
                ptBase = 0;
            }
        }
        #endregion
        //#########################################################################################
        #region Mob Select Base
        public string getTargetClassName(int TargetClass)
        {
            switch (TargetClass)
            {
                case 101:case 105:case 106:case 205:case 206:
                    return "Warrior";
                case 102:case 107:case 108:case 207:case 208:
                    return "Rogue";
                case 103:case 109:case 110:case 209:case 210:
                    return "Mage";
                case 104:case 111:case 112:case 211:case 212:
                    return "Priest";
                default:
                    return "Kurian";
            }
        }
        public void setSelectMob(int TargetID,bool ManuelMob = false)
        {
            if (TargetID <= 0)
                return;
            setLong(getLong(KO_PTR_CHR) + KO_OFF_MOB, TargetID);
            if(ManuelMob)
            {
                zTargetName = getTargetName(TargetID);
                zTargetID = TargetID;
                zTargetX = getTargetX(TargetID);
                zTargetY = getTargetY(TargetID);
                zTargetZ = getTargetZ(TargetID);
                zTargetDistance = getDistance(zTargetX, zTargetY);
            }
        }
        public void getZTarget(string TargetStatu, string TargetControl = "Genel", ListBox lstTarget = null, bool hpControl = false)
        {
            int Ebp, Esi, Eax, Fend, Base_Adr, GetTime, GetTickTime, TargetHex, LDist, CrrDist = 0, LID = 0, LBase = 0, SelNT;
            LDist = 999;
            zTargetName = "";
            zTargetID = 0;
            zTargetX = 0;
            zTargetY = 0;
            zTargetZ = 0;
            zTargetDistance = 0;
            if (TargetControl == "Karşı")
                TargetHex = 0x40;
            else
                TargetHex = 0x34;

            if (TargetStatu == "Mob+Npc")
                SelNT = 3;
            else
                SelNT = 0;
            Ebp = getLong(getLong(KO_FLDB) + TargetHex);
            Fend = getLong(getLong((Ebp + 4)) + 4);
            Esi = getLong(Ebp);
            GetTickTime = (int)GetTickCount();
            GetTime = GetTickTime;
            while (Esi != Ebp)
            {
                if (GetTickTime - GetTime > 50) { break; }
                Base_Adr = getLong(Esi + 0x10);
                if (Base_Adr == 0) { break; }
                Eax = getLong(Esi + 8);
                if (getLong(Esi + 8) != Fend)
                {
                    while (getLong(Eax) != Fend)
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Eax = getLong(Eax);
                    }
                    Esi = Eax;
                }
                else
                {
                    Eax = getLong(Esi + 4);
                    while (Esi == getLong(Eax + 8))
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Esi = Eax;
                        Eax = getLong(Eax + 4);
                    }
                    if (getLong(Esi + 8) != Eax)
                    {
                        Esi = Eax;
                    }
                }

                if(hpControl)
                    setPack("22" + Adword(getLong(Base_Adr + KO_OFF_ID), 2));

                CrrDist = getDistance((int)getFloat(Base_Adr + KO_OFF_X), (int)getFloat(Base_Adr + KO_OFF_Y));
                switch (TargetControl)
                {
                    case "Genel":
                        if (getLong(Base_Adr + KO_OFF_NT) <= SelNT && getTargetName(Base_Adr, true) != "Dig Guard")
                        {
                            if (CrrDist < LDist && getTargetStatu(Base_Adr) != 10)
                            {
                                LID = getLong(Base_Adr + KO_OFF_ID);
                                LBase = Base_Adr;
                                LDist = CrrDist;
                            }
                        }
                        break;

                    case "List":
                        if (searchList(getTargetName(Base_Adr),lstTarget))
                        {
                            if (CrrDist < LDist && getTargetStatu(Base_Adr) != 10)
                            {
                                LID = getLong(Base_Adr + KO_OFF_ID);
                                LBase = Base_Adr;
                                LDist = CrrDist;
                            }
                        }
                        break;
                    case "Karşı":
                        if (getLong(Base_Adr + KO_OFF_NT) != getLong(getLong(KO_PTR_CHR)+KO_OFF_NT) && getLong(Base_Adr + KO_OFF_ID) <= 9999)
                        {
                            if (CrrDist < LDist && getTargetStatu(Base_Adr) != 10)
                            {
                                LID = getLong(Base_Adr + KO_OFF_ID);
                                LBase = Base_Adr;
                                LDist = CrrDist;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            zTargetID = LID;
            zTargetName = getTargetName(LBase, true);
            zTargetX = (int)getFloat(LBase + KO_OFF_X);
            zTargetY = (int)getFloat(LBase + KO_OFF_Y);
            zTargetZ = (int)getFloat(LBase + KO_OFF_Z);
            zTargetDistance = LDist;
            setSelectMob(zTargetID);
        }
        public void getTargetInfo(ListBox lstTarget = null, string TargetTips = "Mob",bool PMBool = true,string PMText = "",int PMLevel = 0, string PMJob = "")
        {
            int Ebp, Esi, Eax, Fend, Base_Adr, GetTime, GetTickTime, TargetHex, plLevel;
            string plClass, plName, plID;
            if (TargetTips == "Mob")
                TargetHex = 0x34;
            else
                TargetHex = 0x40;

            Ebp = getLong(getLong(KO_FLDB) + TargetHex);
            Fend = getLong(getLong((Ebp + 4)) + 4);
            Esi = getLong(Ebp);
            GetTickTime = (int)GetTickCount();
            GetTime = GetTickTime;
            while (Esi != Ebp)
            {
                if (GetTickTime - GetTime > 50) { break; }
                Base_Adr = getLong(Esi + 0x10);
                if (Base_Adr == 0) { break; }
                Eax = getLong(Esi + 8);
                if (getLong(Esi + 8) != Fend)
                {
                    while (getLong(Eax) != Fend)
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Eax = getLong(Eax);
                    }
                    Esi = Eax;
                }
                else
                {
                    Eax = getLong(Esi + 4);
                    while (Esi == getLong(Eax + 8))
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Esi = Eax;
                        Eax = getLong(Eax + 4);
                    }
                    if (getLong(Esi + 8) != Eax)
                    {
                        Esi = Eax;
                    }
                }
                plClass = getTargetClassName(getLong(Base_Adr + KO_OFF_CLASS));
                plLevel = getLong(Base_Adr + KO_OFF_LEVEL);
                plID = Adword(getLong(Base_Adr + KO_OFF_ID), 2);
                plName = getTargetName(Base_Adr, true);
                switch (TargetTips)
                {
                    case "PM":
                        //if(PMBool == true && plLevel >= PMLevel && plClass == plClass)
                            
                        //else
                        break;
                    case "Karşı":
                        if (getLong(Base_Adr + KO_OFF_NT) != getLong(getLong(KO_PTR_CHR) + KO_OFF_NT) && getLong(Base_Adr + KO_OFF_ID) <= 9999 && searchList(plName, lstTarget) == false)
                            lstTarget.Items.Add(plName);
                        break;
                    case "Player":
                        if (searchList(getTargetName(Base_Adr, true), lstTarget) == false)
                            lstTarget.Items.Add(plName);
                        break;
                    case "Mob":
                        if (getLong(Base_Adr + KO_OFF_NT) <= 0 && plName != "Dig Guard" && searchList(plName, lstTarget) == false)
                            lstTarget.Items.Add(plName);
                        break;
                    default:
                        break;
                }
            }
        }
        public string getNpcID(string TargetName)
        {
            int Ebp, Esi, Eax, Fend, Base_Adr, GetTime, GetTickTime;
            Ebp = getLong(getLong(KO_FLDB) + 0x34);
            Fend = getLong(getLong((Ebp + 4)) + 4);
            Esi = getLong(Ebp);
            GetTickTime = (int)GetTickCount();
            GetTime = GetTickTime;
            while (Esi != Ebp)
            {
                if (GetTickTime - GetTime > 50) { break; }
                Base_Adr = getLong(Esi + 0x10);
                if (Base_Adr == 0) { break; }
                Eax = getLong(Esi + 8);
                if (getLong(Esi + 8) != Fend)
                {
                    while (getLong(Eax) != Fend)
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Eax = getLong(Eax);
                    }
                    Esi = Eax;
                }
                else
                {
                    Eax = getLong(Esi + 4);
                    while (Esi == getLong(Eax + 8))
                    {
                        if (GetTickTime - GetTime > 50) { break; }
                        Esi = Eax;
                        Eax = getLong(Eax + 4);
                    }
                    if (getLong(Esi + 8) != Eax)
                    {
                        Esi = Eax;
                    }
                }
                if (TargetName == getTargetName(Base_Adr, true))
                {
                    return Adword(getLong(Base_Adr + KO_OFF_ID),2);
                }
            }
            return "Null";
        }
        #endregion
        //#########################################################################################
        #region CS Function
        public void AutoPotionHP()
        {
            if (getInvSlot(389010000) > 0 && LastHp() >= 45) { setPacketPot("1A7A07", 0, CharID()); return; }
            if (getInvSlot(389011000) > 0 && LastHp() >= 90) { setPacketPot("1B7A07", 1, CharID()); return; }
            if (getInvSlot(900770000) > 0 && LastHp() >= 90) { setPacketPot("E28107", 2, CharID()); return; }
            if (getInvSlot(389012000) > 0 && LastHp() >= 180) { setPacketPot("1C7A07", 3, CharID()); return; }
            if (getInvSlot(900780000) > 0 && LastHp() >= 180) { setPacketPot("E38107", 4, CharID()); return; }
            if (getInvSlot(389013000) > 0 && LastHp() >= 360) { setPacketPot("1D7A07", 5, CharID()); return; }
            if (getInvSlot(900790000) > 0 && LastHp() >= 360) { setPacketPot("E48107", 6, CharID()); return; }
            if (getInvSlot(389014000) > 0 && LastHp() >= 720) { setPacketPot("1E7A07", 7, CharID()); return; }
            if (getInvSlot(399284000) > 0 && LastHp() >= 720) { setPacketPot("5A7A07", 8, CharID()); return; }
        }
        public void AutoPotionMP()
        {
            if (getInvSlot(389016000) > 0 && LastMp() >= 90) { setPacketPot("207A07", 9, CharID()); return; }
            if (getInvSlot(389017000) > 0 && LastMp() >= 180) { setPacketPot("217A07", 10, CharID()); return; }
            if (getInvSlot(900800000) > 0 && LastMp() >= 180) { setPacketPot("E58107", 11, CharID()); return; }
            if (getInvSlot(389018000) > 0 && LastMp() >= 480) { setPacketPot("227A07", 12, CharID()); return; }
            if (getInvSlot(900810000) > 0 && LastMp() >= 480) { setPacketPot("E68107", 13, CharID()); return; }
            if (getInvSlot(389019000) > 0 && LastMp() >= 960) { setPacketPot("237A07", 14, CharID()); return; }
            if (getInvSlot(900820000) > 0 && LastMp() >= 960) { setPacketPot("E78107", 15, CharID()); return; }
            if (getInvSlot(389020000) > 0 && LastMp() >= 1920) { setPacketPot("247A07", 16, CharID()); return; }
            if (getInvSlot(399285000) > 0 && LastMp() >= 1920) { setPacketPot("9C7A07", 17, CharID()); return; }
        }
        public void AutoPotionHP(int percHp)
        {
            if(CharHP() <= ((CharMaxHP() * percHp)/100))
            {
                if (getInvSlot(389010000) > 0) { setPacketPot("1A7A07", 0, CharID()); return; }
                if (getInvSlot(389011000) > 0) { setPacketPot("1B7A07", 1, CharID()); return; }
                if (getInvSlot(900770000) > 0) { setPacketPot("E28107", 2, CharID()); return; }
                if (getInvSlot(389012000) > 0) { setPacketPot("1C7A07", 3, CharID()); return; }
                if (getInvSlot(900780000) > 0) { setPacketPot("E38107", 4, CharID()); return; }
                if (getInvSlot(389013000) > 0) { setPacketPot("1D7A07", 5, CharID()); return; }
                if (getInvSlot(900790000) > 0) { setPacketPot("E48107", 6, CharID()); return; }
                if (getInvSlot(389014000) > 0) { setPacketPot("1E7A07", 7, CharID()); return; }
                if (getInvSlot(399284000) > 0) { setPacketPot("5A7A07", 8, CharID()); return; }
            }
        }
        public void AutoPotionMP(int percMp)
        {
            if(CharMP() <= ((CharMaxMP() * percMp)/100))
            {
                if (getInvSlot(389016000) > 0) { setPacketPot("207A07", 9, CharID()); return; }
                if (getInvSlot(389017000) > 0) { setPacketPot("217A07", 10, CharID()); return; }
                if (getInvSlot(900800000) > 0) { setPacketPot("E58107", 11, CharID()); return; }
                if (getInvSlot(389018000) > 0) { setPacketPot("227A07", 12, CharID()); return; }
                if (getInvSlot(900810000) > 0) { setPacketPot("E68107", 13, CharID()); return; }
                if (getInvSlot(389019000) > 0) { setPacketPot("237A07", 14, CharID()); return; }
                if (getInvSlot(900820000) > 0) { setPacketPot("E78107", 15, CharID()); return; }
                if (getInvSlot(389020000) > 0) { setPacketPot("247A07", 16, CharID()); return; }
                if (getInvSlot(399285000) > 0) { setPacketPot("9C7A07", 17, CharID()); return; }
            }
        }
        public void useMinor(string TargetHexID)/* TODO */
        {
            int SkillID = getSkillID(CharClass(), "705");
            if(CharClassName() == "Rogue" && CharSkill(3) >= 5)
            {
                if(TargetHexID == CharID())
                {
                    if ((CharMaxHP() - CharHP()) > 60)
                        setPSec("3103" + Adword(SkillID, 4) + CharID() + CharID() + "00000000000000000000000000000000", 10, 0);
                }
                else
                {
                    if((getTargetMaxHP(DecDword(TargetHexID)) - getTargetHP(DecDword(TargetHexID))) > 60)
                        setPSec("3103" + Adword(SkillID, 4) + CharID() + TargetHexID + "00000000000000000000000000000000", 10, 0);
                }
            }
        }
        public void useTs(int tsRow)
        {
            int ClassID = 0;
            if (getInvSlot(379091000)>-1 && getTSControl("472") == false)
            { 
                switch (tsRow)
                {
                    case 0: ClassID = 472310; break;
                    case 1: ClassID = 472020; break;
                    case 2: ClassID = 472040; break;
                    case 3: ClassID = 472050; break;
                    case 4: ClassID = 472070; break;
                    case 5: ClassID = 472080; break;
                    case 6: ClassID = 472090; break;
                    case 7: ClassID = 472130; break;
                    case 8: ClassID = 472132; break;
                    case 9: ClassID = 472150; break;
                    case 10: ClassID = 472202; break;
                    case 11: ClassID = 472250; break;
                    case 12: ClassID = 472260; break;
                    case 13: ClassID = 472276; break;
                    case 14: ClassID = 472280; break;
                    default:
                        break;
                }
                setPSec("3103" + Adword(ClassID, 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 1);
            }
        }
        public void useMeat()
        {
            if(getInvSlot(508216000) > -1 && getSkillControl("141") == false)
            {
                setPSec("3103" + Adword(490141, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 2);
            }
        }
        public void useGate()
        {
            int SkillID = getSkillID(CharClass(), "700");
            if(CharLevel() >= 10 && CharClassName() == "Priest" || CharClassName() == "Mage")
            {
                setPSec("3101" + Adword(SkillID, 4) + CharID() + CharID() + "00000000000000000000000000000F00", 10000, 3);
                setPSec("3103" + Adword(SkillID, 4) + CharID() + CharID() + "000000000000000000000000", 10000, 4);
            }
        }
        public void useDropScBug()
        {
            if(getSkillControl("095") == false)
            {
                setPSec("3103" + Adword(500095, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 5);
            }
        }
        public void useAttackBuffBug()
        {
            if (getSkillControl("271") == false)
            {
                setPSec("3103" + Adword(500271, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 6);
            }
        }
        public void useAttackScBug()
        {
            if (getSkillControl("023") == false)
            {
                setPSec("3103" + Adword(492023, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 7);
            }
        }
        public void useWeaponSc()
        {
            if (getSkillControl("049") == false && getInvSlot(389155000) > -1)
            {
                setPSec("3103" + Adword(500049, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 8);
            }
        }
        public void useArmorSc()
        {
            if (getSkillControl("050") == false && getInvSlot(389156000) > -1)
            {
                setPSec("3103" + Adword(500050, 4) + CharID() + CharID() + "000000000000000000000000", 1000, 9);
            }
        }
        public void useRespawn()
        {
            setPack("290103");
            setPack("1200");
        }
        public void useTown()
        {
            if ((CharHP() * 100) / CharMaxHP() > 50)
                setPSec("4800", 200, 10);
            else
                useRespawn();
        }
        public void useAbysGem()
        {
            setPack("2001" + getNpcID("Moira") + "FFFFFFFF");
            setPack("640725100000");
            setPack("55000F31363034375F4D6F6972612E6C7561FF");
        }
        public void attackR(int TargetID,string rCode)
        {
            setPSec(rCode + Adword(TargetID, 2) + "D100F9FF00", 1000, 11);
        }
        public void useMagicHammer()
        {
            if(getDurabItem(3) < 250 || getDurabItem(6) < 250 || getDurabItem(8) < 250 || getDurabItem(10) < 250 || getDurabItem(12) < 250 || getDurabItem(14) < 250 || getDurabItem(15) < 250)
            {
                setPSec("3103" + Adword(490202, 4) + CharID() + CharID() + "00000000000000000000000000000000", 1000, 12);
            }
        }
        public void useBezoar()
        {
            if (getInvSlot(389034000) > -1 && getSkillControl("034") == false)
            {
                setPSec("3103" + Adword(490034, 4) + CharID() + CharID() + "00000000000000000000000000000000", 1000, 13);
            }
        }
        public void useCake()
        {
            if (getInvSlot(389035000) > -1 && getSkillControl("035") == false)
            {
                setPSec("3103" + Adword(490035, 4) + CharID() + CharID() + "00000000000000000000000000000000", 1000, 14);
            }
        }
        public string getTargetSkillCoor()
        {
            return Adword(getTargetX(), 2) + Adword(getTargetZ(), 2) + Adword(getTargetY(), 2);
        }
        public string getCharSkillCoor()
        {
            return Adword(CharX(), 2) + Adword(CharZ(), 2) + Adword(CharY(), 2);
        }
        #endregion
        //#########################################################################################
        #region Warrior Skill System
        public void setWarSkillDown()
        {
            for (int i = 0; i <= WarSkill.Length; i++)
            {
                WarSkill[i] -= 1;
            }
        }
        public void attackWarriorSkill(int TargetID, string WarSkillID)
        {
            if (TargetID > 0)
                setPack("3103" + Adword(getSkillID(CharClass(), WarSkillID), 4) + CharID() + Adword(TargetID, 2) + "01000100000000000000000000000000");
        }
        public void skillWarriorTime(string SkillNo, int SkillSec, int SkillRow)
        {
            setPSec("3103" + Adword(getSkillID(CharClass(), SkillNo), 4) + CharID() + CharID() + "00000000000000000000000000000000", SkillSec, SkillRow);
        }
        public void attackWarrior(ListView lstview)
        {
            if (getTargetDistance() > 15)
                return;
            //R Atak
            if (lstview.Items[0].Checked) { attackR(zTargetID, lstview.Items[0].SubItems[1].Text); }
            //Blooding
            if (lstview.Items[20].Checked && CharMP() >= 350 && WarSkill[20] <= 0 && CharSkill(1) >= 75) { WarSkill[20] = 2100; attackWarriorSkill(zTargetID, lstview.Items[20].SubItems[1].Text); return; }
            //Leg Cutting
            if (lstview.Items[9].Checked && CharMP() >= 84 && WarSkill[9] <= 0 && CharSkill(1) >= 20) { WarSkill[9] = 495; attackWarriorSkill(zTargetID, lstview.Items[9].SubItems[1].Text); return; }
            //Slash
            if (lstview.Items[2].Checked && CharMP() >= 4 && WarSkill[2] <= 0 && CharSkill(1) >= 0) { WarSkill[2] = 385; attackWarriorSkill(zTargetID, lstview.Items[2].SubItems[1].Text); return; }
            //Crash
            if (lstview.Items[3].Checked && CharMP() >= 4 && WarSkill[3] <= 0 && CharSkill(1) >= 0) { WarSkill[3] = 295; attackWarriorSkill(zTargetID, lstview.Items[3].SubItems[1].Text); return; }
            //Piercing
            if (lstview.Items[4].Checked && CharMP() >= 8 && WarSkill[4] <= 0 && CharSkill(1) >= 0) { WarSkill[4] = 295; attackWarriorSkill(zTargetID, lstview.Items[4].SubItems[1].Text); return; }
            //Hash
            if (lstview.Items[5].Checked && CharMP() >= 10 && WarSkill[5] <= 0 && CharSkill(1) >= 0) { WarSkill[5] = 295; attackWarriorSkill(zTargetID, lstview.Items[5].SubItems[1].Text); return; }
            //Shear
            if (lstview.Items[7].Checked && CharMP() >= 20 && WarSkill[7] <= 0 && CharSkill(1) >= 10) { WarSkill[7] = 295; attackWarriorSkill(zTargetID, lstview.Items[7].SubItems[1].Text); return; }
            //Sever
            if (lstview.Items[11].Checked && CharMP() >= 40 && WarSkill[11] <= 0 && CharSkill(1) >= 30) { WarSkill[11] = 295; attackWarriorSkill(zTargetID, lstview.Items[11].SubItems[1].Text); return; }
            //Multiple Shork
            if (lstview.Items[13].Checked && CharMP() >= 60 && WarSkill[13] <= 0 && CharSkill(1) >= 40) { WarSkill[13] = 295; attackWarriorSkill(zTargetID, lstview.Items[13].SubItems[1].Text); return; }
            //Mangling
            if (lstview.Items[15].Checked && CharMP() >= 60 && WarSkill[15] <= 0 && CharSkill(1) >= 50) { WarSkill[15] = 295; attackWarriorSkill(zTargetID, lstview.Items[15].SubItems[1].Text); return; }
            //Thrust
            if (lstview.Items[16].Checked && CharMP() >= 200 && WarSkill[16] <= 0 && CharSkill(1) >= 55) { WarSkill[16] = 295; attackWarriorSkill(zTargetID, lstview.Items[16].SubItems[1].Text); return; }
            //Pierce
            if (lstview.Items[8].Checked && CharMP() >= 60 && WarSkill[8] <= 0 && CharSkill(1) >= 15) { WarSkill[8] = 0; attackWarriorSkill(zTargetID, lstview.Items[8].SubItems[1].Text); return; }
            //Hell Blade
            if (lstview.Items[21].Checked && CharMP() >= 400 && WarSkill[21] <= 0 && CharSkill(1) >= 80) { WarSkill[21] = 0; attackWarriorSkill(zTargetID, lstview.Items[21].SubItems[1].Text); return; }
            //Howling Sword
            if (lstview.Items[19].Checked && CharMP() >= 400 && WarSkill[19] <= 0 && CharSkill(1) >= 70) { WarSkill[19] = 0; attackWarriorSkill(zTargetID, lstview.Items[19].SubItems[1].Text); return; }
            //Sword Dancing
            if (lstview.Items[18].Checked && CharMP() >= 300 && WarSkill[18] <= 0 && CharSkill(1) >= 60) { WarSkill[18] = 0; attackWarriorSkill(zTargetID, lstview.Items[18].SubItems[1].Text); return; }
            //Sword Aura
            if (lstview.Items[17].Checked && CharMP() >= 250 && WarSkill[17] <= 0 && CharSkill(1) >= 57) { WarSkill[17] = 0; attackWarriorSkill(zTargetID, lstview.Items[17].SubItems[1].Text); return; }
            //Cleave
            if (lstview.Items[14].Checked && CharMP() >= 150 && WarSkill[14] <= 0 && CharSkill(1) >= 45) { WarSkill[14] = 0; attackWarriorSkill(zTargetID, lstview.Items[14].SubItems[1].Text); return; }
            //Prick
            if (lstview.Items[12].Checked && CharMP() >= 120 && WarSkill[12] <= 0 && CharSkill(1) >= 35) { WarSkill[12] = 0; attackWarriorSkill(zTargetID, lstview.Items[12].SubItems[1].Text); return; }
            //Carving
            if (lstview.Items[10].Checked && CharMP() >= 90 && WarSkill[10] <= 0 && CharSkill(1) >= 25) { WarSkill[10] = 0; attackWarriorSkill(zTargetID, lstview.Items[10].SubItems[1].Text); return; }
            //Hoodwink
            if (lstview.Items[6].Checked && CharMP() >= 30 && WarSkill[6] <= 0 && CharSkill(1) >= 5) { WarSkill[6] = 0; attackWarriorSkill(zTargetID, lstview.Items[6].SubItems[1].Text); return; }
            //Stroke
            if (lstview.Items[1].Checked && CharMP() >= 2 && WarSkill[1] <= 0 && CharSkill(1) >= 0) { WarSkill[1] = 0; attackWarriorSkill(zTargetID, lstview.Items[1].SubItems[1].Text); return; }
        }
        public void skillWarrior(ListView lstview)
        {
            //Sprint
            if (lstview.Items[22].Checked && CharMP() >= 2 && getSkillControl("002") == false && getSkillControl("010") == false) { skillWarriorTime(lstview.Items[22].SubItems[1].Text, 1000, 15); }
            //Defense
            if (lstview.Items[23].Checked && CharMP() >= 4 && getSkillControl(lstview.Items[23].SubItems[1].Text) == false && CharLevel() >= 7) { skillWarriorTime(lstview.Items[23].SubItems[1].Text, 1000, 16); }
            //Gain
            if (lstview.Items[24].Checked && CharMP() >= 4 && getSkillControl(lstview.Items[24].SubItems[1].Text) == false && CharSkill(3) >= 5) { skillWarriorTime(lstview.Items[24].SubItems[1].Text, 1000, 17); }
        }
        #endregion
        //#########################################################################################
        #region Rogue Skill System
        public void setRogueSkillDown()
        {
            for (int i = 0; i <= RogueSkill.Length; i++)
            {
                RogueSkill[i] -= 1;
            }
        }
        public void attackArchery(int TargetID,string RogueSkillID)
        {
            if (TargetID <= 0)
                return;
            int SkillID = getSkillID(CharClass(), RogueSkillID);
            if(RogueSkillID == "552" || RogueSkillID == "585")
                setPack("3101" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000A00");
            else
                setPack("3101" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000D00");
            setPack("3102" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "000000000000000000000000");
            setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000000");
            setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0000000000000000");
        }
        public void attackArrow(int TargetID,bool FiveAroorw)
        {
            int SkillID;
            if(FiveAroorw == false)
            {
                SkillID = getSkillID(CharClass(), "515");
                setPack("3101" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000D00");
                setPack("3102" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "000000000000010000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000001000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0100000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000002000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0200000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000003000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0300000000000000");
            }
            else
            {
                SkillID = getSkillID(CharClass(), "555");
                setPack("3101" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000F00");
                setPack("3102" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "000000000000010000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000001000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0100000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000002000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0200000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000003000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0300000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000004000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0400000000000000");
                setPack("3103" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + "00000000000005000000000000000000");
                setPack("3104" + Adword(SkillID, 8) + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0500000000000000");
            }
        }
        public void attackAssaian(int TargetID,string AssaianSkillID)
        {
            int SkillID = getSkillID(CharClass(),AssaianSkillID);
            if(TargetID > 0 && CharRogueJob() == true)
            {
                if(AssaianSkillID == "610" || AssaianSkillID == "650" || AssaianSkillID == "630")
                {
                    setPack("3101" + Adword(SkillID, 4) + CharID() + Adword(TargetID, 2) + "00000000000000000000000000001000");
                    setPack("3103" + Adword(SkillID, 4) + CharID() + Adword(TargetID, 2) + "000000000000000000000000");
                }
                else
                {
                    setPack("3103" + Adword(SkillID, 4) + CharID() + Adword(TargetID, 2) + "01000100000000000000000000000000");
                }
            }
        }
        public void attackArcherySkill(ListView lstview)
        {
            //Multiple Shoot & Arrow Shower
            if (getTargetDistance() < 3)
            {
                if (lstview.Items[6].Checked && lstview.Items[14].Checked)
                {
                    if (CharMP() >= 40 && RogueSkill[6] <= 0 && CharSkill(1) >= 15) { RogueSkill[6] = 10; attackArrow(zTargetID, false); }
                    if (CharMP() >= 150 && RogueSkill[14] <= 0 && CharSkill(1) >= 55) { RogueSkill[14] = 10; attackArrow(zTargetID, true); return; }
                }
                else if (lstview.Items[6].Checked && lstview.Items[14].Checked == false)
                {
                    if (CharMP() >= 40 && RogueSkill[6] <= 0 && CharSkill(1) >= 15) { RogueSkill[6] = 10; attackArrow(zTargetID, false); }
                }
                else if (lstview.Items[6].Checked == false && lstview.Items[14].Checked)
                {
                    if (CharMP() >= 150 && RogueSkill[14] <= 0 && CharSkill(1) >= 55) { RogueSkill[14] = 10; attackArrow(zTargetID, true); }
                }
            }
            //Counter Strike
            if (lstview.Items[15].Checked && CharMP() >= 150 && RogueSkill[15] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 52) { RogueSkill[15] = 6100; attackArchery(zTargetID, lstview.Items[15].SubItems[1].Text); return; }
            //Blinding Strafe
            if (lstview.Items[22].Checked && CharMP() >= 300 && RogueSkill[22] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 75) { RogueSkill[22] = 6100; attackArchery(zTargetID, lstview.Items[22].SubItems[1].Text); return; }
            //Power Shot
            if (lstview.Items[23].Checked && CharMP() >= 400 && RogueSkill[23] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 80) { RogueSkill[23] = 6100; attackArchery(zTargetID, lstview.Items[23].SubItems[1].Text); return; }
            //İce Shot
            if (lstview.Items[18].Checked && CharMP() >= 200 && RogueSkill[18] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 62) { RogueSkill[18] = 600; attackArchery(zTargetID, lstview.Items[18].SubItems[1].Text); return; }
            //Lighting Shot
            if (lstview.Items[19].Checked && CharMP() >= 200 && RogueSkill[19] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 66) { RogueSkill[19] = 600; attackArchery(zTargetID, lstview.Items[19].SubItems[1].Text); return; }
            //Explosive Shot
            if (lstview.Items[12].Checked && CharMP() >= 50 && RogueSkill[12] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 45) { RogueSkill[12] = 490; attackArchery(zTargetID, lstview.Items[12].SubItems[1].Text); return; }
            //Viper
            if (lstview.Items[13].Checked && CharMP() >= 50 && RogueSkill[13] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 50) { RogueSkill[13] = 490; attackArchery(zTargetID, lstview.Items[13].SubItems[1].Text); return; }
            //Fire Shot
            if (lstview.Items[9].Checked && CharMP() >= 30 && RogueSkill[9] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 30) { RogueSkill[9] = 490; attackArchery(zTargetID, lstview.Items[9].SubItems[1].Text); return; }
            //Poison Shot
            if (lstview.Items[10].Checked && CharMP() >= 30 && RogueSkill[10] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 35) { RogueSkill[10] = 490; attackArchery(zTargetID, lstview.Items[10].SubItems[1].Text); return; }
            //FireArrow
            if (lstview.Items[4].Checked && CharMP() >= 10 && RogueSkill[4] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 5) { RogueSkill[4] = 400; attackArchery(zTargetID, lstview.Items[4].SubItems[1].Text); return; }
            //Poison Arrow
            if (lstview.Items[5].Checked && CharMP() >= 10 && RogueSkill[5] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 10) { RogueSkill[5] = 400; attackArchery(zTargetID, lstview.Items[5].SubItems[1].Text); return; }
            //Blow Arrow
            if (lstview.Items[21].Checked && CharMP() >= 200 && RogueSkill[21] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 72) { RogueSkill[21] = 0; attackArchery(zTargetID, lstview.Items[21].SubItems[1].Text); return; }
            //Dark pursuer
            if (lstview.Items[20].Checked && CharMP() >= 350 && RogueSkill[20] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 70) { RogueSkill[20] = 0; attackArchery(zTargetID, lstview.Items[20].SubItems[1].Text); return; }
            //Shadow Hunter
            if (lstview.Items[17].Checked && CharMP() >= 300 && RogueSkill[17] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 60) { RogueSkill[17] = 0; attackArchery(zTargetID, lstview.Items[17].SubItems[1].Text); return; }
            //Shadow Shot
            if (lstview.Items[16].Checked && CharMP() >= 200 && RogueSkill[16] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 57) { RogueSkill[16] = 0; attackArchery(zTargetID, lstview.Items[16].SubItems[1].Text); return; }
            //Arc Shot
            if (lstview.Items[11].Checked && CharMP() >= 100 && RogueSkill[11] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 40) { RogueSkill[11] = 0; attackArchery(zTargetID, lstview.Items[11].SubItems[1].Text); return; }
            //Perfect Shot
            if (lstview.Items[8].Checked && CharMP() >= 70 && RogueSkill[8] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 25) { RogueSkill[8] = 0; attackArchery(zTargetID, lstview.Items[8].SubItems[1].Text); return; }
            //Guided Arrow
            if (lstview.Items[7].Checked && CharMP() >= 40 && RogueSkill[7] <= 0 && getTargetDistance() <= 55 && CharSkill(1) >= 20) { RogueSkill[7] = 0; attackArchery(zTargetID, lstview.Items[7].SubItems[1].Text); return; }
            //Through Shot
            if (lstview.Items[3].Checked && CharMP() >= 15 && RogueSkill[3] <= 0 && getTargetDistance() <= 55 && CharLevel() >= 10) { RogueSkill[3] = 0; attackArchery(zTargetID, lstview.Items[3].SubItems[1].Text); return; }
            //Archery2
            if (lstview.Items[2].Checked && CharMP() >= 7 && RogueSkill[2] <= 0 && getTargetDistance() <= 55 && CharLevel() >= 7) { RogueSkill[2] = 0; attackArchery(zTargetID, lstview.Items[2].SubItems[1].Text); return; }
            //Archery
            if (lstview.Items[1].Checked && CharMP() >= 0 && RogueSkill[1] <= 0 && getTargetDistance() <= 55 && CharLevel() >= 3) { RogueSkill[1] = 0; attackArchery(zTargetID, lstview.Items[1].SubItems[1].Text); return; }
        }
        public void attackAssaianSkill(ListView lstview)
        {
            if (getTargetDistance() < 15)
            {
                //R Attack
                if (lstview.Items[0].Checked) { attackR(zTargetID, lstview.Items[0].SubItems[1].Text); }
                //Blinding 
                if (lstview.Items[37].Checked && CharMP() >= 200 && RogueSkill[37] <= 0 && CharSkill(2) >= 72) { RogueSkill[37] = 6100; attackAssaian(zTargetID, lstview.Items[37].SubItems[1].Text); return; }
                //Vampiric touch
                if (lstview.Items[34].Checked && CharMP() >= 50 && RogueSkill[34] <= 0 && CharSkill(2) >= 50) { RogueSkill[34] = 6100; attackAssaian(zTargetID, lstview.Items[34].SubItems[1].Text); return; }
                //Blood drain
                if (lstview.Items[28].Checked && CharMP() >= 20 && RogueSkill[28] <= 0 && CharSkill(2) >= 10) { RogueSkill[28] = 6100; attackAssaian(zTargetID, lstview.Items[28].SubItems[1].Text); return; }
                //Beast Hiding
                if (lstview.Items[38].Checked && CharMP() >= 250 && RogueSkill[38] <= 0 && CharSkill(2) >= 75) { RogueSkill[38] = 4100; attackAssaian(zTargetID, lstview.Items[38].SubItems[1].Text); return; }
                //Spike
                if (lstview.Items[35].Checked && CharMP() >= 100 && RogueSkill[35] <= 0 && CharSkill(2) >= 55) { RogueSkill[35] = 1090; attackAssaian(zTargetID, lstview.Items[35].SubItems[1].Text); return; }
                //thrust 
                if (lstview.Items[32].Checked && CharMP() >= 50 && RogueSkill[32] <= 0 && CharSkill(2) >= 35) { RogueSkill[32] = 1090; attackAssaian(zTargetID, lstview.Items[32].SubItems[1].Text); return; }
                //Pierce
                if (lstview.Items[29].Checked && CharMP() >= 20 && RogueSkill[29] <= 0 && CharSkill(2) >= 15) { RogueSkill[29] = 1090; attackAssaian(zTargetID, lstview.Items[29].SubItems[1].Text); return; }
                //Illusion
                if (lstview.Items[31].Checked && CharMP() >= 30 && RogueSkill[31] <= 0 && CharSkill(2) >= 30) { RogueSkill[31] = 1090; attackAssaian(zTargetID, lstview.Items[31].SubItems[1].Text); return; }
                //Cut 
                if (lstview.Items[33].Checked && CharMP() >= 50 && RogueSkill[33] <= 0 && CharSkill(2) >= 40) { RogueSkill[33] = 500; attackAssaian(zTargetID, lstview.Items[33].SubItems[1].Text); return; }
                //Bloody Beast
                if (lstview.Items[36].Checked && CharMP() >= 100 && RogueSkill[36] <= 0 && CharSkill(2) >= 70) { RogueSkill[36] = 500; attackAssaian(zTargetID, lstview.Items[36].SubItems[1].Text); return; }
                //shock
                if (lstview.Items[30].Checked && CharMP() >= 20 && RogueSkill[30] <= 0 && CharSkill(2) >= 20) { RogueSkill[30] = 490; attackAssaian(zTargetID, lstview.Items[30].SubItems[1].Text); return; }
                //Jab
                if (lstview.Items[27].Checked && CharMP() >= 10 && RogueSkill[27] <= 0 && CharLevel() >= 10) { RogueSkill[27] = 490; attackAssaian(zTargetID, lstview.Items[27].SubItems[1].Text); return; }
                //Stab2
                if (lstview.Items[26].Checked && CharMP() >= 5 && RogueSkill[26] <= 0 && CharLevel() >= 7) { RogueSkill[26] = 500; attackAssaian(zTargetID, lstview.Items[26].SubItems[1].Text); return; }
                //Stab
                if (lstview.Items[25].Checked && CharMP() >= 5 && RogueSkill[25] <= 0 && CharLevel() >= 5) { RogueSkill[25] = 500; attackAssaian(zTargetID, lstview.Items[25].SubItems[1].Text); return; }
                //Stroke
                if (lstview.Items[24].Checked && CharMP() >= 2 && RogueSkill[24] <= 0 && CharLevel() >= 0) { RogueSkill[24] = 0; attackAssaian(zTargetID, lstview.Items[24].SubItems[1].Text); return; }
            }
        }
        public void skillRogueTime(ListView lstview)
        {
            //Sprint
            if (lstview.Items[40].Checked && CharMP() >= 2 && CharLevel() >= 1) { useSprint(); return; }
            //Swift
            if (lstview.Items[41].Checked && CharMP() >= 15 && CharLevel() >= 10) { useSwift(); return; }
            //Wolf
            if (lstview.Items[42].Checked && CharMP() >= 30 && CharLevel() >= 30) { useWolf(); return; }
            //Hide
            if (lstview.Items[43].Checked && CharMP() >= 40 && CharSkill(3) >= 30 && RogueSkill[43] <= 0) { useHide(); RogueSkill[43] = 1100; return; }
            //CatEyes
            if (lstview.Items[45].Checked && CharMP() >= 60 && CharSkill(3) >= 15) { useCatsEye(); return; }
            //Light Feet
            if (lstview.Items[46].Checked && CharMP() >= 40 && CharSkill(3) >= 25) { useLightFeet(); return; }
            //Lupine Eyes
            if (lstview.Items[48].Checked && CharMP() >= 200 && CharSkill(3) >= 35) { useLupinEyes(); return; }
            //Stealth
            if (lstview.Items[50].Checked && CharMP() >= 270 && CharSkill(2) >= 45 && RogueSkill[50] <= 0) { useStealth(); RogueSkill[50] = 1100; return; }
            //Rogue Defense Skill
            if(getSkillControl("710") == false && getSkillControl("730") == false && getSkillControl("760") == false)
            {
                //ScaledSkin
                if (lstview.Items[49].Checked && CharMP() >= 160 && CharSkill(3) >= 60 && RogueSkill[49] <= 0)
                {
                    RogueSkill[47] = 100;
                    RogueSkill[44] = 100;
                    useScaledSkin();
                    RogueSkill[49] = 3200;
                    return;
                }
                //Safety
                if (lstview.Items[47].Checked && CharMP() >= 80 && CharSkill(3) >= 30 && RogueSkill[47] <= 0)
                {
                    RogueSkill[49] = 100;
                    RogueSkill[44] = 100;
                    useSafety();
                    RogueSkill[47] = 3200;
                    return;
                }
                //Evade
                if (lstview.Items[44].Checked && CharMP() >= 40 && CharSkill(3) >= 10 && RogueSkill[44] <= 0)
                {
                    RogueSkill[49] = 100;
                    RogueSkill[47] = 100;
                    useEvade();
                    RogueSkill[44] = 3200;
                    return;
                }
            }
        }
        #region Rogue Time Skills
        public void useSprint()
        {
            if (getSkillControl("002") == false && getSkillControl("010") == false && getSkillControl("725") == false)
                setPSec("3103" + Adword(getSkillID(CharClass(), "002"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 18);
        }
        public void useSwift()
        {
            if (getSkillControl("002") == false && getSkillControl("010") == false && getSkillControl("725") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "010"), 4) + CharID() + CharID() + "00000000000000000000000000000F00", 1000, 19);
                setPSec("3103" + Adword(getSkillID(CharClass(), "010"), 4) + CharID() + CharID() + getCharSkillCoor() + "000000000000", 1000, 20);
            }
        }
        public void useSwift(int TargetID)
        {
            if(TargetID >0)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "010"), 4) + CharID() + Adword(TargetID,2) + "00000000000000000000000000000F00", 1000, 21);
                setPSec("3103" + Adword(getSkillID(CharClass(), "010"), 4) + CharID() + Adword(TargetID, 2) + getCharSkillCoor() + "000000000000", 1000, 22);
            }
        }
        public void useLightFeet()
        {
            if (getSkillControl("002") == false && getSkillControl("010") == false && getSkillControl("725") == false)
                setPSec("3103" + Adword(getSkillID(CharClass(), "725"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 23);
        }
        public void useWolf()
        {
            if(getSkillControl("030") == false && getInvSlot(370004000) > -1)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "030"), 4) + CharID() + "FFFF" + getCharSkillCoor() + "00000000000000001100", 1000, 24);
                setPSec("3103" + Adword(getSkillID(CharClass(), "030"), 4) + CharID() + "FFFF" + getCharSkillCoor() + "000000000000", 1000, 25);
            }
        }
        public void useHide()
        {
            if(getSkillControl("645") == false && getSkillControl("700") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "700"), 4) + CharID() + CharID() + "00000000000000000000000000000F00", 1000, 26);
                setPSec("3103" + Adword(getSkillID(CharClass(), "700"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 27);
            }
        }
        public void useScaledSkin()
        {
            setPSec("3103" + Adword(getSkillID(CharClass(), "760"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 28);
        }
        public void useSafety()
        {
            setPSec("3103" + Adword(getSkillID(CharClass(), "730"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 29);
        }
        public void useEvade()
        {
            setPSec("3103" + Adword(getSkillID(CharClass(), "710"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 30);
        }
        public void useCatsEye()
        {
            if (getSkillControl("715") == false && getSkillControl("735") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "715"), 4) + CharID() + CharID() + "00000000000000000000000000000F00", 1000, 31);
                setPSec("3103" + Adword(getSkillID(CharClass(), "715"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 32);
            }
        }
        public void useLupinEyes()
        {
            if (getSkillControl("715") == false && getSkillControl("735") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "735"), 4) + CharID() + CharID() + "00000000000000000000000000001400", 1000, 33);
                setPSec("3103" + Adword(getSkillID(CharClass(), "735"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 34);
            }
        }
        public void useStealth()
        {
            if (getSkillControl("645") == false && getSkillControl("700") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "645"), 4) + CharID() + CharID() + "00000000000000000000000000001E00", 1000, 35);
                setPSec("3103" + Adword(getSkillID(CharClass(), "645"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 36);
            }
        }
        #endregion
        #endregion
        //#########################################################################################
        #region Mage Skill System
        public void useMageSkill(int TargetID, string SkillNumber)
        {
            string SkillID = Adword(getSkillID(CharClass(), SkillNumber), 4);
            if (TargetID <= 0) { return; }
            switch (SkillNumber)
            {
                case "002"://Basic
                case "003":
                case "005":
                case "007":
                case "009":
                case "509"://Flame
                case "539":
                case "551":
                case "554":
                case "603"://İce
                case "609":
                case "618":
                case "639":
                case "651":
                case "703"://Lightning
                case "709":
                case "718":
                case "739":
                case "715":
                case "727":
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000F00");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    break;
                case "010"://Basic
                case "542"://Flame
                case "572":
                case "642"://İce
                case "672":
                case "742"://Lightning
                case "772":
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + "01000100000000000000000000000000");
                    break;
                case "503"://Flame
                case "518":
                case "543":
                case "556":
                case "643"://İce
                case "656":
                case "743"://Lightning
                case "756":
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000A00");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    break;
                case "515"://Flame
                case "527":
                case "535":
                case "557":
                case "615"://İce
                case "627":
                case "635":
                case "657":
                case "735"://Lightning
                case "757":
                case "751":
                case "754":
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000F00");
                    setPack("3102" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000000");
                    setPack("3104" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "9BFF0000000000000000");
                    break;
                case "570"://Flame
                case "670"://İce
                case "770"://Lightning
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000B00");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    break;
                case "533"://Flame
                case "633"://İce
                case "733"://Lightning
                    setPack("3101" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "00000000000000000F00");
                    setPack("3102" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "000000000000");
                    setPack("3103" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "00000000000000000000");
                    setPack("3104" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "9BFF0000000000000000");
                    break;
                case "545"://Flame
                case "560":
                case "645"://İce
                case "660":
                case "745"://Lightning
                case "760":
                    setPack("3101" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "00000000000000000F00");
                    setPack("3103" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "000000000000");
                    break;
                case "571"://Flame
                case "671"://İce
                case "771"://Lightning
                    setPack("3101" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "00000000000000000D00");
                    setPack("3103" + SkillID + CharID() + "FFFF" + getTargetSkillCoor() + "000000000000");
                    break;
                case "506"://Flame
                case "524":
                case "548":
                case "606"://İce
                case "624":
                case "648":
                case "612":
                case "630":
                case "654":
                case "706"://Lightning
                case "724":
                case "748":
                    setPSec("3101" + SkillID + CharID() + CharID() + "00000000000000000000000000000F00",1000,37);
                    setPSec("3103" + SkillID + CharID() + CharID() + "000000000000000000000000",1000,38);
                    break;
                case "001"://Stroke
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + "01000100000000000000000000000000");
                    break;

                default:
                    break;
            }
        }
        public void setMageSkillDown()
        {
            for (int i = 0; i <= MageSkill.Length; i++)
            {
                MageSkill[i] -= 1;
            }
        }
        public void attackMage(ListView lstview,bool areaSkill)
        {
            //R Atak
            if (lstview.Items[0].Checked && getTargetDistance() <= 15) { attackR(zTargetID, lstview.Items[0].SubItems[1].Text); }
            //###################################################################################################################################################
            //################### Area Skills ################### Area Skills ################### Area Skills ################### Area Skills ###################
            //###################################################################################################################################################
            if (areaSkill == true) // Alan atak aktifse
            {
                //Meteor Fall
                if (lstview.Items[58].Checked && CharMP() >= 600 && MageSkill[58] <= 0 && getTargetDistance() <= 23 && CharSkill(1) >= 70) { MageSkill[58] = 1900; useMageSkill(zTargetID, lstview.Items[58].SubItems[1].Text); return; }
                //Chain Lightning
                if (lstview.Items[64].Checked && CharMP() >= 600 && MageSkill[64] <= 0 && getTargetDistance() <= 23 && CharSkill(3) >= 70) { MageSkill[64] = 1900; useMageSkill(zTargetID, lstview.Items[64].SubItems[1].Text); return; }
                //Ice Storm
                if (lstview.Items[61].Checked && CharMP() >= 600 && MageSkill[61] <= 0 && getTargetDistance() <= 23 && CharSkill(2) >= 70) { MageSkill[61] = 1900; useMageSkill(zTargetID, lstview.Items[61].SubItems[1].Text); return; }
                //Super Nova
                if (lstview.Items[59].Checked && CharMP() >= 400 && MageSkill[59] <= 0 && getTargetDistance() <= 24 && CharSkill(1) >= 60) { MageSkill[59] = 1700; useMageSkill(zTargetID, lstview.Items[59].SubItems[1].Text); return; }
                //Static Nova
                if (lstview.Items[65].Checked && CharMP() >= 400 && MageSkill[65] <= 0 && getTargetDistance() <= 24 && CharSkill(3) >= 60) { MageSkill[65] = 1700; useMageSkill(zTargetID, lstview.Items[65].SubItems[1].Text); return; }
                //Frost Nova
                if (lstview.Items[62].Checked && CharMP() >= 400 && MageSkill[62] <= 0 && getTargetDistance() <= 24 && CharSkill(2) >= 60) { MageSkill[62] = 1700; useMageSkill(zTargetID, lstview.Items[62].SubItems[1].Text); return; }
                //Blizzard
                if (lstview.Items[63].Checked && CharMP() >= 200 && MageSkill[63] <= 0 && getTargetDistance() <= 24 && CharSkill(2) >= 45) { MageSkill[63] = 1700; useMageSkill(zTargetID, lstview.Items[63].SubItems[1].Text); return; }
                //Inferno
                if (lstview.Items[60].Checked && CharMP() >= 200 && MageSkill[60] <= 0 && getTargetDistance() <= 24 && CharSkill(1) >= 45) { MageSkill[60] = 1600; useMageSkill(zTargetID, lstview.Items[60].SubItems[1].Text); return; }
                //Thundercloud
                if (lstview.Items[66].Checked && CharMP() >= 200 && MageSkill[66] <= 0 && getTargetDistance() <= 24 && CharSkill(3) >= 45) { MageSkill[66] = 1700; useMageSkill(zTargetID, lstview.Items[66].SubItems[1].Text); return; }
                //Fire burst
                if (lstview.Items[55].Checked && CharMP() >= 0 && MageSkill[55] <= 0 && getTargetDistance() <= 24 && CharSkill(1) >= 33) { MageSkill[55] = 200; useMageSkill(zTargetID, lstview.Items[55].SubItems[1].Text); return; }
                //Ice burst
                if (lstview.Items[56].Checked && CharMP() >= 0 && MageSkill[56] <= 0 && getTargetDistance() <= 24 && CharSkill(2) >= 33) { MageSkill[56] = 200; useMageSkill(zTargetID, lstview.Items[56].SubItems[1].Text); return; }
                //Thunder burst
                if (lstview.Items[57].Checked && CharMP() >= 150 && MageSkill[57] <= 0 && getTargetDistance() <= 24 && CharSkill(3) >= 33) { MageSkill[57] = 200; useMageSkill(zTargetID, lstview.Items[57].SubItems[1].Text); return; }
            }
            //###########################################################################################################################################################
            //################### İce Skilleri ################### İce Skilleri ################### İce Skilleri ################### İce Skilleri #######################
            //###########################################################################################################################################################

            //Ice Blast
            if (lstview.Items[30].Checked && CharMP() >= 150 && MageSkill[30] <= 0 && getTargetDistance() <= 49 && CharSkill(2) >= 35) { MageSkill[30] = 490; useMageSkill(zTargetID, lstview.Items[30].SubItems[1].Text); return; } 
            //Frostbite
            if (lstview.Items[31].Checked && CharMP() >= 150 && MageSkill[31] <= 0 && getTargetDistance() <= 40 && CharSkill(2) >= 39) { MageSkill[31] = 490; useMageSkill(zTargetID, lstview.Items[31].SubItems[1].Text); return; } 
            //Ice Orb
            if (lstview.Items[29].Checked && CharMP() >= 80 && MageSkill[29] <= 0 && getTargetDistance() <= 49 && CharSkill(2) >= 27) { MageSkill[29] = 490; useMageSkill(zTargetID, lstview.Items[29].SubItems[1].Text); return; } 
            //Freezing Distance
            if (lstview.Items[39].Checked && CharMP() >= 350 && MageSkill[39] <= 0 && getTargetDistance() <= 40 && CharSkill(2) >= 80) { MageSkill[39] = 6100; useMageSkill(zTargetID, lstview.Items[39].SubItems[1].Text); return; } 
            //Prismatic
            if (lstview.Items[37].Checked && CharMP() >= 390 && MageSkill[37] <= 0 && getTargetDistance() <= 40 && CharSkill(2) >= 70) { MageSkill[37] = 2200; useMageSkill(zTargetID, lstview.Items[37].SubItems[1].Text); return; } 
            //Ice Impact
            if (lstview.Items[36].Checked && CharMP() >= 220 && MageSkill[36] <= 0 && getTargetDistance() <= 40 && CharSkill(2) >= 57) { MageSkill[36] = 2100; useMageSkill(zTargetID, lstview.Items[36].SubItems[1].Text); return; } 
            //Ice Comet
            if (lstview.Items[34].Checked && CharMP() >= 160 && MageSkill[34] <= 0 && getTargetDistance() <= 40 && CharSkill(2) >= 51) { MageSkill[34] = 600; useMageSkill(zTargetID, lstview.Items[34].SubItems[1].Text); return; } 
            //Ice Arrow
            if (lstview.Items[27].Checked && CharMP() >= 50 && MageSkill[27] <= 0 && getTargetDistance() <= 39 && CharSkill(2) >= 15) { MageSkill[27] = 590; useMageSkill(zTargetID, lstview.Items[27].SubItems[1].Text); return; } 
            //Chill
            if (lstview.Items[26].Checked && CharMP() >= 30 && MageSkill[26] <= 0 && getTargetDistance() <= 39 && CharSkill(2) >= 9) { MageSkill[26] = 600; useMageSkill(zTargetID, lstview.Items[26].SubItems[1].Text); return; } 
            //Ice Staff
            if (lstview.Items[38].Checked && CharMP() >= 300 && MageSkill[38] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 72) { MageSkill[38] = 0; useMageSkill(zTargetID, lstview.Items[38].SubItems[1].Text); return; } 
            //Manes of Ice
            if (lstview.Items[35].Checked && CharMP() >= 95 && MageSkill[35] <= 0 && getTargetDistance() <= 24 && CharSkill(2) >= 56) { MageSkill[35] = 0; useMageSkill(zTargetID, lstview.Items[35].SubItems[1].Text); return; } 
            //Specter of Ice
            if (lstview.Items[33].Checked && CharMP() >= 75 && MageSkill[33] <= 0 && getTargetDistance() <= 19 && CharSkill(2) >= 43) { MageSkill[33] = 0; useMageSkill(zTargetID, lstview.Items[33].SubItems[1].Text); return; } 
            //Solid
            if (lstview.Items[28].Checked && CharMP() >= 60 && MageSkill[28] <= 0 && getTargetDistance() <= 42 && CharSkill(2) >= 18) { MageSkill[28] = 0; useMageSkill(zTargetID, lstview.Items[28].SubItems[1].Text); return; } 
            //Frozen Blade
            if (lstview.Items[32].Checked && CharMP() >= 100 && MageSkill[32] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 42) { MageSkill[32] = 0; useMageSkill(zTargetID, lstview.Items[32].SubItems[1].Text); return; } 
            //Freeze
            if (lstview.Items[25].Checked && CharMP() >= 20 && MageSkill[25] <= 0 && getTargetDistance() <= 19 && CharSkill(2) >= 3) { MageSkill[25] = 0; useMageSkill(zTargetID, lstview.Items[25].SubItems[1].Text); return; } 


            //###########################################################################################################################################################
            //################# Flame Skilleri ################# Flame Skilleri ################# Flame Skilleri ################# Flame Skilleri #######################
            //###########################################################################################################################################################

            //Blaze
            if (lstview.Items[9].Checked && CharMP() >= 30 && MageSkill[9] <= 0 && getTargetDistance() <= 24 && CharSkill(1) >= 9) { MageSkill[9] = 600; useMageSkill(zTargetID, lstview.Items[9].SubItems[1].Text); return; } 
            //Fire Ball
            if (lstview.Items[10].Checked && CharMP() >= 50 && MageSkill[10] <= 0 && getTargetDistance() <= 23 && CharSkill(1) >= 15) { MageSkill[10] = 590; useMageSkill(zTargetID, lstview.Items[10].SubItems[1].Text); return; } 
            //Fire Thorn
            if (lstview.Items[18].Checked && CharMP() >= 220 && getInvSlot(379061000) > -1 && MageSkill[18] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 54) { MageSkill[18] = 700; useMageSkill(zTargetID, lstview.Items[18].SubItems[1].Text); return; } 
            //Pillar of Fire
            if (lstview.Items[17].Checked && CharMP() >= 160 && MageSkill[17] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 51) { MageSkill[17] = 600; useMageSkill(zTargetID, lstview.Items[17].SubItems[1].Text); return; } 
            //Fire Spear
            if (lstview.Items[12].Checked && CharMP() >= 80 && MageSkill[12] <= 0 && getTargetDistance() <= 49 && CharSkill(1) >= 27) { MageSkill[12] = 490; useMageSkill(zTargetID, lstview.Items[12].SubItems[1].Text); return; } 
            //Fire Blast
            if (lstview.Items[13].Checked && CharMP() >= 150 && MageSkill[13] <= 0 && getTargetDistance() <= 49 && CharSkill(1) >= 35) { MageSkill[13] = 490; useMageSkill(zTargetID, lstview.Items[13].SubItems[1].Text); return; } 
            //Hell Fire
            if (lstview.Items[14].Checked && CharMP() >= 150 && MageSkill[14] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 39) { MageSkill[14] = 490; useMageSkill(zTargetID, lstview.Items[14].SubItems[1].Text); return; } 
            //Vampiric Fire
            if (lstview.Items[23].Checked && CharMP() >= 350 && MageSkill[23] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 80) { MageSkill[23] = 6100; useMageSkill(zTargetID, lstview.Items[23].SubItems[1].Text); return; } 
            //Igzination
            if (lstview.Items[24].Checked && CharMP() >= 390 && MageSkill[24] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 80) { MageSkill[24] = 2200; useMageSkill(zTargetID, lstview.Items[24].SubItems[1].Text); return; } 
            //Fire Impact
            if (lstview.Items[20].Checked && CharMP() >= 220 && MageSkill[20] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 57) { MageSkill[20] = 2100; useMageSkill(zTargetID, lstview.Items[20].SubItems[1].Text); return; } 
            //Incineration
            if (lstview.Items[21].Checked && CharMP() >= 390 && MageSkill[21] <= 0 && getTargetDistance() <= 40 && CharSkill(1) >= 70) { MageSkill[21] = 2200; useMageSkill(zTargetID, lstview.Items[21].SubItems[1].Text); return; } 
            //Fire Blade
            if (lstview.Items[15].Checked && CharMP() >= 100 && MageSkill[15] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 42) { MageSkill[15] = 0; useMageSkill(zTargetID, lstview.Items[15].SubItems[1].Text); return; } 
            //Manes of Fire
            if (lstview.Items[19].Checked && CharMP() >= 95 && MageSkill[19] <= 0 && getTargetDistance() <= 24 && CharSkill(1) >= 56) { MageSkill[19] = 0; useMageSkill(zTargetID, lstview.Items[19].SubItems[1].Text); return; } 
            //Specter of Fire
            if (lstview.Items[16].Checked && CharMP() >= 75 && MageSkill[16] <= 0 && getTargetDistance() <= 19 && CharSkill(1) >= 43) { MageSkill[16] = 0; useMageSkill(zTargetID, lstview.Items[16].SubItems[1].Text); return; } 
            //Fire Staff
            if (lstview.Items[22].Checked && CharMP() >= 300 && MageSkill[22] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 72) { MageSkill[22] = 0; useMageSkill(zTargetID, lstview.Items[22].SubItems[1].Text); return; } 
            //Ignition
            if (lstview.Items[11].Checked && CharMP() >= 60 && MageSkill[11] <= 0 && getTargetDistance() <= 42 && CharSkill(1) >= 18) { MageSkill[11] = 0; useMageSkill(zTargetID, lstview.Items[11].SubItems[1].Text); return; } 
            //Burn
            if (lstview.Items[8].Checked && CharMP() >= 20 && MageSkill[8] <= 0 && getTargetDistance() <= 19 && CharSkill(1) >= 3) { MageSkill[8] = 0; useMageSkill(zTargetID, lstview.Items[8].SubItems[1].Text); return; } 

            //###########################################################################################################################################################
            //################### Lig Skilleri ################### Lig Skilleri ################### Lig Skilleri ################### Lig Skilleri #######################
            //###########################################################################################################################################################
            //Thunder Impact
            if (lstview.Items[52].Checked && CharMP() >= 220 && MageSkill[52] <= 0 && getTargetDistance() <= 40 && CharSkill(3) >= 57) { MageSkill[52] = 2100; useMageSkill(zTargetID, lstview.Items[52].SubItems[1].Text); return; } 
            //Stun Cloud
            if (lstview.Items[53].Checked && CharMP() >= 390 && MageSkill[53] <= 0 && getTargetDistance() <= 40 && CharSkill(3) >= 70) { MageSkill[53] = 2200; useMageSkill(zTargetID, lstview.Items[53].SubItems[1].Text); return; } 
            //Static Orb
            if (lstview.Items[49].Checked && CharMP() >= 160 && MageSkill[49] <= 0 && getTargetDistance() <= 40 && CharSkill(3) >= 51) { MageSkill[49] = 600; useMageSkill(zTargetID, lstview.Items[49].SubItems[1].Text); return; } 
            //Static Thorn
            if (lstview.Items[50].Checked && CharMP() >= 220 && getInvSlot(379061000) > -1 && MageSkill[50] <= 0 && getTargetDistance() <= 40 && CharSkill(3) >= 54) { MageSkill[50] = 700; useMageSkill(zTargetID, lstview.Items[50].SubItems[1].Text); return; } 
            //Counter Spell
            if (lstview.Items[41].Checked && CharMP() >= 30 && MageSkill[41] <= 0 && getTargetDistance() <= 39 && CharSkill(3) >= 9) { MageSkill[41] = 600; useMageSkill(zTargetID, lstview.Items[41].SubItems[1].Text); return; } 
            //Lightning
            if (lstview.Items[42].Checked && CharMP() >= 50 && MageSkill[42] <= 0 && getTargetDistance() <= 49 && CharSkill(3) >= 15) { MageSkill[42] = 590; useMageSkill(zTargetID, lstview.Items[42].SubItems[1].Text); return; } 
            //Thunder
            if (lstview.Items[44].Checked && CharMP() >= 80 && MageSkill[44] <= 0 && getTargetDistance() <= 49 && CharSkill(3) >= 27) { MageSkill[44] = 490; useMageSkill(zTargetID, lstview.Items[44].SubItems[1].Text); return; } 
            //Thunder Blast
            if (lstview.Items[45].Checked && CharMP() >= 150 && MageSkill[45] <= 0 && getTargetDistance() <= 49 && CharSkill(3) >= 35) { MageSkill[45] = 490; useMageSkill(zTargetID, lstview.Items[45].SubItems[1].Text); return; } 
            //Discharge
            if (lstview.Items[46].Checked && CharMP() >= 150 && MageSkill[46] <= 0 && getTargetDistance() <= 49 && CharSkill(3) >= 39) { MageSkill[46] = 490; useMageSkill(zTargetID, lstview.Items[46].SubItems[1].Text); return; } 
            //Manes of Thunder
            if (lstview.Items[51].Checked && CharMP() >= 95 && MageSkill[51] <= 0 && getTargetDistance() <= 24 && CharSkill(3) >= 56) { MageSkill[51] = 0; useMageSkill(zTargetID, lstview.Items[51].SubItems[1].Text); return; } 
            //Specter of Thunder
            if (lstview.Items[48].Checked && CharMP() >= 75 && MageSkill[48] <= 0 && getTargetDistance() <= 19 && CharSkill(3) >= 43) { MageSkill[48] = 0; useMageSkill(zTargetID, lstview.Items[48].SubItems[1].Text); return; } 
            //Static Hemispher
            if (lstview.Items[43].Checked && CharMP() >= 60 && MageSkill[43] <= 0 && getTargetDistance() <= 42 && CharSkill(3) >= 18) { MageSkill[43] = 0; useMageSkill(zTargetID, lstview.Items[43].SubItems[1].Text); return; } 
            //Charge
            if (lstview.Items[40].Checked && CharMP() >= 20 && MageSkill[40] <= 0 && getTargetDistance() <= 19 && CharSkill(3) >= 3) { MageSkill[40] = 0; useMageSkill(zTargetID, lstview.Items[40].SubItems[1].Text); return; } 
            //Charged Blade
            if (lstview.Items[47].Checked && CharMP() >= 100 && MageSkill[47] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 42) { MageSkill[47] = 0; useMageSkill(zTargetID, lstview.Items[47].SubItems[1].Text); return; } 
            //Light Staff
            if (lstview.Items[54].Checked && CharMP() >= 300 && MageSkill[54] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 72) { MageSkill[54] = 0; useMageSkill(zTargetID, lstview.Items[54].SubItems[1].Text); return; } 

            //###########################################################################################################################################################
            //################## Basic Skilleri ################## Basic Skilleri ################## Basic Skilleri ################## Basic Skilleri ###################
            //###########################################################################################################################################################

            //Stroke
            if (lstview.Items[1].Checked && CharMP() >= 2 && MageSkill[1] <= 0 && getTargetDistance() <= 15 && CharLevel() >= 0) { MageSkill[1] = 0; useMageSkill(zTargetID, lstview.Items[1].SubItems[1].Text); return; } 
            //Flash
            if (lstview.Items[2].Checked && CharMP() >= 4 && MageSkill[2] <= 0 && getTargetDistance() <= 39 && CharLevel() >= 1) { MageSkill[2] = 490; useMageSkill(zTargetID, lstview.Items[2].SubItems[1].Text); return; } 
            //Shiver
            if (lstview.Items[3].Checked && CharMP() >= 5 && MageSkill[3] <= 0 && getTargetDistance() <= 39 && CharLevel() >= 3) { MageSkill[3] = 490; useMageSkill(zTargetID, lstview.Items[3].SubItems[1].Text); return; } 
            //Flame
            if (lstview.Items[4].Checked && CharMP() >= 5 && MageSkill[4] <= 0 && getTargetDistance() <= 39 && CharLevel() >= 5) { MageSkill[4] = 490; useMageSkill(zTargetID, lstview.Items[4].SubItems[1].Text); return; } 
            //Cold Wave
            if (lstview.Items[5].Checked && CharMP() >= 7 && MageSkill[5] <= 0 && getTargetDistance() <= 39 && CharLevel() >= 7) { MageSkill[5] = 490; useMageSkill(zTargetID, lstview.Items[5].SubItems[1].Text); return; } 
            //Spark
            if (lstview.Items[6].Checked && CharMP() >= 15 && MageSkill[6] <= 0 && getTargetDistance() <= 39 && CharLevel() >= 9) { MageSkill[6] = 500; useMageSkill(zTargetID, lstview.Items[6].SubItems[1].Text); return; } 
            //Magic Blade
            if (lstview.Items[7].Checked && CharMP() >= 10 && MageSkill[7] <= 0 && getTargetDistance() <= 14 && CharLevel() >= 9) { MageSkill[7] = 0; useMageSkill(zTargetID, lstview.Items[7].SubItems[1].Text); return; } 
        }
        public void skillMageTime(ListView lstview)
        {
            if(getSkillControl("506") == false && getSkillControl("524") == false && getSkillControl("548") == false && getSkillControl("606") == false && getSkillControl("624") == false && getSkillControl("648") == false && getSkillControl("706") == false && getSkillControl("724") == false && getSkillControl("748") == false)
            {
                //Resist fire
                if (lstview.Items[67].Checked && CharMP() >= 15 && CharSkill(1) >= 6) { useMageSkill(1, lstview.Items[67].SubItems[1].Text); return; }
                //Endure fire
                if (lstview.Items[68].Checked && CharMP() >= 50 && CharSkill(1) >= 24) { useMageSkill(1, lstview.Items[68].SubItems[1].Text); return; }
                //Immunity fire
                if (lstview.Items[69].Checked && CharMP() >= 80 && CharSkill(1) >= 48) { useMageSkill(1, lstview.Items[69].SubItems[1].Text); return; }

                //Resist cold
                if (lstview.Items[70].Checked && CharMP() >= 15 && CharSkill(2) >= 6) { useMageSkill(1, lstview.Items[70].SubItems[1].Text); return; }
                //Endure cold
                if (lstview.Items[72].Checked && CharMP() >= 50 && CharSkill(2) >= 24) { useMageSkill(1, lstview.Items[72].SubItems[1].Text); return; }
                //Immunity cold
                if (lstview.Items[74].Checked && CharMP() >= 80 && CharSkill(2) >= 48) { useMageSkill(1, lstview.Items[74].SubItems[1].Text); return; }

                //Resist lightning
                if (lstview.Items[76].Checked && CharMP() >= 15 && CharSkill(3) >= 6) { useMageSkill(1, lstview.Items[76].SubItems[1].Text); return; }
                //Endure lightning
                if (lstview.Items[77].Checked && CharMP() >= 50 && CharSkill(3) >= 24) { useMageSkill(1, lstview.Items[77].SubItems[1].Text); return; }
                //Immunity lightning
                if (lstview.Items[78].Checked && CharMP() >= 80 && CharSkill(3) >= 48) { useMageSkill(1, lstview.Items[78].SubItems[1].Text); return; } 
            }
            if(getSkillControl("612") == false && getSkillControl("630") == false && getSkillControl("654") == false)
            {
                //Frozen Armor
                if (lstview.Items[71].Checked && CharMP() >= 40 && CharSkill(2) >= 12) { useMageSkill(1, lstview.Items[71].SubItems[1].Text); return; }
                //Frozen shell
                if (lstview.Items[73].Checked && CharMP() >= 80 && CharSkill(2) >= 30) { useMageSkill(1, lstview.Items[73].SubItems[1].Text); return; }
                //Ice barrier
                if (lstview.Items[75].Checked && CharMP() >= 120 && CharSkill(2) >= 54) { useMageSkill(1, lstview.Items[75].SubItems[1].Text); return; } 
            }
        }
        #endregion
        //#########################################################################################
        #region Priest Skill System
        public void setPriestSkillDown()
        {
            for (int i = 0; i <= PriestSkill.Length; i++)
            {
                PriestSkill[i] -= 1;
            }
        }
        public void useStrength()
        {
            if (getSkillControl("004") == false && getSkillControl("529") == false && getSkillControl("629") == false && getSkillControl("729") == false)
            {
                setPSec("3101" + Adword(getSkillID(CharClass(), "004"), 4) + CharID() + CharID() + "00000000000000000000000000000F00", 1000, 39);
                setPSec("3103" + Adword(getSkillID(CharClass(), "004"), 4) + CharID() + CharID() + "0000000000000000000000000000", 1000, 40);
            }
        }
        public void useBlasting()
        {
            if (getSkillControl("004") == false && getSkillControl("529") == false && getSkillControl("629") == false && getSkillControl("729") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "529"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 41);
            }
        }
        public void useWildness()
        {
            if (getSkillControl("004") == false && getSkillControl("529") == false && getSkillControl("629") == false && getSkillControl("729") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "629"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 42);
            }
        }
        public void useEruption()
        {
            if (getSkillControl("004") == false && getSkillControl("529") == false && getSkillControl("629") == false && getSkillControl("729") == false)
            {
                setPSec("3103" + Adword(getSkillID(CharClass(), "729"), 4) + CharID() + CharID() + "000000000000000000000000", 1000, 43);
            }
        }
        public void usePowerBook()
        {
            if (getSkillControl("026") == false && getSkillControl("030") == false)
            {
                setPSec("3103" + Adword(490026, 4) + CharID() + CharID() + "00000000000000000000000000000000", 1000, 44);
            }
        }
        public void setPriestSkill(int TargetID,string SkillNumber)
        {
            string SkillID = Adword(getSkillID(CharClass(), SkillNumber),4);
            switch (SkillNumber)
            {
                case "703":
                case "709":
                case "715":
                case "724":
                case "730":
                case "736":
                case "745":
                case "760":
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + "00000000000000000000000000000F00");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    break;
                case "751":
                case "757":
                    setPack("3101" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "00000000000000000F00");
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + getTargetSkillCoor() + "000000000000");
                    break;
                default:
                    setPack("3103" + SkillID + CharID() + Adword(TargetID, 2) + "01000100000000000000000000000000");
                    break;
            }
        }
        public void skillPriestTime(ListView lstview)
        {
            
            //Prayer of god's power
            if (lstview.Items[18].Checked && CharMP() >= 30 && CharStat(1) >= 85) { usePowerBook(); return; }
            //Strength packets
            if (getSkillControl("004") == false && getSkillControl("529") == false && getSkillControl("629") == false && getSkillControl("729") == false)
            {
                //Blasting
                if (lstview.Items[19].Checked && CharMP() >= 80 && CharSkill(1) >= 30) { useBlasting(); return; }
                //Wildness
                if (lstview.Items[20].Checked && CharMP() >= 80 && CharSkill(2) >= 30) { useWildness(); return; }
                //Eruption
                if (lstview.Items[21].Checked && CharMP() >= 80 && CharSkill(3) >= 30) { useEruption(); return; }
                //Strength
                if (lstview.Items[17].Checked && CharMP() >= 10 && CharLevel() >= 10) { useStrength(); return; }
                
            }
        }
        public void attackPriest(ListView lstview)
        {
            //R Atak
            if (lstview.Items[0].Checked && CharMP() >= 0 && PriestSkill[0] <= 0 && getTargetDistance() <= 14 && CharLevel() >= 0) { PriestSkill[0] = 0; attackR(zTargetID, lstview.Items[0].SubItems[1].Text); return; }

            //Hellish
            if (lstview.Items[6].Checked && CharMP() >= 120 && PriestSkill[6] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 51) { PriestSkill[6] = 300; setPriestSkill(zTargetID, lstview.Items[6].SubItems[1].Text); return; }
            //Collapse
            if (lstview.Items[10].Checked && CharMP() >= 120 && PriestSkill[10] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 51) { PriestSkill[10] = 300; setPriestSkill(zTargetID, lstview.Items[10].SubItems[1].Text); return; }
            //Hades
            if (lstview.Items[14].Checked && CharMP() >= 120 && PriestSkill[14] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 51) { PriestSkill[14] = 300; setPriestSkill(zTargetID, lstview.Items[14].SubItems[1].Text); return; }
            //Ruin
            if (lstview.Items[5].Checked && CharMP() >= 100 && PriestSkill[5] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 42) { PriestSkill[5] = 200; setPriestSkill(zTargetID, lstview.Items[5].SubItems[1].Text); return; }
            //Raving Edge
            if (lstview.Items[13].Checked && CharMP() >= 100 && PriestSkill[13] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 39) { PriestSkill[13] = 200; setPriestSkill(zTargetID, lstview.Items[13].SubItems[1].Text); return; }
            //Harsh
            if (lstview.Items[9].Checked && CharMP() >= 100 && PriestSkill[9] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 42) { PriestSkill[9] = 200; setPriestSkill(zTargetID, lstview.Items[9].SubItems[1].Text); return; }

            //Helis
            if (lstview.Items[16].Checked && CharMP() >= 350 && PriestSkill[16] <= 0 && getTargetDistance() <= 14 && CharSkill(4) >= 12) { PriestSkill[16] = 0; setPriestSkill(zTargetID, lstview.Items[16].SubItems[1].Text); return; }
            //Judgment
            if (lstview.Items[15].Checked && CharMP() >= 200 && PriestSkill[15] <= 0 && getTargetDistance() <= 14 && CharSkill(4) >= 2) { PriestSkill[15] = 0; setPriestSkill(zTargetID, lstview.Items[15].SubItems[1].Text); return; }

            //Shuddering
            if (lstview.Items[4].Checked && CharMP() >= 40 && PriestSkill[4] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 21) { PriestSkill[4] = 0; setPriestSkill(zTargetID, lstview.Items[4].SubItems[1].Text); return; }
            //Wield
            if (lstview.Items[8].Checked && CharMP() >= 40 && PriestSkill[8] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 21) { PriestSkill[8] = 0; setPriestSkill(zTargetID, lstview.Items[8].SubItems[1].Text); return; }
            //Bloody
            if (lstview.Items[12].Checked && CharMP() >= 40 && PriestSkill[12] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 21) { PriestSkill[12] = 0; setPriestSkill(zTargetID, lstview.Items[12].SubItems[1].Text); return; }
            //Collision
            if (lstview.Items[3].Checked && CharMP() >= 30 && PriestSkill[3] <= 0 && getTargetDistance() <= 14 && CharSkill(1) >= 12) { PriestSkill[3] = 0; setPriestSkill(zTargetID, lstview.Items[3].SubItems[1].Text); return; }
            //Wrath
            if (lstview.Items[7].Checked && CharMP() >= 30 && PriestSkill[7] <= 0 && getTargetDistance() <= 14 && CharSkill(2) >= 12) { PriestSkill[7] = 0; setPriestSkill(zTargetID, lstview.Items[7].SubItems[1].Text); return; }
            //Tilt
            if (lstview.Items[11].Checked && CharMP() >= 30 && PriestSkill[11] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 12) { PriestSkill[11] = 0; setPriestSkill(zTargetID, lstview.Items[11].SubItems[1].Text); return; }
            //Holy Attack
            if (lstview.Items[2].Checked && CharMP() >= 0 && PriestSkill[2] <= 0 && getTargetDistance() <= 14 && CharLevel() >= 1) { PriestSkill[2] = 0; setPriestSkill(zTargetID, lstview.Items[2].SubItems[1].Text); return; }
            //Stroke
            if (lstview.Items[1].Checked && CharMP() >= 0 && PriestSkill[1] <= 0 && getTargetDistance() <= 14 && CharLevel() >= 1) { PriestSkill[1] = 0; setPriestSkill(zTargetID, lstview.Items[1].SubItems[1].Text); return; }



            //Malice
            if (lstview.Items[22].Checked && CharMP() >= 40 && PriestSkill[22] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 3) { PriestSkill[22] = 800; setPriestSkill(zTargetID, lstview.Items[22].SubItems[1].Text); return; }
            //Clear mana
            if (lstview.Items[23].Checked && CharMP() >= 80 && PriestSkill[23] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 9) { PriestSkill[23] = 800; setPriestSkill(zTargetID, lstview.Items[23].SubItems[1].Text); return; }
            //Confusion
            if (lstview.Items[24].Checked && CharMP() >= 80 && PriestSkill[24] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 15) { PriestSkill[24] = 800; setPriestSkill(zTargetID, lstview.Items[24].SubItems[1].Text); return; }
            //Slow
            if (lstview.Items[25].Checked && CharMP() >= 120 && PriestSkill[25] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 24) { PriestSkill[25] = 800; setPriestSkill(zTargetID, lstview.Items[25].SubItems[1].Text); return; }
            //Reverse life
            if (lstview.Items[26].Checked && CharMP() >= 50 && PriestSkill[26] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 27) { PriestSkill[26] = 1000; setPriestSkill(zTargetID, lstview.Items[26].SubItems[1].Text); return; }
            //Sleep Wing
            if (lstview.Items[27].Checked && CharMP() >= 120 && PriestSkill[27] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 30) { PriestSkill[27] = 800; setPriestSkill(zTargetID, lstview.Items[27].SubItems[1].Text); return; }
            //Sweep mana
            if (lstview.Items[28].Checked && CharMP() >= 160 && PriestSkill[28] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 36) { PriestSkill[28] = 800; setPriestSkill(zTargetID, lstview.Items[28].SubItems[1].Text); return; }
            //Parasite
            if (lstview.Items[29].Checked && CharMP() >= 100 && PriestSkill[29] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 45) { PriestSkill[29] = 800; setPriestSkill(zTargetID, lstview.Items[29].SubItems[1].Text); return; }
            //Sleep Carpet
            if (lstview.Items[30].Checked && CharMP() >= 240 && PriestSkill[30] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 51) { PriestSkill[30] = 1000; setPriestSkill(zTargetID, lstview.Items[30].SubItems[1].Text); return; }
            //Torment
            if (lstview.Items[31].Checked && CharMP() >= 150 && PriestSkill[31] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 57) { PriestSkill[31] = 1000; setPriestSkill(zTargetID, lstview.Items[31].SubItems[1].Text); return; }
            //Massive
            if (lstview.Items[32].Checked && CharMP() >= 180 && PriestSkill[32] <= 0 && getTargetDistance() <= 14 && CharSkill(3) >= 60) { PriestSkill[32] = 1100; setPriestSkill(zTargetID, lstview.Items[32].SubItems[1].Text); return; } 

        }
        #endregion
        //#########################################################################################
        #region Party Skill System
        public void setPartySkill(int TargetID,string SkillNumber)
        {
            string SkillIDPerson = Adword(getSkillID(CharClass(), SkillNumber), 4) + CharID() + Adword(TargetID, 2) + "000000000000";
            string SkillIDGroup = Adword(getSkillID(CharClass(), SkillNumber), 4) + CharID() + "FFFF" + getCharSkillCoor();
            switch (SkillNumber)
            {
                case "500":
                case "509":
                case "518":
                case "527":
                case "536":
                case "545":
                case "503":
                case "512":
                case "521":
                case "530":
                case "539":
                case "548":
                case "575":
                case "580":
                case "606":
                case "615":
                case "624":
                case "633":
                case "643":
                case "654":
                case "655":
                case "657":
                case "678":
                case "603":
                case "612":
                case "621":
                case "630":
                case "639":
                case "651":
                case "660":
                case "676":
                case "609":
                case "627":
                case "636":
                case "645":
                case "525":
                case "535":
                case "554":
                case "004":
                    setPriestSec(SkillIDPerson, 200, Convert.ToInt32(SkillNumber));
                    break;
                case "656":
                case "570":
                case "670":
                case "557":
                case "560":
                    setPriestSec(SkillIDGroup, 200, Convert.ToInt32(SkillNumber));
                    break;
                default:
                    break;
            }

        }
        public void partyMinor(bool Minor)
        {
            if (Minor == false) { return; }
            getPartyInformation();
            for (int i = 0; i <= getPartyCount(); i++)
            {
                if(PartyUserMaxHP[i] - PartyUserHP[i] >= 60)
                {
                    useMinor(PartyUserID[i]);
                }
            }
        }
        #endregion  
    }
}
