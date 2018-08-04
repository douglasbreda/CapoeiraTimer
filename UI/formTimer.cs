using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapoeiraTimer.UI
{
    public partial class formTimer : Form
    {

        #region [Attributes]

        private bool _isRunning = false;
        private bool _isStopped = false;
        private TimeSpan _time = new TimeSpan();
        private Tuple<string, Color> _playerOne;
        private Tuple<string, Color> _playerTwo;

        #endregion

        #region [Constructor]

        /// <summary>
        /// Constructor
        /// </summary>
        public formTimer()
        {
            InitializeComponent();
            lblTimer.Focus();
        }

        #endregion

        #region [Events]

        private void timer1_Tick( object sender, System.EventArgs e )
        {
            Execute();
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            if ( _isRunning )
                Stop();
            else
                Start();
        }

        private void btnReset_Click( object sender, EventArgs e )
        {
            Reset();
        }

        private void formTimer_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( ( Keys ) e.KeyChar == Keys.Space )
                btnStop.PerformClick();
            else if ( ( Keys ) e.KeyChar == Keys.Escape )
            {
                if ( btnReset.Enabled )
                    Reset();
            }
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Reset the app
        /// </summary>
        private void Reset()
        {
            lblTimer.ForeColor = Color.Black;
            lblTimer.Text = "00:00";
            btnReset.Enabled = true;
            btnStop.Text = "Iniciar (Espaço)";
            btnStop.Image = imageList1.Images["ico_play.png"];
            _isStopped = false;
            timer1.Enabled = false;
            lblNameTwo.Text = lblNameOne.Text = "...";
            lblNameOne.BackColor = lblNameTwo.BackColor = SystemColors.Control;
            lblNameOne.ForeColor = lblNameTwo.ForeColor = SystemColors.ControlText;
        }

        /// <summary>
        /// Stops the clock
        /// </summary>
        private void Stop()
        {
            _isRunning = false;
            _isStopped = true;
            btnReset.Enabled = true;
            timer1.Enabled = false;
            btnStop.Text = "Continuar (Espaço)";
            btnStop.Image = imageList1.Images["ico_play.png"];
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        private void Start()
        {
            if ( !_isStopped )
            {
                formConfig oConfig = new formConfig();

                if ( oConfig.ShowDialog() == DialogResult.OK )
                {
                    _time = TimeSpan.FromSeconds( oConfig.TotalSeconds );

                    lblNameOne.Text = oConfig.PlayerOne.Item1;
                    lblNameOne.BackColor = oConfig.PlayerOne.Item2;

                    _playerOne = oConfig.PlayerOne;

                    lblNameTwo.Text = oConfig.PlayerTwo.Item1;
                    lblNameTwo.BackColor = oConfig.PlayerTwo.Item2;

                    if ( lblNameOne.BackColor == Color.Black )
                        lblNameOne.ForeColor = Color.White;

                    if ( lblNameTwo.BackColor == Color.Black )
                        lblNameTwo.ForeColor = Color.White;

                    _playerTwo = oConfig.PlayerTwo;

                    _isRunning = true;
                    btnReset.Enabled = false;
                    timer1.Enabled = true;
                    btnStop.Text = "Parar (Espaço)";
                    btnStop.Image = imageList1.Images["ico_stop.png"];
                }
            }
            else
            {
                _isRunning = true;
                _isStopped = false;
                btnReset.Enabled = false;
                timer1.Enabled = true;
                btnStop.Text = "Parar (Espaço)";
                btnStop.Image = imageList1.Images["ico_stop.png"];
            }
        }

        /// <summary>
        /// Execute the timer
        /// </summary>
        private void Execute()
        {
            if ( _isRunning )
            {
                if ( _time.TotalSeconds > 0 )
                {
                    _time = TimeSpan.FromSeconds( _time.TotalSeconds - 1 );

                    if ( _time.TotalSeconds <= 10 )
                        lblTimer.ForeColor = Color.Red;

                    lblTimer.Text = $"{_time.Minutes.ToString().PadLeft( 2, '0' )}:{_time.Seconds.ToString().PadLeft( 2, '0' )}";
                }
                else
                {
                    lblTimer.ForeColor = Color.Blue;
                    lblTimer.Text = " Fim!";
                    btnReset.Enabled = true;
                    timer1.Enabled = false;
                    btnStop.Text = "Iniciar (Espaço)";
                    btnStop.Image = imageList1.Images["ico_play.png"];
                    GetWinner();
                }
            }
        }

        /// <summary>
        /// Get the winner
        /// </summary>
        private void GetWinner()
        {
            frmWinner oFrmWinner = new frmWinner( _playerOne, _playerTwo );
            oFrmWinner.ShowDialog();
        }

        #endregion
    }
}
