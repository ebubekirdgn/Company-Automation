using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace Otomasyon.Fonksiyonlar
{
    class Formlar
    {

        #region Stok Formları
        public int StokListesi(bool Secim = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();

            if (Secim)
            {
                frm.secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
            return AnaForm.Aktar;
        }
        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktar;
        }
        public void StokHareketleri(bool Ac = false)
        {

        }
        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.DaofrmStokKarti frm = new Modul_Stok.DaofrmStokKarti();
            frm.ShowDialog();

        } 
        #endregion

        #region Cari Formları
        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new Modul_Cari.frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktar;
        }

        public int CariListesi(bool Secim =false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            if(Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktar;
        }

        public void CariAcilisKarti(bool Ac = false , int CariID =-1)
        {
            Modul_Cari.DaoCariAcilisKarti frm = new Modul_Cari.DaoCariAcilisKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();


        }

        #endregion

        #region Kasa Formları
        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmKasaAcilisKarti frm = new Modul_Kasa.frmKasaAcilisKarti();
            frm.ShowDialog();
        }
       
        public int  KasaListesi(bool Secim = false)
        {
            Modul_Kasa.frmKasaListesi frm = new Modul_Kasa.frmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }

            return AnaForm.Aktar;
        }
        public void KasaTahsilatOdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaTahsilatOdeme frm = new Modul_Kasa.frmKasaTahsilatOdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();

        }
        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaHareketleri frm = new Modul_Kasa.frmKasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.Show();
        }
        #endregion

        #region Banka Formları
        public void BankaAcilisKarti()
        {
            Modul_Banka.DaofrmBankaAcilisKarti frm = new Modul_Banka.DaofrmBankaAcilisKarti();
            frm.ShowDialog();
        }

        public void BankaIslem(bool Ac = false, int ID = -1)
        {
            Modul_Banka.frmBankaIslem frm = new Modul_Banka.frmBankaIslem();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public int BankaListesi(bool Secim = false)
        {

            Modul_Banka.frmBankaListesi frm = new Modul_Banka.frmBankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktar;
        }


        
        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Banka.frmBankaHareketleri frm = new Modul_Banka.frmBankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();
        }
        #endregion
       
        

        public void Fatura(bool Ac= false ,int  ID = -1 ,bool Irsaliye =false)
        {
            Modul_Fatura.DaoSatisFaturasi frm= new Modul_Fatura.DaoSatisFaturasi(Ac, ID, Irsaliye);
    
            frm.MdiParent = AnaForm.ActiveForm;
            frm.Show();
        }

        public void FaturaListesi(bool Secim = false)
        {
            Modul_Fatura.frmFaturaListesi frm = new Modul_Fatura.frmFaturaListesi(Secim);
            if (Secim) frm.ShowDialog();
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
        }

        public void KullaniciYonetimi()
        {
            Modul_Kullanici.frmKullaniciYonetimi frm = new Modul_Kullanici.frmKullaniciYonetimi();
            frm.ShowDialog();
        }

        public void KullaniciPanel(bool ac = false, int ID= -1)
        {
            Modul_Kullanici.frmKullaniciPanel frm = new Modul_Kullanici.frmKullaniciPanel(ID,ac);
            frm.ShowDialog();

        }
    }
}
