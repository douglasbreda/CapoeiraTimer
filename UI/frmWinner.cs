using CapoeiraTimer.Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapoeiraTimer.UI
{
    public partial class frmWinner : Form
    {
        #region [Attributes]

        private Tuple<string, Color> _playerOne;
        private Tuple<string, Color> _playerTwo;
        private Duel _duel = null;

        #endregion

        #region [Constructor]

        /// <summary>
        /// Default
        /// </summary>
        public frmWinner( Tuple<string, Color> playerOne, Tuple<string, Color> playerTwo )
        {
            InitializeComponent();
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _duel = new Duel();
        }

        #endregion

        #region [Events]

        private void frmWinner_Load( object sender, EventArgs e )
        {
            ConfigButtons();
        }

        private void frmWinner_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( ( ( Keys ) e.KeyChar ) == Keys.D1 || ( ( Keys ) e.KeyChar ) == Keys.NumPad1 )
                PlayerOneWins();

            if ( ( ( Keys ) e.KeyChar ) == Keys.D2 || ( ( Keys ) e.KeyChar ) == Keys.NumPad2 )
                PlayerTwoWins();

        }

        private void btnPlayerOne_Click( object sender, EventArgs e )
        {
            PlayerOneWins();
        }

        private void btnPlayerTwo_Click( object sender, EventArgs e )
        {
            PlayerTwoWins();
        }

        #endregion

        #region [Methdos]

        /// <summary>
        /// Config the text and color of the buttons
        /// </summary>
        private void ConfigButtons()
        {
            _duel.Player1 = _playerOne.Item1;
            btnPlayerOne.Text = $"{_duel.Player1} (1)";
            btnPlayerOne.BackColor = _playerOne.Item2;

            _duel.Player2 = _playerTwo.Item1;
            btnPlayerTwo.Text = $"{_duel.Player2} (2)";
            btnPlayerTwo.BackColor = _playerTwo.Item2;
        }

        /// <summary>
        /// Set the player one as winner
        /// </summary>
        private void PlayerOneWins()
        {
            _duel.IsPlayerOneWinner = true;
            SaveDuelFile();
        }

        /// <summary>
        /// Set the player two as winner
        /// </summary>
        private void PlayerTwoWins()
        {
            _duel.IsPlayerTwoWinner = true;
            SaveDuelFile();
        }

        /// <summary>
        /// Save the file with the information of the duel
        /// </summary>
        private void SaveDuelFile()
        {
            string _xml = Utils.SerializeXml( _duel );

            Utils.SaveXml( $"{_playerOne.Item1}_{_playerTwo.Item1}", _xml );

            Close();
        }

        #endregion

       
    }
}
