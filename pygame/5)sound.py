import pygame, sys, time
from pygame.locals import *

pygame.init()
DISPLAYSURF = pygame.display.set_mode((400, 300))
pygame.display.set_caption('Text')

colour = {
    "white":(255,255,255),
    }
sound = pygame.mixer.Sound("beep.mp3")


while True: # main game loop
    DISPLAYSURF.fill(colour["white"])

    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
    pygame.display.update()
    sound.play()
    time.sleep(1.3)
    sound.stop()
