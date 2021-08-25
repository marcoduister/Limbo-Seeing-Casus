using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limbo_Seeing.Views
{
    public partial class QRCode : Form
    {
        public QRCode(Guid Resevering_id)
        {
            InitializeComponent();

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            QRCodeimage.Image = qrcode.Draw(Resevering_id.ToString(), 50);
        }
    }
}
