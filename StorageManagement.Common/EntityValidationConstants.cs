namespace StorageManagement.Common
{
    public class EntityValidationConstants
    {
        public static class Product
        {
            public const int NameMaxLength = 100;
            public const int SupplierMaxLength = 100;
            public const int ManufacturerMaxLength = 100;
            public const int DescriptionMaxLength = 500;
            public const int QuantityMinValue = 0;
            public const int PriceMinValue = 0;
            public const int ProductTypeMaxLength = 30;
        }
    }
}
