from tkinter import *
x = 0
y = 0
main = Tk()

##frame1 = Frame(main,bd = 7,bg = "black")
##frame1.pack(side = LEFT)
##
##frame2 = Frame(main,bd = 7,bg = "red")
##frame2.pack(side = RIGHT)
##
##subframe1 = Frame(frame2,bd = 7)
##subframe1.pack(side=TOP)
##
##
##button1 = Button(subframe1, text="button1")
##button1.pack(side = TOP)

mapframe = Frame(main,bd = 7,bg = "black")
mapframe.pack(anchor=NE)
##othframe = Frame(main,bd = 7,bg = "blue")
##othframe.place()

while x != 3:
    x+=1
    while y != 3:
        y+=1
        button = Button(mapframe, text="[]")
        button.grid(column = x, row = y)
        
        print("testing")
        print(str(x) +","+ str(y))
    y = 0
##button = Button(othframe,text="Test")
##button.pack()
main.mainloop()
