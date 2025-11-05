#checks if the input is even or odd
def isEven(number):
    moduloValue = int(number) % 2
    if moduloValue == 0:
        return True
    else:
        return False

# assign module name to "main"
def main():
    # display a welcome message
    print("Even or Odd Checker")
    
    # get input
    userNumber = input("\nEnter an integer: ")

    # check if the integer is even or odd
    Even = isEven(userNumber)
    
    #display ouput
    if Even == True:
        print("This is an even number.")
    else:
        print("This is an odd number.")

# call/run main
if __name__ == "__main__":
    main()