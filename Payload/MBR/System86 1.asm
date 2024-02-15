;   do not skid with this src!
;   this src was created entirely by nk. If u want to use this src, plz enter credit

org 7C00h

start:
    mov ax, 0B800h   
    mov es, ax       
    xor di, di       

    mov cx, 2000     
    mov al, 21h      
    mov ah, 0Ch      

fill_screen:
    stosw            
    loop fill_screen 

    jmp $

times 510 - ($ - $$) db 0
dw 0xAA55