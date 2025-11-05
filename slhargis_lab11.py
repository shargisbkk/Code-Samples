
def getGrades(section: str):
    print(f"Enter your {section} grades. Enter a negative number to stop:")
    grades = []
    i = 1
    while True:
        try:
            grade = int(input(f"Enter {section} Grade {i}: "))
            # check range of the value in grade
            if 0 <= grade <= 100:
                i += 1
                grades.append(grade)
            elif grade < 0:
                break
            else:
                print("Please enter a valid grade.")
        # catch any invalid inputs.
        except ValueError:
            print("Please enter an integer.")
    try:
        result = sum(grades) / len(grades)
        print()
        return result
    # if there were no grades to input, prevent the crash and return 0
    except ZeroDivisionError:
        print("No grades entered.")
        print()
        return 0

# pass through the averages of each section, multiply by their weights, and round to 2 decimals
def calcGrades(aveLab, aveExam, aveQuiz):
    print(f"Calculating your class grade...\n")
    class_grade = round((aveLab*0.4) + (aveExam*0.4) +(aveQuiz*0.2),2)
    return class_grade

def main():
    labs = getGrades("lab")
    exams = getGrades("exam")
    quizzes = getGrades("quiz")
    average = calcGrades(labs, exams, quizzes)
    print(f"Your overall class grade is {average}\n")

if __name__ == "__main__":
    main()