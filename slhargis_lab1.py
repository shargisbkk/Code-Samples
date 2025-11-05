print ("\nTravel Time Calculator\n")

distance = int(input("Enter distance in MILES: "))
speed = int(input("Enter speed in Miles Per Hour: "))

# modulo gets the remainder of distance/speed, divide by speed to get remaining hours rounded up
REMAINING_HOURS = (distance % speed) / speed

if distance > 0 and speed > 0:
    
    # int only takes the whole number of the division, showing the hours without remainder
    hours = distance // speed
    
    # convert the remaining hours to minutes
    minutes = int(round(REMAINING_HOURS * 60, 0))

    print (f"\nYour estimated travel time\n"
       f"Hours: {hours}\n"
       f"Minutes: {minutes}")
else:
    print("1 is the minimum entry for both inputs.")