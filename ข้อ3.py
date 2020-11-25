string = input("Enter any string: ")

newstr = string;
vowels = ('a', 'e', 'i', 'o', 'u');
for i in string.lower():
   if i in vowels:
       newstr = newstr.replace(i,"");
    
print(newstr);