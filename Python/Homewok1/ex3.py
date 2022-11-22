print ("Input X")
x = float(input())
print ("Input Y")
y = float(input())
if x == 0 or y == 0 :
    print ("X or Y = 0")
elif x > 0 and y > 0 :
    print ('You is at up right quarter')
elif x > 0 and y < 0 :
    print ('You is at down right quarter')
elif x < 0 and y > 0 :
    print ('You is at up left quarter')
elif x < 0 and y < 0 :
    print ('You is at down left quarter')

