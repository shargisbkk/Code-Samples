# this will only read in the current directory.
def readFile(filename: str):
    content = []
    # uses relative file path to locate and open file
    with open (filename, "r") as file:
        for line in file:
            # removes the new line seperator
            line = line.replace("\n", "")
            # add each line of the file to a list
            content.append(line)
    # return a list
    return content

def displayContent(contentList: list):
    # iterate for as many items in the list
    for i in range (len(contentList)):
        # print the indexed list content
        print(contentList[i])

def main():
    outfile = readFile("lab9_rules.txt")
    displayContent(outfile)

if __name__ == "__main__":
    main()