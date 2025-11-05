import csv

def readFile(filename: str):
    content = []
    filecsv = filename + ".csv"
    with open (filecsv, "r", newline= "") as file:
        reader = csv.reader(file)
        for row in reader:
            content.append(row)
    print("Source list:  ", filename, ".csv")
    return content

def cleanFile(file: list):
    clean = []
    for line in file:
        line[0] = line[0].title()
        line[1] = line[1].title()
        line[2] = line[2].lower()
        clean.append(line)
    return clean

def saveFile(newFile: list, fileName: str):
    fileClean = fileName + "_clean.csv"
    with open(fileClean, "w", newline="") as file:
        writer = csv.writer(file)
        writer.writerows(newFile)
    print("Cleaned list: ", fileClean)

def main():
    fileName = "lab10_prospects"
    outfile = readFile(fileName)
    outfile = cleanFile(outfile)
    saveFile(outfile, fileName)

if __name__ == "__main__":
    main()