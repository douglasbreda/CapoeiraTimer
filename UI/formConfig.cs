using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapoeiraTimer.UI
{
    public partial class formConfig : Form
    {
        #region [Properties]

        private Tuple<string, Color> _playerOne = null;
        private Tuple<string, Color> _playerTwo = null;

        /// <summary>
        /// Return the total of seconds
        /// </summary>
        public int TotalSeconds
        {
            get { return ( Convert.ToInt32( txtMinutes.Value ) * 60 ) + ( Convert.ToInt32( txtSeconds.Value ) ); }
        }

        /// <summary>
        /// Player One
        /// </summary>
        public Tuple<string, Color> PlayerOne
        {
            get
            {
                _playerOne = new Tuple<string, Color>( txtNameOne.Text, btnColorNameOne.BackColor );
                return _playerOne;
            }
        }

        /// <summary>
        /// Player Two
        /// </summary>
        public Tuple<string, Color> PlayerTwo
        {
            get
            {
                _playerTwo = new Tuple<string, Color>( txtNameTwo.Text, btnColorNameTwo.BackColor );
                return _playerTwo;
            }
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

        private void btnColorNameOne_Click( object sender, EventArgs e )
        {
            btnColorNameOne.BackColor = GetColor();
        }

        private void btnColorNameTwo_Click( object sender, EventArgs e )
        {
            btnColorNameTwo.BackColor = GetColor();
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

        /// <summary>
        /// Get the color for the name
        /// </summary>
        /// <returns></returns>
        private Color GetColor()
        {
            if ( colorDialog1.ShowDialog() == DialogResult.OK )
                return colorDialog1.Color;

            return Color.Black;
        }



        #endregion

        
    }
}
