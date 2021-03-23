from tkinter import *
x=0
y=0
z=6
main = PanedWindow()
main.pack(fill=BOTH, expand=1,side = LEFT)

frame1 = Frame(main,bd = 5, bg = "blue")
while x != z:
    x+=1
    while y != z:
        y+=1
        button = Button(frame1, text="[]",height=2, width = 4)
        button.grid(column = x, row = y)

    y = 0
frame1.pack(anchor = NE)
frame2=Frame(main,bd=5,bg = "red")
button = Button(frame2, text="[]",height=2, width = 4)
button.pack()
main.add(frame2)
main.add(frame1,)
main.mainloop()
