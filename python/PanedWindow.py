from tkinter import *
x = 0
y=0
z=5
m1 = PanedWindow(bg = "red")
m1.pack(fill=BOTH, expand=1,side = LEFT)

left = Label(m1, text="left pane padding padding padding")
m1.add(left)

m2 = PanedWindow(m1, orient=VERTICAL,bg = "black")
m1.add(m2)

top = Label(m2, text="top pane\ntop pane\ntop pane\ntop pane\ntop pane\n",)
m2.add(top)

bottom = Label(m2, text="bottom pane, padding padding padding")
m2.add(bottom)
frame = Frame(m2,bd = 5, bg = "blue")
while x != z:
    x+=1
    while y != z:
        y+=1
        button = Button(frame, text="[]",height=2, width = 4)
        button.grid(column = x, row = y)

    y = 0
frame.pack(anchor = NE)
button = Button(m1, text = "test")
button.pack(anchor = NW)
mainloop()
