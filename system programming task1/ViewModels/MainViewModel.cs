using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using system_programming_task1.Command;

namespace system_programming_task1.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
       private ObservableCollection<Process> allProcesses { get; set; }
        public ObservableCollection<Process> AllProcesses
        {
            get { return allProcesses; }
            set { allProcesses = value;OnPropertyChanged(); }
        }


        public MainWindow MainWindow { get; set; }
        ObservableCollection<Process> Processes { get; set; }
        private Process sProcess;

        public Process SProcess
        {
            get { return sProcess; }
            set { sProcess = value; }
        }
   

        public RelayCommand CreateBtn { get; set; }
        public RelayCommand EndBtn { get; set; }
        public RelayCommand AddBtn { get; set; }

        public MainViewModel(MainWindow window)
        {

            Processes = new ObservableCollection<Process>(Process.GetProcesses());
            MainWindow = window;
        
            AllProcesses = new ObservableCollection<Process>(Process.GetProcesses());
            
            AddBtn = new RelayCommand((sender) => { 
                MainWindow.addlistbox .Items.Add(MainWindow.processname  .Text);
                MessageBox.Show("process was added" );
            });
            CreateBtn = new RelayCommand((sender => {
                try
                {

                    Process.Start(window.processname .Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("error");
                }
            
                
              
                
                  
                
            }));

            EndBtn = new RelayCommand((sender =>
            {
                try
                {

                    try
                    {
                        if (SProcess != null)
                        {
                            SProcess.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                      
                    }

                }



                catch (Exception)
                {
                    
                }

            }));
        }

    }
}
