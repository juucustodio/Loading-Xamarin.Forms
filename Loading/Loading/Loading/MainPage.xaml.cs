using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loading
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();

            IsLoading = false;
            BindingContext = this;
        }
        public async void Show(object sender, EventArgs e)
        {
            try
            {
                aparece();

                //Chame sua função aqui
                await Task.Delay(4000);


                some();
            }
            catch (Exception ex)
            {
                some();
                if (ex != null)
                {
                    //Trate seu erro aqui
                }
            }
        }
        public async void aparece()
        {
            IsLoading = true;
        }
        public async void some()
        {
            IsLoading = false;
        }

        private bool isLoading;
        public bool IsLoading
        {
            get
            {
                return this.isLoading;
            }
            set
            {
                this.isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}