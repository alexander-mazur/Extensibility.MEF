using Extensibility.WPF.Commands;

using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using System.Net.Http;
using System;

namespace Extensibility.WPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private IEnumerable<string> _applicationAdapterNames;

        public ICommand RefreshCommand
        {
            get { return new DelegateCommand<object>(RefreshData); }
        }

        public ICommand CloseCommand
        {
            get { return new DelegateCommand<Window>(Close); }
        }

        public IEnumerable<string> ApplicationAdapterNames
        {
            get { return _applicationAdapterNames; }
            set
            {
                _applicationAdapterNames = value;
                OnPropertyChanged("ApplicationAdapterNames");
            }
        }

        private void RefreshData(object context)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:9000/");

                var response = httpClient.GetAsync("api/adapters").Result;
                if (response.IsSuccessStatusCode)
                {
                    ApplicationAdapterNames = response.Content.ReadAsAsync<IEnumerable<string>>().Result;
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void Close(Window window)
        {
            window.Close();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
