from tkinter import *
x=0
y=0
z=32
main = PanedWindow()
main.pack(fill=BOTH, expand=1,side = LEFT)

frame1 = Frame(main,bd = 5, bg = "blue")
while x != z:
    x+=1
    while y != z:
        y+=1
        button = Button(frame1, image = "",height=1, width = 1)
        button.grid(column = x, row = y)

    y = 0
frame1.pack(anchor = NE)
main.add(frame1,)
main.mainloop()
