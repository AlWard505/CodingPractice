from tkinter import *
from random import *
colours=["#A1EC4B","#478301","#D8DD28","#1D4CC5","#B8B8B8","red"]

main = Tk()
Grid.rowconfigure(main, 0, weight=1)
Grid.columnconfigure(main, 0, weight=1)
for x in range(6):
    Grid.rowconfigure(main, x, weight=1)
    for y in range(6):
        Grid.columnconfigure(main, y, weight=1)
        frame = Frame(main, bg = colours[randint(0,5)])
        frame.grid(column = y, row = x,sticky=N+S+E+W)
        
    
