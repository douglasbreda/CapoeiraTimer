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

        protected override void OnKeyDown( KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                btnStop.PerformClick();
            else if ( e.KeyCode == Keys.Escape )
            {
                if ( btnReset.Enabled )
                    Reset();
            }

            base.OnKeyDown( e );
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
            btnStop.Text = "Iniciar (Enter)";
            _isStopped = false;
            timer1.Enabled = false;
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
            btnStop.Text = "Continuar (Enter)";
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
                    lblNameOne.Text = oConfig.NameOne;
                    lblNameTwo.Text = oConfig.NameTwo;
                    _isRunning = true;
                    btnReset.Enabled = false;
                    timer1.Enabled = true;
                    btnStop.Text = "Parar (Enter)";
                }
            }
            else
            {
                _isRunning = true;
                _isStopped = false;
                btnReset.Enabled = false;
                timer1.Enabled = true;
                btnStop.Text = "Parar (Enter)";
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
                }
            }
        }



        #endregion

        
    }
}
