class CellPhone
{
    private String manufacturer;
    private String modelNumber;
    private double retailPrice;

    // Mutators or setters.
    void setManufacturer(String manufact)
    {
        manufacturer = manufact;
    }

    void setModelNumber(string modNum)
    {
        modelNumber = modNum;
    }

    void setRetailPrice(double retail)
    {
        retailPrice = retail;
    }
    
    // Accessor or getters.
    public String getManufacturer()
    {
        return manufacturer;
    }

    public String getModelNumber()
    {
        return modelNumber;
    }

    public double getRetailPrice()
    {
        return retailPrice;
    }

    static void Main(string[] args)
    {
        CellPhone myPhone;
        myPhone = new CellPhone();

        myPhone.setManufacturer("Motorolla");
        myPhone.setModelNumber("M1000");
        myPhone.setRetailPrice(199.99);

        Console.WriteLine("The manufacuturer is " + myPhone.getManufacturer());
        Console.WriteLine("The model number is " + myPhone.getModelNumber());
        Console.WriteLine("The retail price is " + myPhone.getRetailPrice());

    }

}