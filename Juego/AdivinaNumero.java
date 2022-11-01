import java.util.Scanner;

public class AdivinaNumero {

    public static void main(String[] args) {
        
    
    Scanner sc = new Scanner(System.in);

    int a = (int) ((Math.random() * 5)+1); 
    int b; 
    int i; 
   
    System.out.println("El juego consiste en averiguar un número secreto de 100 posibles.");
   
    System.out.print("Tienes 2 intentos. Escribe un número entre 1 y 5: ");
    b = sc.nextInt();
   
    for (i=0; i<=2; i++) { 
   
       // Primero se evalúa si se ha acertado.
       
       if (a == b) {  
         System.out.println("¡Has acertado!"); 
         break; } 
       
       // Luego da la partida por perdida si ya has gastado 5 intentos.     
       
       else if (i == 2) { 
         System.out.println("Lo siento: ¡has perdido!. El número era el: " + a); 
         break; } 
       
       // Si no es ninguno de los casos anteriores, comparamos números.
       
       else if (a > b) 
         System.out.println("El número secreto es mayor que: " + b);
       else if (a < b)
         System.out.println("El número secreto es menor que: " + b);
   
       // Por último un bucle if que sirve para dar una pista y avisarte de la última oportunidad.
       
       if (i <=1) { 
        System.out.print("Otro intento: "); 
        b = sc.nextInt();
    
       } 
    }  
       
    }


}

