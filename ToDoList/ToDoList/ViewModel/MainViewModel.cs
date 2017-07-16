using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using ToDoList.Services;
using ToDoList.Model;

namespace ToDoList.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        IDataAccessSupplier _ServiceProxy;
        private ObservableCollection<Suppliier> _Suppliers;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataAccessSupplier servPxy)
        {
            _ServiceProxy = servPxy;
            Suppliers = new ObservableCollection<Suppliier>();
            GetSuppliers();
          
        }

        public ObservableCollection<Suppliier> Suppliers
        {
            get
            {
                return _Suppliers;
            }

            set
            {
                _Suppliers = value;
                RaisePropertyChanged("Suppliers");
            }
        }

        void GetSuppliers()
        {
            Suppliers.Clear();
            foreach (var item in _ServiceProxy.GetSupplierDataAccess())
            {
                Suppliers.Add(item);
            }
        }
    }
}