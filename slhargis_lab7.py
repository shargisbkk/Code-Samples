def Title():
    print ("The Quarterly Sales program\n")

# adds all numbers in the list and divides by total number of values, rounding to 2
def Average_Sales (Sales):
    if len(Sales) == 0:                         # stops the function from dividing by zero
        return 0
    return round(sum(Sales) / len(Sales), 2)

# print a formatted statement, if no value is used default is set to "null"
def PrintFormat(total = "null", average  = "null", low  = "null", high  = "null"):
    print(f"\033[0;37;40m\nTotal: \t\t\t{total}\n"
        f"Average Quarter: \t{average}\n"
        f"Lowest Quarter: \t{low}\n"
        f"Highest Quarter: \t{high}")
    
# get values for all quarterly sales and return a the inputs as a list
def GetQuarterlySales():
    Q1_Sales = float(input("Enter sales for Q1: \033[1;31;40m"))
    Q2_Sales = float(input("\033[0;37;40mEnter sales for Q2: \033[1;31;40m"))
    Q3_Sales = float(input("\033[0;37;40mEnter sales for Q3: \033[1;31;40m"))
    Q4_Sales = float(input("\033[0;37;40mEnter sales for Q4: \033[1;31;40m"))
    return [Q1_Sales, Q2_Sales, Q3_Sales, Q4_Sales]

def main():
    SalesList = GetQuarterlySales()
    
    Sum = round(sum(SalesList), 2)          # add all the inputs in the list together
    Average = Average_Sales(SalesList)      # total sales divided by number of sales
    Lowest = min(SalesList)                 # find the smallest sales quarter
    Highest = max(SalesList)                # find the largest sales quarter
    
    PrintFormat(Sum, Average, Lowest, Highest)             

if __name__ == "__main__":
    Title()
    main()