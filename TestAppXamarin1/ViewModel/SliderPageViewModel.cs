using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TestAppXamarin1.ViewModel
{
    public class SliderPageViewModel : INotifyPropertyChanged
    {
        private string labelText = "Hello";

        public event PropertyChangedEventHandler PropertyChanged;

        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand 
        {
            get {
                return
                    changeTextCommand ?? (changeTextCommand = new Command(() =>
                    {
                        LabelText = "Goodbay";
                }));
            
            }

        }

        public SliderPageViewModel()
        {
        }

        protected void RaisePropertyChanged([CallerMemberName]string caller = "")
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
