'''
Programmer:     Corey Jenkins
Date:           February 29, 2024
Filename:       CellPhoneConstructor.py
Purpose:        Object-Oriented Programming with Constructor.
'''
class CellPhoneConstructor:
    def __init__(self, manufact, model, retail):
        self.manufacturer = manufact
        self.model_number = model
        self.retail_price = retail
        
    def set_manufacturer(self, manufact):
        self.manufacturer = manufact
        
    def set_model_number(self, model):
        self.model_number = model
        
    def set_retail_price(self, retail):
        self.retail_price = retail
        
    def get_manufacturer(self):
        return self.manufacturer
    
    def get_model_number(self):
        return self.model_number
    
    def get_retail_price(self):
        return self.retail_price
    
def main():
    my_phone = CellPhoneConstructor("Motorolla", "M1000", 199.99)
    
    print("The manufacturer is:", my_phone.get_manufacturer())
    print("The model number is:", my_phone.get_model_number())
    print("The retail price is:", my_phone.get_retail_price())
        
main()