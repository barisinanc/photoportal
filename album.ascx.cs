using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Drawing;

public partial class album : System.Web.UI.UserControl
{
    private List<int> _secilen = new List<int>();
    private int _adet;

    #region Ozellikler

    public List<int> Secilen
    {
        get { return _secilen; }
        set { _secilen = value; }
    }

    
    public int Adet
    {
        get { return _adet; }
        set { _adet = value; }
    }
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Doldur();
        }
    }

    protected void Doldur()
    {
        ListView1.GroupItemCount = Adet;
        veriDataContext veri = new veriDataContext();
        var sorgu = from x in veri.fotografs
                    select x;
        ListView1.DataSource = sorgu;
        ListView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach (var nesne in ListView1.Items)
        {
            var checkbox = (CheckBox)nesne.FindControl("sec");
            var id = (Label)nesne.FindControl("id");
            if (checkbox.Checked)
            { Secilen.Add(Convert.ToInt32(id.Text)); }
        }
    }
    protected void Sil_Click(object sender, EventArgs e)
    {
        foreach (var nesne in ListView1.Items)
        {
            var checkbox = (CheckBox)nesne.FindControl("sec");
            var id = (Label)nesne.FindControl("id");
            if (checkbox.Checked)
            {
                veriDataContext veri = new veriDataContext();
                var sorgu = from x in veri.fotografs
                            where x.id == Convert.ToInt32(id.Text)
                            select x;
                if (sorgu.Count() != 0)
                {
                    string yol = Server.MapPath("icerik/foto/" + sorgu.First().dosya);
                    File.Delete(yol);
                    veri.fotografs.DeleteOnSubmit(sorgu.First());
                    veri.SubmitChanges();
                }
            }
        }
        Doldur();
    }


    protected void CevirSol_Click(object sender, EventArgs e)
    {
        foreach (var nesne in ListView1.Items)
        {
            var checkbox = (CheckBox)nesne.FindControl("sec");
            var id = (Label)nesne.FindControl("id");
            if (checkbox.Checked)
            {
                veriDataContext veri = new veriDataContext();
                var sorgu = from x in veri.fotografs
                            where x.id == Convert.ToInt32(id.Text)
                            select x;
                if (sorgu.Count() != 0)
                {
                    string yol = Server.MapPath("icerik/foto/" + sorgu.First().dosya);
                    
                    System.Drawing.Image resim = foto.oku(yol);
                    resim.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    foto.SaveJpeg(yol, resim, 100);
                    //resim.Save(yol);
                    resim.Dispose();
                    resim = null;
                    
                    yol = Server.MapPath("icerik/mini/" + sorgu.First().dosya);


                    resim = foto.oku(yol);
                    resim.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    foto.SaveJpeg(yol, resim, 100);
                    //resim.Save(yol);
                    resim.Dispose();
                    resim = null;
                    
                    
                }
            }
        }
        Doldur();
    }
    protected void CevirSag_Click(object sender, EventArgs e)
    {
        foreach (var nesne in ListView1.Items)
        {
            var checkbox = (CheckBox)nesne.FindControl("sec");
            var id = (Label)nesne.FindControl("id");
            if (checkbox.Checked)
            {
                veriDataContext veri = new veriDataContext();
                var sorgu = from x in veri.fotografs
                            where x.id == Convert.ToInt32(id.Text)
                            select x;
                if (sorgu.Count() != 0)
                {
                    string yol = Server.MapPath("icerik/foto/" + sorgu.First().dosya);

                    System.Drawing.Image resim = foto.oku(yol);
                    resim.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    foto.SaveJpeg(yol, resim, 100);
                    //resim.Save(yol,System.Drawing.Imaging.ImageFormat.Jpeg);
                    resim.Dispose();
                    resim = null;

                    yol = Server.MapPath("icerik/mini/" + sorgu.First().dosya);


                    resim = foto.oku(yol);
                    resim.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    foto.SaveJpeg(yol, resim, 100);
                    //resim.Save(yol, System.Drawing.Imaging.ImageFormat.Jpeg);
                    resim.Dispose();
                    resim = null;


                }
            }
        }
        Doldur();
    }
}
