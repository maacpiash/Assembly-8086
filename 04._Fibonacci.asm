; Fibonacci series

include 'emu8086.inc'

org 100h

PRINT 'Enter a number: '
call SCAN_NUM
PRINTN ''
mov al, 0
mov bl, 1

FibLoop:

mov al, bl
add num, bl

mov bl, dl
add dl, al
mov num, bl

mov al, num
call PRINT_NUM_UNS
PRINT ', '
 
loop FibLoop  

ret

DEFINE_PRINT_NUM_UNS
DEFINE_SCAN_NUM

num db 0

end




