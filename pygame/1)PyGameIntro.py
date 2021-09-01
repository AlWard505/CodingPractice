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
DISPLAYSURF = pygame.display.set_mode((400, 300))
pygame.display.set_caption('PyGameIntro')
DISPLAYSURF.fill(colours["white"])
while True: # main game loop
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
    pygame.display.update()

