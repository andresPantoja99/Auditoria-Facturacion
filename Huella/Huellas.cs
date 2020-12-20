using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using SecuGen.FDxSDKPro.Windows;
using sistema_de_facturacion.Modelo;
using sistema_de_facturacion.Clientes;
using sistema_de_facturacion.Facturacion;
using sistema_de_facturacion.Usuarios;
using sistema_de_facturacion.Login;
using sistema_de_facturacion.Estimados;

namespace sistema_de_facturacion.Huella
{
    public partial class Huellas : Form
    {
        private SGFingerPrintManager mFPM;
        private SGFPMDeviceList[] m_DevList;
        private Int32 m_ImageWidth;
        private Int32 m_ImageHeight;
        private Byte[] m_RegMin1;
        public AgregarCliente ag;
        public Facturas fi;
        public AgregarUsuario au;
        public IngresoAlSistema ias;
        public Proformas pinicial;
        ConexionDB conexion = new ConexionDB();
        public Huellas(AgregarCliente inicial)
        {
            InitializeComponent();
            m_RegMin1 = new Byte[400];
            mFPM = new SGFingerPrintManager();
            mFPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            initalizeDevice();
            identificarButton.Visible = false;
            registrarButton.Enabled = false;
            this.ag = inicial;
        }
        public Huellas(Facturas finicial)
        {
            InitializeComponent();
            m_RegMin1 = new Byte[400];
            mFPM = new SGFingerPrintManager();
            mFPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            initalizeDevice();
            registrarButton.Visible = false;
            identificarButton.Enabled = false;
            this.fi = finicial;
        }
        public Huellas(Proformas pinicial)
        {
            InitializeComponent();
            m_RegMin1 = new Byte[400];
            mFPM = new SGFingerPrintManager();
            mFPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            initalizeDevice();
            registrarButton.Visible = false;
            identificarButton.Enabled = false;
            this.pinicial = pinicial;
        }
        public Huellas(AgregarUsuario au)
        {
            InitializeComponent();
            m_RegMin1 = new Byte[400];
            mFPM = new SGFingerPrintManager();
            mFPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            initalizeDevice();
            identificarButton.Visible = false;
            registrarButton.Enabled = false;
            this.au = au;
            
        }
        public Huellas(IngresoAlSistema ias)
        {
            InitializeComponent();
            m_RegMin1 = new Byte[400];
            mFPM = new SGFingerPrintManager();
            mFPM.SetTemplateFormat(SGFPMTemplateFormat.ANSI378);
            initalizeDevice();
            registrarButton.Visible = false;
            identificarButton.Enabled = false;
            this.ias = ias;
        }
        private void initalizeDevice()
        {
            Int32 iError;
            string enumDevice;
            iError = mFPM.EnumerateDevice();

            m_DevList = new SGFPMDeviceList[mFPM.NumberOfDevice];

            for (int i = 0; i < mFPM.NumberOfDevice; i++)
            {
                m_DevList[i] = new SGFPMDeviceList();
                mFPM.GetEnumDeviceInfo(i, m_DevList[i]);
                enumDevice = m_DevList[i].DevName.ToString() + " : " + m_DevList[i].DevID;
                comboBox1.Items.Add(enumDevice);

            }
            
            
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                ag.Visible = true;
            }
            else if (fi != null)
            {
                fi.Visible = true;
            }
            else if (au != null)
            {
                au.Visible = true;
            }
            else if (ias != null)
            {
                ias.Visible = true;
            }else if (pinicial != null)
            {
                pinicial.Visible = true;
            }
            this.Dispose();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ag != null)
            {
                ag.Visible = true;
            }
            else if (fi != null)
            {
                fi.Visible = true;
            }else if (au != null)
            {
                au.Visible = true;
            }else if (ias != null)
            {
                ias.Visible = true;
            }else if (pinicial != null)
            {
                pinicial.Visible = true;
            }

            this.Dispose();
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                m_ImageWidth = 260;
                m_ImageHeight = 300;
                if (mFPM.NumberOfDevice == 0)
                    return;

                Int32 iError;
                SGFPMDeviceName deviceName;
                Int32 deviceID;
                Int32 selectedDevice = comboBox1.SelectedIndex;
                deviceName = m_DevList[selectedDevice].DevName;
                deviceID = m_DevList[selectedDevice].DevID;

