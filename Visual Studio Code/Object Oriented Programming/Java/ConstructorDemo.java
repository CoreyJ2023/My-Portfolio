public class ConstructorDemo
{
	public static void main(String[] args)
	{
		// Declare a variable that can reference
		// a CellPhone object
		CellPhone myPhone;

		// The following statement creates an object
		// and initalizes its fields with the values
		// passed to the constructorr.
		myPhone = new CellPhone("Motorola", "M1000", 199.99);

		// Display the values stored in the fields.
		System.out.println("The manufacturer is " + myPhone.getManufacturer());
		System.out.println("The model number is " + myPhone.getModelNumber());
		System.out.println("The Retail price is " + myPhone.getRetailPrice());
	}
}