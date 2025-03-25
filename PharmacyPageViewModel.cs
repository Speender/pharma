using System.Collections.ObjectModel;
using HospitalApp.Models;

namespace HospitalApp.ViewModels
{
    public class PharmacyPageViewModel : ViewModelBase
    {
        public ObservableCollection<Medicine> Medicine { get; }

        public PharmacyPageViewModel()
        {
            Medicine = new ObservableCollection<Medicine>
            {
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75),
                new Medicine(1, "Aspirin", 10m, 50),
                new Medicine(2, "Paracetamol", 5m, 100),
                new Medicine(3, "Ibuprofen", 8m, 75)
            };
        }
    }
}
