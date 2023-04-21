using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarker_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView//esto es para implementar la interfaz del pay mode view 
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);//esto para que cuando el formulario se muestre,
                                                              //no aparezca la pestaña PayModeDetails
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click +=delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };//cuando se oprima btn search,
                                                                                       //usara el texto que se puso para
                                                                                       //buscar dentro del listado
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //aqui agremagos los demas botones con respecto a los eventos
            BtnNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text= "Add New Pay Mode";//cambia el titulo de la pestaña
            };
            BtnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode";//cambia el titulo de la pestaña
            };
            BtnDelete.Click += delegate 
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the select Pay Mode",
                    "WARNING",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) 
                { 
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSave.Click += delegate 
            { 
                SaveEvent?.Invoke(this,EventArgs.Empty);
                if (IsSuccessful) //si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPagePayModeList);
                    tabControl1.TabPages.Add(tabPagePayModeDetail);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this,EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
            };
        }

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }//con estos get y set se le dan las acciones generales a las casillas de texto//
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public string SearchValue 
        { 
            get { return TxtSearch.Text; } 
            set { TxtSearch.Text = value; } 
        }
        public bool IsEdit 
        { 
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return IsSuccessful; } 
            set { IsSuccessful = value; } 
        }
        public string Message 
        { 
            get { return Message; } 
            set { Message = value; } 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;

        }
        //a continuacion esta el modo sigleton, con esto evitamos que un boton abra el mismo formulario varias veces
        private static PayModeView instance;
        public static PayModeView GetInstance(Form parentContainer) 
        {
            if (instance == null || instance.IsDisposed) 
            { 
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized) 
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
