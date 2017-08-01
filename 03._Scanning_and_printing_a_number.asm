
; You may customize this and other start-up templates; 
; The location of this template is c:\emu8086\inc\0_com_template.txt

include 'emu8086.inc'

org 100h
       
;PRINT 'Enter a number:'

;call PRINT_STRING
PRINT 'Enter a number '

call SCAN_NUM

MOV AX, CX

PRINTN ''

PRINT 'You have entered '
call PRINT_NUM_UNS


ret                    

DEFINE_PRINT_STRING
DEFINE_PRINT_NUM_UNS
DEFINE_SCAN_NUM

end

