import pygame, sys
from pygame.locals import *

pygame.init()

fps = 30
fpsClock = pygame.time.Clock()

DISPLAYSURF = pygame.display.set_mode((400, 300),0,32)
pygame.display.set_caption("Animation")

colours = {
    "black" : (0,0,0),
    "white" : (255,255,255),
    "red" : (255,0,0),
    "green" : (0,255,0),
    "blue" : (0,0,255)
    }
cube = pygame.image.load("cube.png")
cubex = 10
cubey = 10
direction = "right"

while True:
    DISPLAYSURF.fill(colours["white"])

    if direction == "right":
        cubex +=5
        if cubex==380:
            direction = "down"
    elif direction == 'down':
        cubey += 5
        if cubey == 280:
            direction = 'left'
    elif direction == 'left':
        cubex -= 5
        if cubex == 10:
            direction = 'up'
    elif direction == 'up':
        cubey -= 5
        if cubey == 10:
            direction = 'right'

    #draws the image onto the surface object
    DISPLAYSURF.blit(cube, (cubex, cubey))
    
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
    pygame.display.update()
    #sets the frames per seconds
    fpsClock.tick(fps)
    
