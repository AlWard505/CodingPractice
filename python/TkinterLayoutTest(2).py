from tkinter import *
x=0
y=0
z=16
main = PanedWindow()
Grid.rowconfigure(main, 0, weight=1)
Grid.columnconfigure(main, 0, weight=1)
main.pack(fill=BOTH, expand=1,side = LEFT)

frame1 = Frame(main,bd = 5, bg = "blue")
frame1.grid(row=0, column=0, sticky=N+S+E+W)
while x != z:
    x+=1
    Grid.rowconfigure(frame1, x, weight=1)
    while y != z:
        y+=1
        Grid.columnconfigure(frame1, y, weight=1)
        button = Button(frame1)
        button.grid(column = x, row = y, sticky=N+S+E+W)  

    y = 0
frame1.pack(anchor = NE)
main.add(frame1,)
main.mainloop()
