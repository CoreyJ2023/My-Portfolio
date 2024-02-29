class CellPhone2:
    def __init__(self, manufact, mod_num, retail):
        self.manufactuer = manufact
        self.model_number = mod_num
        self.retail_price = retail
        
    def set_manufacturer(self, manufact):
        self.manufactuer = manufact
    
    def set_model_number(self, mod_num):
        self.model_number = mod_num
        
    def set_retail_price(self, retail):
        self.retail_price = retail
        
    def get_manufacturer(self):
        return self.manufactuer
    
    def get_model_number(self):
        return self.model_number
    
    def get_retail_price(self):
        return self.retail_price
    
def main():
    my_phone = CellPhone2("Motorola", "M1000", 199.99)
    
    print("The manufacuturer is", my_phone.get_manufacturer())
    print("The model number is", my_phone.get_model_number())
    print("The retail price is", my_phone.get_retail_price())
    
main()    