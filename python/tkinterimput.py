from tkinter import *
def Getin():
    print(E1.get)
top = Tk()
L1 = Label(top, text="User Name")
L1.pack( side = LEFT)
E1 = Entry(top, bd =5)
E1.pack(side = LEFT)
butt = Button(top, text="Do nothing button", command = Getin)
butt.pack()
top.mainloop()
