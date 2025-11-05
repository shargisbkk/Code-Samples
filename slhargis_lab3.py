print("Change Calculator")

choice = "y"

# the user's choice will either continue or break the while loop
while choice.lower() =="y":
    
    # sets the initial values to 0, incase the "if" statements are not used
    Quarters = 0
    Dimes = 0
    Nickles = 0

    Cents = int(input ("\nEnter number of cents (0-99): "))

    # "Cents" must be checked at each level and reassigned as needed
    # applying floor division results in the amount of each coin type used
    if Cents >= 25:
        Quarters = Cents//25
        Cents = Cents - Quarters*25
    if Cents >= 10:
        Dimes = Cents//10
        Cents = Cents - Dimes*10
    if Cents >= 5:
        Nickles = Cents//5
        Cents = Cents - Nickles*5

    # pennies should equal to the remaining value in Cents.
    print (f"\nQuarters: {Quarters}\n"
        f"Dimes:    {Dimes}\n"
        f"Nickles:  {Nickles}\n"
        f"Pennies:  {Cents}")
        
    choice = input("\nWould you like to continue (y/n): ")

print("\nBye!")