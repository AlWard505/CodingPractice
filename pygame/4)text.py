import pygame, sys
from pygame.locals import *

pygame.init()
DISPLAYSURF = pygame.display.set_mode((400, 300))
pygame.display.set_caption('Text')

colour = {
    "white":(255,255,255),
    "green":(0,255,0),
    "blue":(0,0,128)
    }

fontObj = pygame.font.Font("freesansbold.ttf",32)
textSurfaceObj = fontObj.render("hello world!", True, colour["green"],colour["blue"])
textRectObj = textSurfaceObj.get_rect()
textRectObj.center = (200, 150)

while True: # main game loop
    DISPLAYSURF.fill(colour["white"])
    DISPLAYSURF.blit(textSurfaceObj, textRectObj)
    
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
    pygame.display.update()
