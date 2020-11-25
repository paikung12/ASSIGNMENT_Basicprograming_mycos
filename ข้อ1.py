num = int(input("Enter Number:"))
sum = 0
total = num

while total > 0:
    rem = total % 10
    sum += rem ** 3
    total //= 10
    
if num == sum:
    print(num,"ArmsrongNumber")
else:
    print(num,"Not_ArmsrongNumber")

    