                iError = mFPM.Init(deviceName);
                iError = mFPM.OpenDevice(deviceID);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    registrarButton.Enabled = true;
                    identificarButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Conecte el dispositivo y vuelva abrir esta ventana!");
                this.Dispose();
            }
            
            
        }
        public bool addFingerprintToDatabase(byte[] byteArray)
        {
            //conexion.abrirConexion();
            //SqlCommand command = new SqlCommand("INSERT INTO fingerData(fingerTemplate) VALUES(@fingerTemplate)", conexion.obtenerConexion());
            //command.Parameters.Add("@fingerTemplate", System.Data.SqlDbType.Binary);
            //command.Parameters["@fingerTemplate"].Value = byteArray;
            //if (command.ExecuteNonQuery() > 0)
            //{
            //    conexion.cerrarConexion();
            //    return true;
            //}
            //else
            //{
            //    conexion.cerrarConexion();
            //    return false;
            //}
            if (byteArray != null && this.ag !=null){
                ag.huella = byteArray;
                return true;
            }
            else if (byteArray != null && this.au != null)
            {
                au.huella = byteArray;
                return true;
            }
            else
            {
                return false;
            }
            

        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            img_qlty = 0;

            iError = mFPM.GetImage(fp_image);
            mFPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar1.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBox1);
                iError = mFPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    MessageBox.Show("Huella Digital Generada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//DisplayError("CreateTemplate()", iError);
                    if (addFingerprintToDatabase(m_RegMin1))
                    {
                        MessageBox.Show("Huella Digital Registrada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//DisplayError("CreateTemplate()", iError);
                        if(this.ag != null)
                        {
                            this.ag.Visible = true;
                        }else if (this.au != null)
                        {
                            this.au.Visible = true;
                        }
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Erro al añadir el registro de la huella digital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//DisplayError("CreateTemplate()", iError);
                    }

                }
                else
                {
                    MessageBox.Show("Error al generar la huella digital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//DisplayError("CreateTemplate()", iError);
                }

            }
            else
            {
                MessageBox.Show("Error obteniendo imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//DisplayError("CreateTemplate()", iError);
            }

            progressBar1.Value = 0;
            pictureBox1.Image = null;
        }
        private void DrawImage(Byte[] imgData, PictureBox picBox)
        {
            int colorval;
            Bitmap bmp = new Bitmap(m_ImageWidth, m_ImageHeight);
            picBox.Image = (Image)bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int)imgData[(j * m_ImageWidth) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            picBox.Refresh();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public String getFingerFromDatabase(byte[] templateToCompare)
        {
            conexion.abrirConexion();
            Int32 iError;
            bool matched = false;
            SGFPMSecurityLevel secu_level = SGFPMSecurityLevel.NORMAL;
            SqlCommand cmd;
            if (this.fi != null || this.pinicial !=null) {
                cmd = new SqlCommand("uspObtenerHuellasClientes", conexion.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String fid = reader.GetString(0);
                    byte[] dbTemplate = (byte[])reader[7];
                    iError = mFPM.MatchTemplate(dbTemplate, templateToCompare, secu_level, ref matched);
                    if (iError == (Int32)SGFPMError.ERROR_NONE)
                    {
                        if (matched)
                        {
                            return fid;
                        }
                    }
                }
                reader.Close();
            }
            else
            {
                cmd = new SqlCommand("uspObtenerHuellasUsuarios", conexion.obtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String fid = reader.GetString(0);
                    byte[] dbTemplate = (byte[])reader[5];
                    iError = mFPM.MatchTemplate(dbTemplate, templateToCompare, secu_level, ref matched);
                    if (iError == (Int32)SGFPMError.ERROR_NONE)
                    {
                        if (matched)
                        {
                            return fid;
                        }
                    }
                }
                reader.Close();
            }

            
            
            conexion.cerrarConexion();
            return null;
        }

        private void IdentificarButton_Click(object sender, EventArgs e)
        {
            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[m_ImageWidth * m_ImageHeight];
            img_qlty = 0;

            iError = mFPM.GetImage(fp_image);
            mFPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, ref img_qlty);
            progressBar1.Value = img_qlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBox1);
                iError = mFPM.CreateTemplate(fp_image, m_RegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    MessageBox.Show("Huella Digital Detectada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//DisplayError("CreateTemplate()", iError);
                    String fid = getFingerFromDatabase(m_RegMin1);
                    if (fid == null)
                    {
                        MessageBox.Show("No se ha encontrado ningún registro que coincida con la huella detectada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//DisplayError("CreateTemplate()", iError);
                    }
                    else
                    {
                        if (this.fi != null)
                        {
                            fi.idCliente = fid;
                            fi.obtenerConHuella();
                            fi.Visible = true;
                        }else if (this.ias != null)
                        {
                            ias.usuario = fid;
                            ias.ingresarConHuella();
                        }else if (this.pinicial != null)
                        {
                            pinicial.idCliente = fid;
                            pinicial.obtenerConHuella();
                            pinicial.Visible = true;
                        }
                        this.Dispose();
                        //MessageBox.Show("Fingerprint belongs to:" + fid, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//DisplayError("CreateTemplate()", iError);
                    }

                }
                else
                {
                    MessageBox.Show("Error generando la huella digital!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//DisplayError("CreateTemplate()", iError);
                }

            }
            else
            {
                MessageBox.Show("Error obteniendo imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//DisplayError("CreateTemplate()", iError);
            }

            progressBar1.Value = 0;
            pictureBox1.Image = null;
        }
    }
    }


