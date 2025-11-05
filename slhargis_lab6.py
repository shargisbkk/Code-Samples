#!/usr/bin/env python3

TAX = 0.06

# the function needed a colon to fix the syntax error
# function needed to use the TAX constant to fix the NameError
# the function should return 'sales_tax' instead of 'total' to fix the logical error
def sales_tax(total):
    sales_tax = total * TAX
    return sales_tax

def main():
    print("Sales Tax Calculator\n")
    total = float(input("Enter total: \033[1;31;40m")) # I changed the user input color to red for fun
    total_after_tax = round(total + sales_tax(total), 2)
    print("\033[0;37;40mTotal after tax: ", total_after_tax) # I made sure to change it back to normal
    
if __name__ == "__main__":
    main()