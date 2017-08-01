; Calculating the length of a given string

ORG 100h

lea si, arr
mov bx, 0  


myloop:
mov al, [si]
cmp al, last
JZ finish   
inc si
inc bx
LOOP myloop
int 21h
ret

finish:
mov dx, bx
add dx, '0'
mov ah, 2 
int 21h 


ret

arr db "Hello!$"
last db 24h