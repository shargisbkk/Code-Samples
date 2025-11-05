# imports the conversion module
import slhargis_conversions

# function to print the initial welcome message
def Welcome():
    print("Feet and Meters Converter\n")

# function creates a formatted menu for the user to read and select an option
def startMenu():
    A_or_B = input (f"Conversions Menu:\n"
                        f"a. Feet to Meters\n"
                        f"b. Meters to Feet\n"
                        f"Select a conversion (a/b): ")
    return A_or_B

# defines this as the main function to call and renames this module as "__main__" 
def main():

    # choice as anything other than "n"
    choice = ""

    # create a while loop that will end if "n" is ever the user's choice
    while choice.lower() != "n":

        # call the start menu and store the choice
        choiceMenu = startMenu()
        
        # user is converting feet to meters
        if choiceMenu.lower() == "a":

            # take user's input for feet
            userNum = int(input("\nEnter feet: "))
            # calls conversion function from imported module and passes user input through, then prints a message
            print(f"\n{slhargis_conversions.feettometers(userNum)} meters")

        # user is converting meters to feet
        if choiceMenu.lower() == "b":

            # take user's input for meters
            userNum = int(input("\nEnter meters: "))
            # calls conversion function from imported module and passes user input through, then prints a message
            print(f"\n{slhargis_conversions.meterstofeet(userNum)} feet")
        
        # allows the user to continue as long as "n" is not the stored string
        choice = input("\nWould you like to perform another conversion? (y/n): ")

    print("\nThanks, bye!")

if __name__ == "__main__":
    Welcome()
    main()