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
}