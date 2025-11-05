def Menu():
    print(f"\nCOMMAND MENU\n"
          f"show - Show all items\n"
          f"grab - Grab an item\n"
          f"edit - Edit an item\n"
          f"drop - Drop an item\n"
          f"exit - Exit program\n")
    command = input("Command: ")
    # return the input lower case for comparison
    return command.lower()

def Show(backpack:list):
    # check if there are any values in the list
    if len(backpack) == 0:
        print("Your inventory is empty...")
    else:
        for item in range(len(backpack)):
            # print item number starting at 1 and the indexed item starting at 0
            print (f"{item + 1}. {backpack[item]}")

def Grab(backpack:list):
        item = input("Name: ")
        # add the new input to the end of the list
        backpack.append(item)
        print(f"{item} was added.")
    
def Edit(backpack:list):
    while True:
        # reduce the user's input by 1 to reference the proper index number
        item = int (input("Number: ")) - 1
        # check for input greater than the list size or less than 0
        if item > len(backpack) or item < 0:
            print (f"Please enter 1 - {len(backpack)}")
        else:
            # assign new string value at the indexed element in the list
            backpack[item] = input("Updated Name: ")
            # increase item int by 1 for normal counting conditions
            print(f"Item number {item + 1} was updated.")
            break

def Drop(backpack:list):
    while True:
        # reduce the user's input by 1 to reference the proper index number
        item = int (input("Number: ")) - 1
        # check for input greater than the list size or less than 0
        if item > len(backpack) or item < 0:
            print (f"Please enter 1 - {len(backpack)}")
        else:
            # print the statement before removing the element
            print(f"{backpack[item]} was dropped.")
            # removes the indexed item
            backpack.pop(item)
            break

def main():
    inventory = ["wooden staff", "wizard hat", "cloth shoes"]
    
    while True:
        
        command = Menu()

        if command == "show":
            Show(inventory)
        
        elif command == "grab":
            # check if the number of items stored exceeds 4
            if len(inventory)>=4:
                print("You can't carry any more items. Drop something first.")
            else:
                Grab(inventory)
        
        elif command == "edit":
            Edit(inventory)
        
        elif command == "drop":
            Drop(inventory)
        
        elif command == "exit":
            break
        
        else:
            print("Please enter a valid command.")
    
    print("Bye!")

if __name__ == "__main__":
    print("\nThe Wizard Inventory program")
    main()