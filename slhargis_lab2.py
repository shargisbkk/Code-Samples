print("Letter Grade Converter\n")

numberGrade = int(input("Enter numerical grade: "))

if numberGrade >= 90 and numberGrade <= 100:
    letterGrade = "A"
    print(f"Letter grade: {letterGrade}")

elif numberGrade >= 80 and numberGrade < 90:
    letterGrade = "B"
    print(f"Letter grade: {letterGrade}")

elif numberGrade >= 70 and numberGrade < 80:
    letterGrade = "C"
    print(f"Letter grade: {letterGrade}")

elif numberGrade >= 60 and numberGrade < 70:
    letterGrade = "D"
    print(f"Letter grade: {letterGrade}")

elif numberGrade >=0 and numberGrade < 60:
    letterGrade = "F"
    print(f"Letter grade: {letterGrade}")

else:
    print("Test score must range from 0-100.")
