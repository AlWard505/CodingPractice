import pygame, sys
from pygame.locals import *

#colours
colours = {
    "black" : (0,0,0),
    "white" : (255,255,255),
    "red" : (255,0,0),
    "green" : (0,255,0),
    "blue" : (0,0,255)
    }
pygame.init()
DISPLAYSURF = pygame.display.set_mode((500, 400))
pygame.display.set_caption('PyGameIntro')

#sets the background to white
DISPLAYSURF.fill(colours["white"])

#draws a polygon
pygame.draw.polygon(DISPLAYSURF, colours["green"], ((146, 0), (291, 106), (236, 277), (56, 277), (0, 106)))

#draws a line
pygame.draw.line(DISPLAYSURF, colours["blue"], (60, 60), (120, 60), 4)
pygame.draw.line(DISPLAYSURF, colours["blue"], (120, 60), (60, 120))
pygame.draw.line(DISPLAYSURF, colours["blue"], (60, 120), (120, 120), 4)

#draws a circle
pygame.draw.circle(DISPLAYSURF, colours["blue"], (300, 50), 20, 0)
pygame.draw.ellipse(DISPLAYSURF, colours["red"], (300, 250, 40, 80), 1)

#draws a rectangle
pygame.draw.rect(DISPLAYSURF, colours["red"], (200, 150, 100, 50))


#draws singular pixels
pixObj = pygame.PixelArray(DISPLAYSURF)
pixObj[480][380] = colours["black"]
pixObj[482][382] = colours["black"]
pixObj[484][384] = colours["black"]
pixObj[486][386] = colours["black"]
pixObj[488][388] = colours["black"]
del pixObj


while True: # main game loop
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
    pygame.display.update()

#up to pg 20
