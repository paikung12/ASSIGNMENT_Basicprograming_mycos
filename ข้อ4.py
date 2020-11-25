string = input("Enter any string: ")

newstr = string;
watse = ('(', ')');
for i in string.lower():
   if i in watse:
       newstr = newstr.replace(i,"");
    
print(newstr);