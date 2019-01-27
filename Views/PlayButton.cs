using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyEye.Views
{
    public class PlayButton
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Image PlayImage;
        private Image PauseImage;

        private PlayMode _mode;

        public PlayMode Mode {
            get
            {
                return _mode;
            }
            set {
                ChangeMode(value);
            }
        }



        public Button ButtonObj;

        public delegate void OnPause();
        public delegate void OnPlay();

        public event OnPause PauseListeners;
        public event OnPause PlayListeners;



        public PlayButton(Button button)
        {
            PlayImage = Properties.Resources.play_icon;
            PauseImage = Properties.Resources.pause_icon;

            ButtonObj = button;
            ChangeMode(PlayMode.Play);
            button.Click += OnClickHandler;
        }


        private void ChangeMode(PlayMode mode)
        {
            log.Info("switching to mode " + mode);

            switch (mode)
            {
                case PlayMode.Play:
                    ButtonObj.Image = PauseImage;
                    if(PlayListeners != null)
                    {
                        PlayListeners.Invoke();
                    }
                    break;
                case PlayMode.Pause:
                    ButtonObj.Image = PlayImage;
                    if(PauseListeners != null)
                    {
                        PauseListeners.Invoke();
                    }
                    break;
                default:
                    throw new NotImplementedException();

            }

            _mode = mode;
        }

        private void OnClickHandler(object sender, EventArgs e)
        {
            log.Debug("Clicked play button");
            switch (Mode)
            {
                case PlayMode.Play:
                    ChangeMode(PlayMode.Pause);
                    break;
                case PlayMode.Pause:
                    ChangeMode(PlayMode.Play);
                    break;
                default:
                    throw new NotImplementedException();

            }
        }

    }

    public enum PlayMode
    {
        Play, Pause
    }
}
