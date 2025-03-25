namespace HospitalApp.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Parameterless constructor (needed for serialization, binding, etc.)
        public Medicine() { }

        // Parameterized constructor for easy object creation
        public Medicine(int medicineId, string name, decimal price, int stockQuantity)
        {
            MedicineId = medicineId;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
    }
}
