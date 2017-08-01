; Finding a given number in a given array

ORG 100h

lea si, arr
mov cx, 5

search_loop:
mov al, [si]
cmp al, key
JZ found
inc si
LOOP search_loop
mov dx, offset error
mov ah, 9
int 21h
ret


found:
lea di, arr
mov ax, si
mov bx, di
sub ax, bx
add ax, '0'
mov dx, ax
mov ah, 2
int 21h   
        
ret

arr db 1, 2, 3, 4, 5
key db 2
error db "Key not found$"

end