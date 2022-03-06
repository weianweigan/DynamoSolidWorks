using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace DynamoSldWorks.ViewModel
{
    public class DynamoTaskPaneViewModel : NotificationObject
    {
        private FileInfo _selectedFile;
        private readonly SwAddin _swAddin;
        private readonly string _addinLocation;
        private DelegateCommand<string> _openFileCommand;

        public DynamoTaskPaneViewModel(SwAddin swAddin, string addinLocation)
        {
            _swAddin = swAddin;
            _addinLocation = addinLocation;

            Init();
        }

        public List<FileInfo> SampleFiles { get; set; }

        public FileInfo SelectedFile
        {
            get => _selectedFile; set
            {
                _selectedFile = value;
                if (value != null)
                    Open(_selectedFile.FullName);
            }
        }

        public DelegateCommand<string> OpenFileCommand { get => _openFileCommand ?? (_openFileCommand = new DelegateCommand<string>(OpenClick)); }

        private void OpenClick(string obj)
        {
            Process.Start(obj);
        }

        private void Init()
        {
            var dir = Path.Combine(_addinLocation, "samples");
            var dirInfo = new DirectoryInfo(dir);
            if (dirInfo.Exists)
            {
                var files = dirInfo
                    .GetFiles()
                    .Where(p => p.Extension.ToLower() == ".dyn");

                SampleFiles = files.ToList();
            }
        }

        private void Open(string pathName)
        {
            try
            {
                _swAddin.InitDynamoSetup();
                _swAddin.DynamoSetup.OpenDoc(pathName,_swAddin.Application.WindowHandle);
            }
            catch (Exception ex)
            {
                _swAddin.Application.ShowMessageBox(ex.Message);
            }
        }

        private DelegateCommand openDynamoCommand;

        public ICommand OpenDynamoCommand
        {
            get
            {
                if (openDynamoCommand == null)
                {
                    openDynamoCommand = new DelegateCommand(OpenDynamo);
                }

                return openDynamoCommand;
            }
        }

        private void OpenDynamo()
        {
            _swAddin.DynamoSetup.Start(_swAddin.Application.WindowHandle);
        }
    }
}
