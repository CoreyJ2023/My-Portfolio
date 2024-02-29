public class CellPhone
{
	// Field declarations
	private String manufacturer;
	private String modelNumber;
	private double retailPrice;

	// Method Definitions
	public void setManufacturer(String manufact)
	{
		manufacturer = manufact;
	}

	public void setModelNumber(String modNum)
	{
		modelNumber = modNum;
	}

	public void setRetailPrice(double retail)
	{
		retailPrice = retail;
	}

	public String getmanufacturer()
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

	public static void main(String[] args)
	{
		CellPhone myPhone;
		myPhone = new CellPhone();
		
		myPhone.setManufacturer();
		myPhone.setModelNumber();
		myPhone.setRetailPrice();

		System.out.println("The manufacturer is: " + myPhone.getSetManufacturer());
		System.out.println("The model number is: " + myPhone.getModelNumber());
		System.out.println("The retail price is: " + myPhone.getRetailPrice());
	}
}
