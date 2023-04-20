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
        private bool isIsSuccessful;
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
            get { return IsEdit; } 
            set { IsEdit = value; } 
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

    }
}
