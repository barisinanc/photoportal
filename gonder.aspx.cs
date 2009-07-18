using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class gonder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Upload1_Load(object sender, EventArgs e)
    {
        Upload1.UploadText = "Gönder";
        Upload1.ClearText = "Temizle";
        Upload1.BrowseText = "Dosyaları Seç";
        Upload1.OverallProgressText = "Toplam İşlem";
        Upload1.FileProgressText = "Dosya İşlemi";
    }
    protected void Upload1_FileReceived(object sender, SharpPieces.Web.Controls.UploadEventArgs e)
    {
        string ad = RandomString(10) + e.File.FileName.Substring(e.File.FileName.LastIndexOf("."), (e.File.FileName.Length - e.File.FileName.LastIndexOf("."))).ToLower();
        e.File.SaveAs(Server.MapPath("icerik/foto/") + ad);
        //System.IO.File.Copy(Server.MapPath("icerik/foto/") + ad, Server.MapPath("icerik/mini/") + ad);
        System.Drawing.Image resim = System.Drawing.Image.FromFile(Server.MapPath("icerik/foto/") + ad);
        if (resim.Width > resim.Height)
        { resim = resim.GetThumbnailImage(100, resim.Height / (resim.Width / 100), null, new IntPtr()); }
        else
        { resim = resim.GetThumbnailImage(resim.Width / (resim.Height / 100), 100, null, new IntPtr()); }
        foto.SaveJpeg(Server.MapPath("icerik/mini/") + ad, resim, 100);
        //resim.Save(Server.MapPath("icerik/mini/") + ad, resim.RawFormat);
        veriDataContext veri = new veriDataContext();
        fotograf yenifoto = new fotograf();
        yenifoto.kul_id = 1;
        yenifoto.ad = e.File.FileName.Remove(e.File.FileName.LastIndexOf("."), (e.File.FileName.Length - e.File.FileName.LastIndexOf(".")));
        yenifoto.tarih = DateTime.Now;
        yenifoto.album_id = 2;
        yenifoto.dosya = ad;
        veri.fotografs.InsertOnSubmit(yenifoto);
        veri.SubmitChanges();
    }
    private string RandomString(int size)
    {

        StringBuilder sb = new StringBuilder();
        Random randomObj = new Random(Convert.ToInt32(Guid.NewGuid().ToByteArray()[6]));
        char randChar;

        for (int i = 0; i < size; i++)
        {

            int rand = Convert.ToInt32(Math.Floor(74 * randomObj.NextDouble() + 48));
            if (rand > 57 && rand < 65)
                rand = 65 + (rand - 57);
            else if (rand > 90 && rand < 97)
                rand = 97 + (rand - 90);
            randChar = Convert.ToChar(rand);
            sb.Append(randChar);

        }

        return sb.ToString();

    }
}
