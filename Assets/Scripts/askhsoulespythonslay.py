'''
userInput = input("Give me a sequence of whitespace seperated words: ")
words = [x for x in userInput.split(" ")]
words.sort()
print(" ".join(sorted(list(set(words)))))
'''
userInput = input("Give me a sequence of comma seperated 4 digit binary")
finalnumbers = []
numbers = [x for x in userInput.split(",")]
for i in numbers:
    if ((int(i,2))%5==0):
        finalnumbers.append(i)
print(",".join(finalnumbers))




