using System;
using System.Text;
using System.Windows.Forms;

namespace CapoeiraTimer.UI
{
    public partial class formConfig : Form
    {
        #region [Properties]

        /// <summary>
        /// Return the total of seconds
        /// </summary>
        public int TotalSeconds
        {
            get { return ( Convert.ToInt32( txtMinutes.Value ) * 60 ) + ( Convert.ToInt32( txtSeconds.Value ) ); }
        }

        /// <summary>
        /// Name One
        /// </summary>
        public string NameOne
        {
            get { return txtNameOne.Text; }
        }

        /// <summary>
        /// Name Two
        /// </summary>
        public string NameTwo
        {
            get { return txtNameTwo.Text; }
        }

        #endregion

        #region [Constructor]

        /// <summary>
        /// Default
        /// </summary>
        public formConfig()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]

        private void btnConfirm_Click( object sender, EventArgs e )
        {
            string _validation = ValidateData();

            if ( !string.IsNullOrEmpty( _validation ) )
                MessageBox.Show( _validation, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Validate the data of the form
        /// </summary>
        private string ValidateData()
        {
            StringBuilder _message = new StringBuilder();
            if ( string.IsNullOrEmpty( txtNameOne.Text ) )
                _message.AppendLine( "- Deve ser informado o primeiro nome." );

            if ( string.IsNullOrEmpty( txtNameTwo.Text ) )
                _message.AppendLine( "- Deve ser informado o segundo nome." );

            if ( txtMinutes.Value == 0 && txtSeconds.Value == 0 )
                _message.AppendLine( "- Não foi informado nenhum tempo." );

            return _message.ToString();
        }

        #endregion

        
    }
}
