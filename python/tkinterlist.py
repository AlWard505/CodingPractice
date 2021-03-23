from tkinter import *


top = Tk()

Lb1 = Listbox(top,selectmode=SINGLE)
Lb1.insert(1, "Python")
Lb1.insert(2, "Perl")
Lb1.insert(3, "C")
Lb1.insert(4, "PHP")
Lb1.insert(5, "JSP")
Lb1.insert(6, "Ruby")
button = Button(top, text = "lol",command =lambda:print(Lb1.curselection()))
button.pack()
Lb1.pack()
top.mainloop()
