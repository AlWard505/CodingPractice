from tkinter import *
top = Tk()

button1 = Button(text = "NE",command =lambda: print(":)"))
button2 = Button(text = "NW",command =lambda: print(":)"))
button3 = Button(text = "SE",command = lambda:print(":)"))
button4 = Button(text = "SW",command =lambda: print(":)"))
button1.place(anchor = NE)
button2.place(anchor = NE)
button3.place(anchor = NE)
button4.place(anchor = NE)
top.mainloop()
