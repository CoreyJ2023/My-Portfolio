/*
 * Programmer:      Corey Jenkins
 * Date:            February 29, 2024
 * Filename:        CellPhoneConstructor.java
 * Purpose:         Object-Oriented Programming with a Constructor.
*/

public class CellPhoneConstructor {
    private String manufacturer;
    private String modelNumber;
    private double retailPrice;

    public CellPhoneConstructor(String manufact, String modNum, double retail) {
        manufacturer = manufact;
        modelNumber = modNum;
        retailPrice = retail;
    }

    // Setters or Mutators
    public void setManufacturer(String manufact) {
        manufacturer = manufact;
    }

    public void setModelNumber(String modNum) {
        modelNumber = modNum;
    }

    public void setRetailPrice(double retail) {
        retailPrice = retail;
    }

    public String getManufacturer() {
        return manufacturer;
    }

    public String getModelNumber() {
        return modelNumber;
    }

    public double getRetailPrice() {
        return retailPrice;
    }

    public static void main(String[] args) {
        CellPhoneConstructor myPhone;

        myPhone = new CellPhoneConstructor("Motorolla", "M1000", 199.99);

        System.out.println("The manufacturer is: " + myPhone.getManufacturer());
        System.out.println("The model number is: " + myPhone.getModelNumber());
        System.out.println("The  retail price is: " + myPhone.getRetailPrice());

    }

}